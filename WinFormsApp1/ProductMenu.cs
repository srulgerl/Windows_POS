using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProductMenu : UserControl
    {

        public ProductMenu()
        {
            InitializeComponent();
            this.Load += Product_Load;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        public void LoadProducts()
        {
            string connStr = "Data Source=pos.db;Version=3;";

            using (var conn = new SQLiteConnection(connStr))
            using (var cmd = new SQLiteCommand("SELECT * FROM products", conn))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                dgvProducts.DataSource = dt;

                dgvProducts.ReadOnly = false;
                dgvProducts.AllowUserToAddRows = false;
                dgvProducts.AllowUserToDeleteRows = false;
            }
        }

        private void dgvProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvProducts.Rows[e.RowIndex];
            var id = Convert.ToInt32(row.Cells["id"].Value);
            string colName = dgvProducts.Columns[e.ColumnIndex].Name;
            var newValue = row.Cells[e.ColumnIndex].Value;

            string connStr = "Data Source=pos.db;Version=3;";
            using (var conn = new SQLiteConnection(connStr))
            using (var cmd = new SQLiteCommand(conn))
            {
                conn.Open();
                cmd.CommandText = $"UPDATE products SET {colName} = @val WHERE id = @id";
                cmd.Parameters.AddWithValue("@val", newValue);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

        }

        private void productFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            var newProductForm = new newProductForm(this);
            newProductForm.ShowDialog();
            newProductForm.FormClosing += (s, args) =>
            {
                LoadProducts();
            };
        }
    }
}
