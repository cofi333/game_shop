using MySql.Data.MySqlClient;

namespace softersko_inzenjerstvo_projekat
{
    public partial class Register : Form
    {


        public Register()
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void checkBtn_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBtn_show_password.Checked)
            {
                txt_password.PasswordChar = '\0';
                txt_confirm_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar= '●';
                txt_confirm_password.PasswordChar = '●';
            }
        }

        private void signUp_button_Click(object sender, EventArgs e)
        {
            if(txt_username.Text == "" || txt_password.Text == "" || txt_confirm_password.Text == "")
            {
                MessageBox.Show("Please enter all fields.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
            else if (txt_password.Text == txt_confirm_password.Text)
            {
                try
                {
                    string con = "server=localhost;user=root;database=game_shop;password=";
                    MySqlConnection mySqlconnection = new MySqlConnection(con);
                    mySqlconnection.Open();
                    string check = "SELECT COUNT(*) FROM users WHERE username= '"+txt_username.Text + "'";
                    MySqlCommand checkCmd = new MySqlCommand(check, mySqlconnection);
                    int userExist = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userExist == 1) {
                        mySqlconnection.Close();
                        MessageBox.Show("User " + txt_username.Text + " already exist. Please enter a new name.","Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string register = "INSERT INTO users(username,password) VALUES ('" + txt_username.Text + "','" + txt_password.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(register, mySqlconnection);
                        cmd.ExecuteNonQuery();
                        mySqlconnection.Close();
                        MessageBox.Show("Your Account has been Successfuly created.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Passwords does not match, please re-enter.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}