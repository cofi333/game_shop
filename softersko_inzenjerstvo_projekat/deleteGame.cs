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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace softersko_inzenjerstvo_projekat
{
    public partial class deleteGame : Form
    {
        public deleteGame()
        {
            InitializeComponent();
        }

        private void deleteGame_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM `games`";
            loadCombo(sql, "game_name", "game_id");
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string con = "server=localhost;user=root;database=game_shop;password=";
            MySqlConnection mySqlconnection = new MySqlConnection(con);
            mySqlconnection.Open();
            string game = this.gameList.GetItemText(this.gameList.SelectedItem);
            
           

            DialogResult Message;
            Message = MessageBox.Show("Are you sure you want to delete this game?", "Game delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Message == DialogResult.No)
            {
                return;
            }
            else
            {
                string delete = "DELETE FROM games WHERE game_name = " + "\"" + game + "\"";
                MySqlCommand cmd = new MySqlCommand(delete, mySqlconnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Game deleted");
            }


            string sql = "SELECT * FROM `games`";
            loadCombo(sql, "game_name", "game_id");
        }

        private void gameList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
