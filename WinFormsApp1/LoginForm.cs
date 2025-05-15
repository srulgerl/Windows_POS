
using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;
using posLibrary;

namespace WinFormsApp1
{

    public partial class LoginForm : Form
    {
        DataBaseConnection DataBaseConnection = new DataBaseConnection();
        public LoginForm()
        {
            InitializeComponent();
            DataBaseConnection.CreateDatabase();
        }
        

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = userCombBox.SelectedItem?.ToString();
            string password = passLbl.Text.Trim();
            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Хэрэглэгчийн нэр болон нууц үгээ оруулна уу.");
                return;
            }

            string connStr = "Data Source=pos.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT id, username, role FROM users WHERE username = @username AND password = @password";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = reader.GetInt32(reader.GetOrdinal("id"));
                            string role = reader.GetString(reader.GetOrdinal("role"));

                            User user = role switch
                            {
                                "Manager" => new Manager(userId, username),
                                "Cashier" => new Cashier(userId, username),
                                _ => throw new InvalidOperationException("Unknown user role")
                            };

                            MainScreen form2 = new MainScreen(user);
                            form2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Нэвтрэх мэдээлэл буруу байна.");
                        }
                    }
                }
            }
        }
    }
}
