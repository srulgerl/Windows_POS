using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using pos;
using posLibrary;


namespace WinFormsApp1
{
    public partial class MainScreen : Form
    {
        public List<Product> productList = new List<Product>();
        public List<Category> categoryList = new List<Category>();
        public Cart cart = new Cart();
        User currentUser;

        public MainScreen(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadData();
            SetUpMenusByRole();

        }
        private void LoadData()
        {
            string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "pos.db");
            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                string sql = @"
                SELECT p.id, p.name, p.price, p.quantity, p.discount, p.category_id, c.name as categoryName, p.barcode
                FROM products p
                JOIN categories c ON p.category_id = c.id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var category = new Category(
                                reader.GetInt32(5),
                                reader.GetString(6)
                            );
                            var product = new Product(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetDecimal(2),
                                reader.GetInt32(3),
                                reader.GetInt32(4),
                                category,
                                reader.GetInt32(7)
                            );
                            productList.Add(product);
                        }
                    }
                }

                string categorySql = "SELECT id, name FROM categories";
                using (var cmd = new SQLiteCommand(categorySql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var category = new Category(
                                reader.GetInt32(0),
                                reader.GetString(1)
                            );
                            categoryList.Add(category);
                        }
                    }
                }



                conn.Close();
            }
        }

        public void SetUpMenusByRole()
        {
            helpToolStripMenuItem.Visible = true;
            productsToolStripMenuItem.Visible = true;

            if (currentUser.userName == "Manager")
            {
                categoryToolStripMenuItem.Visible = true;
            }
            else
            {
                categoryToolStripMenuItem.Visible = false;
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            ShowProducts();
            ShowCategories();
            UserNameLbl.Text = currentUser.userName;
            label2.Text = $"{DateTime.Now:yyyy/MM/dd HH:mm:ss}";

        }

        private void ShowCategories()
        {
            foreach (var category in categoryList)
            {
                Panel categoryPanel = new Panel();
                categoryPanel.Width = 200;
                categoryPanel.Height = 200;
                categoryPanel.BorderStyle = BorderStyle.FixedSingle;
                categoryPanel.Margin = new Padding(10);
                categoryPanel.BackColor = Color.CornflowerBlue;
                categoryPanel.Paint += new PaintEventHandler(RoundPanel_Paint);
                categoryPanel.Tag = category;

                Button nameLabel = new Button();
                nameLabel.Text = category.categoryName;
                nameLabel.Dock = DockStyle.Fill;
                nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                nameLabel.Click += CategoryPanel_Click;
                nameLabel.ForeColor = Color.White;

                categoryPanel.Controls.Add(nameLabel);

                categoryflowPanel.Controls.Add(categoryPanel);
            }
        }

        private void CategoryPanel_Click(object sender, EventArgs e)
        {

            if (sender is Button button && button.Parent is Panel panel && panel.Tag is Category category)
            {
                try
                {
                    string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "pos.db");
                    using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                    {
                        conn.Open();
                        string sql = @"
                        SELECT p.id, p.name, p.price, p.quantity, p.discount, p.barcode, c.id, c.name
                        FROM products p
                        JOIN categories c ON p.category_id = c.id
                        WHERE c.id = @categoryId";

                        using (var cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@categoryId", category.categoryId);
                            using (var reader = cmd.ExecuteReader())
                            {
                                productFlowPanel.Controls.Clear();
                                while (reader.Read())
                                {
                                    var productCategory = new Category
                                    (
                                       reader.GetInt32(6),
                                       reader.GetString(7)
                                    );

                                    var product = new Product
                                    (
                                         reader.GetInt32(0),
                                         reader.GetString(1),
                                         reader.GetDecimal(2),
                                         reader.GetInt32(3),
                                         reader.GetInt32(4),
                                         productCategory,

                                         reader.GetInt32(5)

                                    );
                                    drawProductPanel(product);
                                }
                            }
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ShowProducts()
        {

            foreach (var product in productList)
            {
                drawProductPanel(product);

            }
        }

        public void drawProductPanel(Product product)
        {
            Panel productPanel = new Panel();
            productPanel.Width = 200;
            productPanel.Height = 200;
            productPanel.BorderStyle = BorderStyle.FixedSingle;
            productPanel.Margin = new Padding(10);
            productPanel.Click += ProductPanel_Click;
            productPanel.Tag = product;

            Label nameLabel = new Label();
            nameLabel.Text = product.ProductName;
            nameLabel.Location = new Point(10, 10);
            nameLabel.AutoSize = true;

            Label priceLabel = new Label();
            priceLabel.Text = $"${product.ProductPrice}";
            priceLabel.Location = new Point(10, 35);
            priceLabel.AutoSize = true;

            productPanel.Controls.Add(nameLabel);
            productPanel.Controls.Add(priceLabel);

            productFlowPanel.Controls.Add(productPanel);
        }

        private void ProductPanel_Click(object sender, EventArgs e)
        {
            if (sender is Panel panel && panel.Tag is Product product)
            {
                CartItem item = new CartItem(product, 1);
                try
                {
                    cart.AddCartItem(item);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Анхааруулга", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                bool isExisting = false;
                foreach (Control control in transactionPanel.Controls)
                {
                    if (control is OrderItem orderItm && orderItm.item.Product.ProductId == item.Product.ProductId)
                    {
                        orderItm.QtyLbl.Text = orderItm.item.Quantity.ToString();
                        orderItm.totalLbl.Text = "$" + orderItm.item.TotalPrice.ToString("F2");
                        isExisting = true;
                        break;
                    }
                }

                if (!isExisting)
                {
                    OrderItem orderItem = new OrderItem(item);
                    orderItem.QuantityChanged += (s, args) =>
                    {
                        refreshTotalPrice();
                    };
                    orderItem.BringToFront();
                    orderItem.Visible = true;
                    transactionPanel.Controls.Add(orderItem);
                }

                refreshTotalPrice();
                transactionPanel.Invalidate();
            }
        }

        private void refreshTotalPrice()
        {
            TotalPrice.Text = "$" + cart.CalculateTotal().ToString("F2");
        }

        private void RoundPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int radius = 20;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }



        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string input = searchTxtBox.Text;

            Product matchedProduct = null;

            foreach (var product in productList)
            {
                if (product.Barcode.ToString() == input)
                {
                    matchedProduct = product;
                    productFlowPanel.Controls.Clear();
                    drawProductPanel(product);
                    return;
                }
            }
            if (matchedProduct == null)
            {
                MessageBox.Show($"tuhain code-toi baraa oldsongui");
                searchTxtBox.ResetText();
            }

        }


        private void payBtn_Click(object sender, EventArgs e)
        {
            string priceText = TotalPrice.Text.Replace("$", "").Trim();
            decimal totalPrice = decimal.Parse(priceText);
            PaymentForm paymentForm = new PaymentForm(totalPrice, currentUser, cart);
            paymentForm.ShowDialog();

            cart = new Cart();
            transactionPanel.Controls.Clear();
            productFlowPanel.Controls.Clear();
            productList.Clear();
            refreshTotalPrice();
            LoadData();
            ShowProducts();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainContentPanel.Controls.Clear();

            var productMenu = new ProductMenu();
            productMenu.Dock = DockStyle.Fill;
            mainContentPanel.Controls.Add(productMenu);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainContentPanel.Controls.Clear();

            LoadData();
            ShowProducts();
            ShowCategories();
            refreshTotalPrice();
        }
        public void Reload()
        {
            cart = new Cart(); 
            productList.Clear();
            categoryList.Clear();

            transactionPanel.Controls.Clear();
            productFlowPanel.Controls.Clear();
            categoryflowPanel.Controls.Clear();
            mainContentPanel.Controls.Clear();

            
        }

    }
}
   
