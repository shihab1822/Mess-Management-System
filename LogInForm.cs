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

            // Authenticate user from database
            string query = "SELECT * FROM Users WHERE Username=@username AND Password=@password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string role = reader["Role"].ToString();
                switch (role)
                {
                    case "Manager":
                        ManagerDashboard managerDashboard = new ManagerDashboard();
                        managerDashboard.Show();
                        break;
                    case "Member":
                        MemberDashboard memberDashboard = new MemberDashboard();
                        memberDashboard.Show();
                        break;
                    case "HouseOwner":
                        HouseOwnerDashboard houseOwnerDashboard = new HouseOwnerDashboard();
                        houseOwnerDashboard.Show();
                        break;
                    case "Chief":
                        ChiefDashboard chiefDashboard = new ChiefDashboard();
                        chiefDashboard.Show();
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

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm sp = new SignUpForm();
            sp.Show(this);
            
        }
    }
}
