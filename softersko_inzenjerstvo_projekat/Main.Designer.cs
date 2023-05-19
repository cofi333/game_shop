namespace softersko_inzenjerstvo_projekat
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.update_game = new System.Windows.Forms.Button();
            this.delete_game = new System.Windows.Forms.Button();
            this.add_game = new System.Windows.Forms.Button();
            this.game_list = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gameID = new System.Windows.Forms.TextBox();
            this.gameName = new System.Windows.Forms.TextBox();
            this.gameCategory = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.show_games = new System.Windows.Forms.Button();
            this.sgr = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.SuspendLayout();
            // 
            // update_game
            // 
            this.update_game.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.update_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.update_game.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_game.Location = new System.Drawing.Point(12, 391);
            this.update_game.Name = "update_game";
            this.update_game.Size = new System.Drawing.Size(314, 61);
            this.update_game.TabIndex = 1;
            this.update_game.Text = "Update";
            this.update_game.UseVisualStyleBackColor = false;
            this.update_game.Click += new System.EventHandler(this.update_game_Click);
            // 
            // delete_game
            // 
            this.delete_game.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.delete_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete_game.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_game.Location = new System.Drawing.Point(12, 458);
            this.delete_game.Name = "delete_game";
            this.delete_game.Size = new System.Drawing.Size(314, 61);
            this.delete_game.TabIndex = 2;
            this.delete_game.Text = "Delete Game";
            this.delete_game.UseVisualStyleBackColor = false;
            this.delete_game.Click += new System.EventHandler(this.delete_game_Click);
            // 
            // add_game
            // 
            this.add_game.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.add_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_game.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_game.Location = new System.Drawing.Point(12, 324);
            this.add_game.Name = "add_game";
            this.add_game.Size = new System.Drawing.Size(314, 61);
            this.add_game.TabIndex = 3;
            this.add_game.Text = "Add Game";
            this.add_game.UseVisualStyleBackColor = false;
            this.add_game.Click += new System.EventHandler(this.add_game_Click);
            // 
            // game_list
            // 
            this.game_list.Location = new System.Drawing.Point(332, 324);
            this.game_list.Name = "game_list";
            this.game_list.Size = new System.Drawing.Size(602, 128);
            this.game_list.TabIndex = 4;
            this.game_list.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Game ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Game Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Game Category:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Game Picture URL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Game Picture Name:";
            // 
            // gameID
            // 
            this.gameID.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gameID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gameID.ForeColor = System.Drawing.Color.White;
            this.gameID.Location = new System.Drawing.Point(181, 74);
            this.gameID.Name = "gameID";
            this.gameID.Size = new System.Drawing.Size(753, 23);
            this.gameID.TabIndex = 10;
            // 
            // gameName
            // 
            this.gameName.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gameName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gameName.ForeColor = System.Drawing.Color.White;
            this.gameName.Location = new System.Drawing.Point(181, 117);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(753, 23);
            this.gameName.TabIndex = 11;
            // 
            // gameCategory
            // 
            this.gameCategory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gameCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gameCategory.ForeColor = System.Drawing.Color.White;
            this.gameCategory.Location = new System.Drawing.Point(181, 157);
            this.gameCategory.Name = "gameCategory";
            this.gameCategory.Size = new System.Drawing.Size(753, 23);
            this.gameCategory.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(181, 201);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(753, 23);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(181, 244);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(753, 23);
            this.textBox5.TabIndex = 14;
            // 
            // show_games
            // 
            this.show_games.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.show_games.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_games.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.show_games.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.show_games.Location = new System.Drawing.Point(332, 458);
            this.show_games.Name = "show_games";
            this.show_games.Size = new System.Drawing.Size(602, 61);
            this.show_games.TabIndex = 15;
            this.show_games.Text = "Show";
            this.show_games.UseVisualStyleBackColor = false;
            this.show_games.Click += new System.EventHandler(this.show_games_Click);
            // 
            // sgr
            // 
            this.sgr.AutoSize = true;
            this.sgr.BackColor = System.Drawing.Color.Transparent;
            this.sgr.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sgr.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.sgr.Location = new System.Drawing.Point(290, 9);
            this.sgr.Name = "sgr";
            this.sgr.Size = new System.Drawing.Size(413, 48);
            this.sgr.TabIndex = 16;
            this.sgr.Text = "Game Shop Admin Panel";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 531);
            this.Controls.Add(this.sgr);
            this.Controls.Add(this.show_games);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.gameCategory);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.gameID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.game_list);
            this.Controls.Add(this.add_game);
            this.Controls.Add(this.delete_game);
            this.Controls.Add(this.update_game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button update_game;
        private Button delete_game;
        private Button add_game;
        private ListView game_list;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox gameID;
        private TextBox gameName;
        private TextBox gameCategory;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button show_games;
        private Label sgr;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}