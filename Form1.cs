using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.DAL;
using FuturePathStudentAdvisingSystem.Business.Entities;

namespace FuturePathStudentAdvisingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserAccount user = new UserAccountDAL().Login(txtUsername.Text, txtPassword.Text);

                if (user == null)
                {
                    lblResult.Text = "Invalid username or password.";
                    return;
                }

                lblResult.Text = "Welcome " + user.Username + " (" + user.Role + ")";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }
    }
}
