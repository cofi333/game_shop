using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softersko_inzenjerstvo_projekat
{
    public partial class createAdminAccount : Form
    {
        public createAdminAccount()
        {
            InitializeComponent();
            
          
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {


             if(adminUsername.Text =="" && adminPassword.Text=="" && adminConfirmPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (adminPassword.Text == adminConfirmPassword.Text)
            {
                string con = "server=localhost;user=root;database=game_shop;password=";
                MySqlConnection mySqlconnection = new MySqlConnection(con);
                mySqlconnection.Open();
                string check = "SELECT COUNT(*) FROM admin WHERE admin_username = @name";
                MySqlCommand checkCmd = new MySqlCommand(check, mySqlconnection);
                checkCmd.Parameters.AddWithValue("@name", adminUsername.Text);
                int userExist = Convert.ToInt32(checkCmd.ExecuteScalar());

                if(userExist == 0)
                {
                    string register = "INSERT INTO admin VALUES ('',@value1,@value2)";
                    MySqlCommand cmd = new MySqlCommand(register, mySqlconnection);
                    cmd.Parameters.AddWithValue("@value1", adminUsername.Text);
                    cmd.Parameters.AddWithValue("@value2", adminPassword.Text);
                    cmd.ExecuteNonQuery();
                    mySqlconnection.Close();

                    MessageBox.Show("Your Account has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Admin with that name already exist.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

            else
            {
                MessageBox.Show("Passwords does not match, please re-enter.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void checkBtn_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBtn_show_password.Checked)
            {
                adminPassword.PasswordChar = '\0';
                adminConfirmPassword.PasswordChar = '\0';

            }
            else
            {
                adminPassword.PasswordChar = '●';
                adminConfirmPassword.PasswordChar = '●';


            }
        }
    }
}
