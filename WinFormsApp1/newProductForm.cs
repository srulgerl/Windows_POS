using posLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class newProductForm : Form
    {
        private List<Category> categoryList;


        public newProductForm()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            categoryList = new List<Category>();
            string connStr = "Data Source=pos.db;Version=3;";
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT id, name FROM categories";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                categoryList.Add(new Category(id, name));
                            }
                        }
                       
                    }
                }
                cmbBoxCategory.DataSource = categoryList;
                cmbBoxCategory.DisplayMember = "categoryName";
                cmbBoxCategory.ValueMember = "categoryId";   
                if (categoryList.Count > 0)
                    cmbBoxCategory.SelectedIndex = 0;
                else
                    cmbBoxCategory.Enabled = false;
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show($"Өгөгдлийн сангийн алдаа: {ex.Message}");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(nameTxtLbl.Text))
            {
                MessageBox.Show("Бүтээгдэхүүний нэр оруулна уу.");
                return;
            }

            if (!decimal.TryParse(priceTxtLbl.Text, out decimal productPrice) || productPrice <= 0)
            {
                MessageBox.Show("Үнэ зөв оруулна уу");
                return;
            }

            if (!int.TryParse(qtyTxtLbl.Text, out int productQuantity) || productQuantity < 0)
            {
                MessageBox.Show("Нөөцийн тоо зөв оруулна уу");
                return;
            }
           
            // Save to database
            try
            {
                string str = "Data Source=pos.db;Version=3;";
                using (var conn = new SQLiteConnection(str))
                {
                    conn.Open();
                    string sql = @"
                        INSERT INTO products (name, price, quantity, category_id, discount, barcode)
                        VALUES (@productName, @productPrice, @quantity, @category, @discount, @barcode)";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@barcode", barcodeTxtLbl.Text);
                        cmd.Parameters.AddWithValue("@productName", nameTxtLbl.Text);
                        cmd.Parameters.AddWithValue("@productPrice", priceTxtLbl.Text);
                        cmd.Parameters.AddWithValue("@quantity", qtyTxtLbl.Text);
                        cmd.Parameters.AddWithValue("@discount", discTxtLbl.Text);
                        cmd.Parameters.AddWithValue("@category", cmbBoxCategory.SelectedValue);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Бүтээгдэхүүн амжилттай нэмэгдлээ!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Өгөгдлийн сангийн алдаа: {ex.Message}");
            }
        
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
