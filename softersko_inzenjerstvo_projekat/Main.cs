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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void add_game_Click(object sender, EventArgs e)
        {

        }

        private void update_game_Click(object sender, EventArgs e)
        {

        }

        private void delete_game_Click(object sender, EventArgs e)
        {
            string con = "server=localhost;user=root;database=game_shop;password=";
            MySqlConnection mySqlconnection = new MySqlConnection(con);
            mySqlconnection.Open();
            string id = gameID.Text.Trim();
            string delete = "DELETE FROM games WHERE game_id = " + id;
            MySqlCommand cmd = new MySqlCommand(delete, mySqlconnection);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("Game deleted");
            game_list.Clear();
            loadData();
            Console.WriteLine("hi");
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void show_games_Click(object sender, EventArgs e)
        {
            game_list.Clear();
            loadData();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadData();
        }



        public void loadData()
        {
            string con = "server=localhost;user=root;database=game_shop;password=";
            MySqlConnection mySqlconnection = new MySqlConnection(con);
            DataTable dt;
            MySqlDataAdapter da;
            MySqlCommand cmd;

            game_list.Columns.Add("Id", 120);
            game_list.Columns.Add("Name", 120);
            game_list.Columns.Add("Category", 120);
            game_list.Columns.Add("Picture", 120);
            game_list.Columns.Add("Price", 120);
            game_list.View = View.Details;

            cmd = new MySqlCommand();
            cmd.Connection = mySqlconnection;
            cmd.CommandText = "SELECT * FROM games";

            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["game_id"].ToString());
                listitem.SubItems.Add(dr["game_name"].ToString());
                listitem.SubItems.Add(dr["game_category"].ToString());
                listitem.SubItems.Add(dr["game_picture"].ToString());
                listitem.SubItems.Add(dr["game_price"].ToString());
                game_list.Items.Add(listitem);



            }
        }
    }
}
