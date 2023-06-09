﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// TODO - change goto_webiste button to linkLabel (style it, give it link and add it to groupBox)

namespace softersko_inzenjerstvo_projekat
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadData();
            defaultSession();
        }

        public void defaultSession()
        {
            greetingFrom gF = new greetingFrom() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            gF.FormBorderStyle = FormBorderStyle.None;
            this.panelFormControl.Controls.Add(gF);
            gF.Show();
        }

        public void loadData()
        {
            string con = "server=localhost;user=root;database=game_shop;password=";
            MySqlConnection mySqlconnection = new MySqlConnection(con);
            DataTable dt;
            MySqlDataAdapter da;
            MySqlCommand cmd;

            game_list.Columns.Add("Id", 120);
            game_list.Columns.Add("Name", 180);
            game_list.Columns.Add("Category", 200);
            game_list.Columns.Add("Picture", 180);
            game_list.Columns.Add("Price", 60);
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

        private void refreshView_Click(object sender, EventArgs e)
        {
            game_list.Clear();
            loadData();
        }

        private void aboutMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Shop Admin Panel\n\nFilip Kujundžić\nStefan Buljić\n\nC# - MySql - PHP - CSS\n\nSoftversko Inženjerstvo\nVTŠ Subotica, Maj 2023", "About project", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void sign_out_Click(object sender, EventArgs e)
        {
            DialogResult Message;
            Message = MessageBox.Show("You are about to sing out.\nAre you sure?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Message == DialogResult.No)
            {
                return;
            }
            else
            {
                new Login().Show();
                this.Hide();
            }
        }

        private void addGameForm_Click(object sender, EventArgs e)
        {
            addGame aG = new addGame()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            aG.FormBorderStyle = FormBorderStyle.None;
            panelFormControl.Controls.Clear();
            this.panelFormControl.Controls.Add(aG);
            aG.Show();
        }

        private void updateGameForm_Click(object sender, EventArgs e)
        {
            updateGame uG = new updateGame()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            uG.FormBorderStyle = FormBorderStyle.None;
            panelFormControl.Controls.Clear();
            this.panelFormControl.Controls.Add(uG);
            uG.Show();
        }

        private void deleteGameForm_Click(object sender, EventArgs e)
        {
            deleteGame dG = new deleteGame()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            dG.FormBorderStyle = FormBorderStyle.None;
            panelFormControl.Controls.Clear();
            this.panelFormControl.Controls.Add(dG);
            dG.Show();
            
        }

        private void creatAdmin_account_Click(object sender, EventArgs e)
        {
            createAdminAccount cAA = new createAdminAccount()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            cAA.FormBorderStyle = FormBorderStyle.None;
            panelFormControl.Controls.Clear();
            this.panelFormControl.Controls.Add(cAA);
            cAA.Show();

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult Message;
            Message = MessageBox.Show("Are you sure you want to exit panel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Message == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void open_website_Click(object sender, EventArgs e)
        {
            string path = "http://localhost/game_shop/web";
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = path,
                //WorkingDirectory = @"C:\xampp\htdocs\index.php",
                UseShellExecute = true
            };

            try
            {
                System.Diagnostics.Process.Start(startInfo);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                // Handle any exceptions or display an error message
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void open_mysql_Click(object sender, EventArgs e)
        {
            string path = "http://localhost/phpmyadmin";
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = path,
                //WorkingDirectory = @"C:\xampp\htdocs\index.php",
                UseShellExecute = true
            };

            try
            {
                System.Diagnostics.Process.Start(startInfo);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                // Handle any exceptions or display an error message
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void endCurrent_session_Click(object sender, EventArgs e)
        {
            DialogResult Message;
            Message = MessageBox.Show("You will discard your previous work!\nAre you sure you want to close this session?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Message == DialogResult.No)
            {
                return;
            }
            else
            {
                panelFormControl.Controls.Clear();
                defaultSession();
            }
        }

        private void steamgridDB_Click(object sender, EventArgs e)
        {
            string path = "https://www.steamgriddb.com/";
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = path,
                //WorkingDirectory = @"C:\xampp\htdocs\index.php",
                UseShellExecute = true
            };

            try
            {
                System.Diagnostics.Process.Start(startInfo);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                // Handle any exceptions or display an error message
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
 }
