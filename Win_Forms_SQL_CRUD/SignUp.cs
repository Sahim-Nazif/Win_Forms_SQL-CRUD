using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Forms_SQL_CRUD
{
    public partial class SignUp : Form
    {
        string userName, userEmail, userPassword, userCity;
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            userName = txtName.Text;
            userEmail = txtEmail.Text;
            userPassword = txtPassword.Text;
            userCity = txtCity.Text;


            //validation if any input field is blank
            if (userName.Equals(""))
            {
                MessageBox.Show("Please enter your name ! ");

            }
            if (userEmail.Equals(""))
            {
                MessageBox.Show("Please enter your email address ! ");

            }
            if (userPassword.Equals(""))
            {
                MessageBox.Show("Please enter a password ! ");

            }
            if (userCity.Equals(""))
            {
                MessageBox.Show("Please select your city from the dropdown menu ! ");

            }
        }
    }
}
