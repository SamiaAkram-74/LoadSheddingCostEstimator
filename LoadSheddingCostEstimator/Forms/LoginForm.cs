using System;
using System.Data;
using System.Windows.Forms;
using LoadSheddingCostEstimator.Database;
using LoadSheddingCostEstimator.Models;   // ← Model namespace

namespace LoadSheddingCostEstimator.Forms
{
    public partial class LoginForm : Form
    {
        /// <summary>UserID of the currently logged-in user (shared across forms).</summary>
        public static int LoggedInUserID;

        public LoginForm()
        {
            InitializeComponent();
        }
        //Form → Model Object → DBHelper → Database → Result → Model Object → Form display
        private void LoginForm_Load(object sender, EventArgs e) { }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                lblError.Text = "Please enter username and password!";
                return;
            }

            try
            {
                // ✅ User MODEL object banao — form input se populate karo
                User loginAttempt = new User
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text
                };

                // Model ke properties se query chalao
                string query = "SELECT UserID, Username FROM Users WHERE Username=@u AND Password=@p";
               
                DataTable dt = DBHelper.GetDataTable(query,      // dt mein UserID aur Username dono aayenge agar login successful hua toh
                    DBHelper.Param("@u", loginAttempt.Username),
                    DBHelper.Param("@p", loginAttempt.Password));

                if (dt.Rows.Count > 0)
                {
                    // ✅ Result ko bhi User MODEL mein map karo
                    User loggedInUser = new User
                    {
                        UserID   = Convert.ToInt32(dt.Rows[0]["UserID"]),
                        Username = dt.Rows[0]["Username"].ToString()
                    };

                    // Static field mein User model se UserID store karo
                    LoggedInUserID = loggedInUser.UserID;

                    MessageBox.Show("Login SUCCESS - Opening Dashboard");

                    DashboardForm d = new DashboardForm();
                    d.StartPosition = FormStartPosition.CenterScreen;
                    d.Show();
                    d.BringToFront();
                    d.Activate();
                    this.Hide();
                }
                else
                {
                    lblError.Text = "Invalid Username or Password! Create Account First";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            lblError.Text    = "";
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm r = new RegisterForm();
            r.Show();
            this.Hide();
        }
    }
}
