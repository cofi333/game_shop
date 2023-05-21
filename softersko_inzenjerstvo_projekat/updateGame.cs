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

      

        private void gamePictureName_TextChanged(object sender, EventArgs e)
        {

        }

        private void gameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void gameName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
