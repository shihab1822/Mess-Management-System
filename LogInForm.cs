using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mess_Management_System
{
    public partial class LogInForm : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=hp;Initial Catalog=\"Mess Management System\";Integrated Security=True;TrustServerCertificate=True");
        
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role;

            string query = "SELECT * FROM Users WHERE Username=@username AND Password=@password";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = reader["Role"].ToString();
                            switch (role)
                            {
                                case "Manager":
                                    new ManagerDashboard(username).Show(this);
                                    break;
                                case "Member":
                                    new MemberDashboard(username).Show(this);
                                    break;
                                case "House Owner":
                                    new HouseOwnerDashboard(username).Show(this);
                                    break;
                                case "Chief":
                                    new ChiefDashboard(username).Show(this);
                                    break;
                                default:
                                    MessageBox.Show("Invalid role");
                                    break;
                            }
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm sp = new SignUpForm();
            sp.Show(this);

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
