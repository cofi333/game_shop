using Microsoft.Win32;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      
        private void login_button_Click(object sender, EventArgs e)
        {
            string con = "server=localhost;user=root;database=game_shop;password=";
            MySqlConnection mySqlconnection = new MySqlConnection(con);
            mySqlconnection.Open();
            string login = "SELECT * FROM users WHERE username= '" + txt_username.Text + "'and password= '" + txt_password.Text + "'";
            MySqlCommand cmd = new MySqlCommand(login, mySqlconnection);
            MySqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read() == true)
            {
                new Main().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBtn_show_password.Checked)
            {
                txt_password.PasswordChar = '\0';
       
            }
            else
            {
                txt_password.PasswordChar = '●';
               
            }
        }
    }
}
