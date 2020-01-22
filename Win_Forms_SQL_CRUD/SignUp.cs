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

namespace Win_Forms_SQL_CRUD
{
    public partial class SignUp : Form
    {

        //creating object of Dbaccess class
        DBAccess _dbAcccess = new DBAccess();
        string userName, userEmail, userPassword, userCity;

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = null;
            txtEmail.Text = null;
            txtPassword.Text = null;
            txtCity.Text = null;
        }

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
            else if(userEmail.Equals(""))
            {
                MessageBox.Show("Please enter your email address ! ");

            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Please enter a password ! ");

            }
           else if (userCity.Equals(""))
            {
                MessageBox.Show("Please select your city from the dropdown menu ! ");

            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert  into Users(Name,Email,Password,City)values(@userName,@userEmail,@userPassword,@userCity)");
                insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
                insertCommand.Parameters.AddWithValue("@userPassword", userPassword);
                insertCommand.Parameters.AddWithValue("@userCity", userCity);

              int row=   _dbAcccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account has been created successfully !");
                    this.Hide();
                    HomePage homePage = new HomePage();
                    homePage.Show();
                }
                else
                {
                    MessageBox.Show("Error ! Try again... ");
                }

            }
        }
    }
}
