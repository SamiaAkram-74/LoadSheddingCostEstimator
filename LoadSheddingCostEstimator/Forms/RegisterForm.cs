using System;
using System.Windows.Forms;
using LoadSheddingCostEstimator.Database;
using LoadSheddingCostEstimator.Models;   // ← Model namespace

namespace LoadSheddingCostEstimator.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            try
            {
                // ✅ User MODEL object banao — sirf raw strings nahi
                User newUser = new User
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text   // (BCrypt hash here in production)
                };

                // Model object se values DBHelper ko pass karo
                string query = "INSERT INTO Users (Username, Password) VALUES (@u, @p)";

                DBHelper.ExecuteNonQuery(query,
                    DBHelper.Param("@u", newUser.Username),
                    DBHelper.Param("@p", newUser.Password));

                MessageBox.Show("Registration Successful! Please login now.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }
    }
}
