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
        private ProductMenu productMenuForm;
        public newProductForm(ProductMenu productMenuForm)
        {
            InitializeComponent();
            this.productMenuForm = productMenuForm;
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
            string connStr = "Data Source=pos.db;Version=3;";
            try
            {
                using (var conn = new SQLiteConnection(connStr))
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
                        cmd.Parameters.AddWithValue("@category", ctgIdTxtLbl.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Бүтээгдэхүүн амжилттай нэмэгдлээ!");
                this.Close();
                productMenuForm.LoadProducts(); 
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Өгөгдлийн сангийн алдаа: {ex.Message}");
            }
        
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
