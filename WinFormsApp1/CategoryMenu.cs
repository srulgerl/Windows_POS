using posLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CategoryMenu : UserControl
    {
        private User currentUser;
        public CategoryMenu(User user)
        {
            InitializeComponent();
            currentUser = user;
            insertBtn.Visible = currentUser.hasPermission("addCategory");
            this.Load += Category_Load;
            LoadData();
        }

        public void Category_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string connStr = "Data Source=pos.db;Version=3;";
            using (var conn = new SQLiteConnection(connStr))
            using (var cmd = new SQLiteCommand("SELECT * FROM categories", conn))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                dgvCategories.DataSource = dt;
                dgvCategories.ReadOnly = false;
                dgvCategories.AllowUserToAddRows = false;
                dgvCategories.AllowUserToDeleteRows = false;
            }
        }

        private void dgvCategories_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvCategories.Rows[e.RowIndex];
            var id = Convert.ToInt32(row.Cells["id"].Value);
            string colName = dgvCategories.Columns[e.ColumnIndex].Name;
            var newValue = row.Cells[e.ColumnIndex].Value;
            string connStr = "Data Source=pos.db;Version=3;";
            using (var conn = new SQLiteConnection(connStr))
            using (var cmd = new SQLiteCommand(conn))
            {
                conn.Open();
                cmd.CommandText = $"UPDATE categories SET {colName} = @val WHERE id = @id";
                cmd.Parameters.AddWithValue("@val", newValue);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        private void CategoryMenu_Load(object sender, EventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            var insertForm = new InsertCategoryForm();
            insertForm.FormClosed += (s, args) => LoadData();
            insertForm.ShowDialog();
        }
    }
}
