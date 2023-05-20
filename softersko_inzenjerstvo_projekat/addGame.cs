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
    public partial class addGame : Form
    {
        public addGame()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string con = "server=localhost;user=root;database=game_shop;password=";
            MySqlConnection mySqlconnection = new MySqlConnection(con);
            mySqlconnection.Open();

            System.Drawing.Image image = DownloadImageFromUrl(gamePictureUrl.Text.Trim());

            string rootPath = @"C:\xampp\htdocs\softersko\assets";
            string fileName = System.IO.Path.Combine(rootPath, gamePictureName.Text + ".jpg");
            image.Save(fileName);

            string insert = "INSERT INTO games VALUES(@value0,@value1,@value2,@value3,@value4)";
            MySqlCommand cmd = new MySqlCommand(insert, mySqlconnection);
            cmd.Parameters.AddWithValue("@value0", gameID.Text);
            cmd.Parameters.AddWithValue("@value1", gameName.Text);
            cmd.Parameters.AddWithValue("@value2", gameCategory.Text);
            cmd.Parameters.AddWithValue("@value3", gamePictureName.Text + ".jpg");
            cmd.Parameters.AddWithValue("@value4", gamePrice.Text);

            int i = cmd.ExecuteNonQuery();
            if (i == 0)
            {
                MessageBox.Show("Game is not insterted.");
            }
            else
            {
               
                MessageBox.Show("Game is inserted");
            }

            mySqlconnection.Close();


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

        private void addGame_Load(object sender, EventArgs e)
        {

        }
    }


}
