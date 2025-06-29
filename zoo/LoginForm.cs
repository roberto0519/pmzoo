using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace zoo
{
    public partial class LoginForm: Form
    {
        private string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_11";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            AuthenticateUser(login, password);
        }

        private void AuthenticateUser(string login, string password)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT password, username, isadmin FROM pm_11.users WHERE username = @login";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@login", login);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader["password"].ToString();
                                string inputHash = CalculateMD5Hash("ilya1706" + password);

                                if (inputHash == storedHash)
                                {
                                    string user = reader["username"].ToString();
                                    bool isAdmin = (bool)reader["isadmin"];

                                    MessageBox.Show($"Добро пожаловать, {user}!");

                                    Hide();
                                    var mainForm = new MainForm(user, isAdmin);
                                    mainForm.ShowDialog();
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("Неверный пароль");
                                    ClearForm();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Пользователь не найден");
                                ClearForm();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private void ClearForm()
        {
            txtLogin.Clear();
            txtPassword.Clear();
            txtLogin.Focus();
        }
    }
}

