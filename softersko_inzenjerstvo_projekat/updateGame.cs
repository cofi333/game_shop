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
    public partial class updateGame : Form
    {
        public updateGame()
        {
            InitializeComponent();
        }

       

        private void loadCombo(string sql, string DisplayMember, string ValueMember)
        {

            string con = "server=localhost;user=root;database=game_shop;password=";
            MySqlConnection mySqlconnection = new MySqlConnection(con);
            MySqlCommand cmd;
            MySqlDataAdapter da;
            DataTable dt;


            try
            {
                mySqlconnection.Open();
                cmd = new MySqlCommand();
                cmd.Connection = mySqlconnection;
                cmd.CommandText = sql;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                gameList.DataSource = dt;
                gameList.DisplayMember = DisplayMember;
                gameList.ValueMember = ValueMember;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                mySqlconnection.Close();

            }
        }

        private void updateGame_Load_1(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM `games`";
            loadCombo(sql, "game_name", "game_id");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int updatedFields = 0;

            string con = "server=localhost;user=root;database=game_shop;password=";
            MySqlConnection mySqlconnection = new MySqlConnection(con);
            mySqlconnection.Open();
            string gameNum = gameList.SelectedValue.ToString();
            int game = Int32.Parse(gameNum);


            if (!string.IsNullOrEmpty(gameName.Text))
            {
                string updateName = "UPDATE games SET game_name= '" + gameName.Text + "' WHERE game_id= '" + game + "'";
                MySqlCommand cmd = new MySqlCommand(updateName, mySqlconnection);
                cmd.ExecuteNonQuery();
                updatedFields++;
            }

            if (!string.IsNullOrEmpty(gameCategory.Text))
            {
                string updateCategory = "UPDATE games SET game_category= '" + gameCategory.Text + "' WHERE game_id= '" + game + "'";
                MySqlCommand cmd = new MySqlCommand(updateCategory, mySqlconnection);
                cmd.ExecuteNonQuery();
                updatedFields++;
            }

           

            if (!string.IsNullOrEmpty(gamePrice.Text))
            {
                string updateGamePrice = "UPDATE games SET game_price= '" + gamePrice.Text + "' WHERE game_id= '" + game + "'";
                MySqlCommand cmd = new MySqlCommand(updateGamePrice, mySqlconnection);
                cmd.ExecuteNonQuery();
                updatedFields++;
            }

            if(!string.IsNullOrEmpty(gamePictureUrl.Text))
            {
                System.Drawing.Image image = DownloadImageFromUrl(gamePictureUrl.Text.Trim());

                string rootPath = @"C:\xampp\htdocs\game_shop\assets";
                string fileName = System.IO.Path.Combine(rootPath, gamePictureName.Text + ".jpg");
                image.Save(fileName);
                updatedFields++;
            }

            if (!string.IsNullOrEmpty(gamePictureName.Text))
            {
                string updatePictureName = "UPDATE games SET game_picture= '" + gamePictureName.Text + ".jpg" + "' WHERE game_id= '" + game + "'";
                MySqlCommand cmd = new MySqlCommand(updatePictureName, mySqlconnection);
                cmd.ExecuteNonQuery();
                updatedFields++;
            }

            if (updatedFields > 0)
            {
                MessageBox.Show("Game updated!");
                string sql = "SELECT * FROM `games`";
                loadCombo(sql, "game_name", "game_id");
                gameName.Text = "";
                gameCategory.Text = "";
                gamePrice.Text = "";
                gamePictureUrl.Text = "";
                gamePictureName.Text = "";


            }
            else
            {
                MessageBox.Show("Game not updated");
            }

            

        }

        public System.Drawing.Image DownloadImageFromUrl(string imageUrl)
        {
            System.Drawing.Image image = null;

            try
            {
                System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                System.Net.WebResponse webResponse = webRequest.GetResponse();

                System.IO.Stream stream = webResponse.GetResponseStream();

                image = System.Drawing.Image.FromStream(stream);

                webResponse.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return image;
        }
    }
}
