using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WinFormsApp1
{
    public partial class InsertCategoryForm : Form
    {
        public InsertCategoryForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Категорийн нэр оруулна уу.", "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connStr = "Data Source=pos.db;Version=3;";
            try
            {
                using (var conn = new SQLiteConnection(connStr))
                using (var cmd = new SQLiteCommand(conn))
                {
                    conn.Open();

                    cmd.CommandText = "SELECT COUNT(*) FROM categories WHERE name = @name";
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    long count = (long)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Ийм нэртэй категори аль хэдийн байна.", "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cmd.CommandText = "INSERT INTO categories (name) VALUES (@name)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Шинэ категори амжилттай нэмэгдлээ.", "Амжилт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Өгөгдлийн сангийн алдаа: {ex.Message}", "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}