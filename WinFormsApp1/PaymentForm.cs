using pos;
using System;
using System.Windows.Forms;
using posLibrary;
using System.Data.SQLite;
using System.Transactions;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class PaymentForm : Form
    {
        private decimal totalAmount;
        private User currentUser;
        private Cart cart;

        public PaymentForm(decimal totalAmount, User user, Cart cart)
        {
            InitializeComponent();
            this.totalAmount = totalAmount;
            this.currentUser = user;
            this.cart = cart;   
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            TotalPriceLbl.Text = totalAmount.ToString("F2");
        }

        private async void PayBtn_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(CashTxtBox.Text, out decimal paidAmount))
            {
                if (paidAmount < totalAmount)
                {
                    MessageBox.Show("Оруулсан дүн хүрэлцэхгүй байна!");
                    return;
                }

                decimal change = paidAmount - totalAmount;
                ChangeLbl.Text = change.ToString("F2");

                long transactionId;
                List<Order> orders = new List<Order>();

                string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "pos.db");
                using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        // Transaction insert
                        string insertTransactionSql = @"
                        INSERT INTO transactions (user_id, total_price)
                        VALUES (@userId, @totalPrice);
                        SELECT last_insert_rowid();";

                        
                        using (var cmd = new SQLiteCommand(insertTransactionSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", currentUser.userId);
                            cmd.Parameters.AddWithValue("@totalPrice", totalAmount);
                            transactionId = (long)cmd.ExecuteScalar();
                        }

                        // Transaction items insert
                        foreach (var item in cart.Items)
                        {   
                            string insertItemSql = @"
                            INSERT INTO transaction_items (transaction_id, product_id, quantity)
                            VALUES (@transactionId, @productId, @quantity);";

                            using (var cmd = new SQLiteCommand(insertItemSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@transactionId", transactionId);
                                cmd.Parameters.AddWithValue("@productId", item.Product.ProductId);
                                cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                                cmd.ExecuteNonQuery();
                            }

                            // Update product quantity
                            string updateProductSql = @"
                            UPDATE products
                            SET quantity = quantity - @quantity
                            WHERE id = @productId;";
                            using (var cmd = new SQLiteCommand(updateProductSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                                cmd.Parameters.AddWithValue("@productId", item.Product.ProductId);
                                cmd.ExecuteNonQuery();
                            }

                        }

                        await transaction.CommitAsync();
                    }

                    string query = @"SELECT  p.id, p.name,  p.price, ti.quantity
                    FROM transaction_items ti 
                    JOIN products p ON p.id = ti.product_id 
                    WHERE ti.transaction_id = @transactionId;";            
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", transactionId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var order = new Order(
                                    reader.GetInt32(0),               
                                    reader.GetString(1),           
                                    reader.GetDecimal(2),            
                                    reader.GetInt32(3)               
                                );
                                orders.Add(order);
                            }
                        }
                    }

                    conn.Close();
                }
                MyPrint printer = new MyPrint(orders, currentUser, transactionId, paidAmount);
                printer.PrintReceipt();

                this.Close(); 
            }
            else
            {
                MessageBox.Show("Мөнгөн дүн буруу байна.");
            }
        }

    }
}
