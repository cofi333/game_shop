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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.refreshView = new System.Windows.Forms.Button();
            this.game_list = new System.Windows.Forms.ListView();
            this.gsap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteGameForm = new System.Windows.Forms.Button();
            this.updateGameForm = new System.Windows.Forms.Button();
            this.addGameForm = new System.Windows.Forms.Button();
            this.creatAdmin_account = new System.Windows.Forms.Button();
            this.panelFormControl = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aboutMessage = new System.Windows.Forms.Button();
            this.endCurrent_session = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.sign_out = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.GroupBox();
            this.steamgridDB = new System.Windows.Forms.Button();
            this.open_mysql = new System.Windows.Forms.Button();
            this.open_website = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.s.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // refreshView
            // 
            this.refreshView.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.refreshView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshView.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshView.ForeColor = System.Drawing.Color.White;
            this.refreshView.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.reload;
            this.refreshView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshView.Location = new System.Drawing.Point(316, 711);
            this.refreshView.Name = "refreshView";
            this.refreshView.Size = new System.Drawing.Size(856, 58);
            this.refreshView.TabIndex = 1;
            this.refreshView.Text = "Refresh View";
            this.refreshView.UseVisualStyleBackColor = false;
            this.refreshView.Click += new System.EventHandler(this.refreshView_Click);
            // 
            // game_list
            // 
            this.game_list.Location = new System.Drawing.Point(316, 467);
            this.game_list.Name = "game_list";
            this.game_list.Size = new System.Drawing.Size(856, 238);
            this.game_list.TabIndex = 2;
            this.game_list.UseCompatibleStateImageBehavior = false;
            // 
            // gsap
            // 
            this.gsap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gsap.AutoSize = true;
            this.gsap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gsap.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gsap.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gsap.Location = new System.Drawing.Point(537, 14);
            this.gsap.Margin = new System.Windows.Forms.Padding(5);
            this.gsap.Name = "gsap";
            this.gsap.Size = new System.Drawing.Size(461, 54);
            this.gsap.TabIndex = 4;
            this.gsap.Text = "Game Shop Admin Panel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteGameForm);
            this.groupBox1.Controls.Add(this.updateGameForm);
            this.groupBox1.Controls.Add(this.addGameForm);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 307);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GameDB";
            // 
            // deleteGameForm
            // 
            this.deleteGameForm.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.deleteGameForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteGameForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGameForm.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteGameForm.ForeColor = System.Drawing.Color.White;
            this.deleteGameForm.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.delete;
            this.deleteGameForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteGameForm.Location = new System.Drawing.Point(6, 204);
            this.deleteGameForm.Name = "deleteGameForm";
            this.deleteGameForm.Size = new System.Drawing.Size(286, 63);
            this.deleteGameForm.TabIndex = 2;
            this.deleteGameForm.Text = "Delete Game";
            this.deleteGameForm.UseVisualStyleBackColor = false;
            this.deleteGameForm.Click += new System.EventHandler(this.deleteGameForm_Click);
            // 
            // updateGameForm
            // 
            this.updateGameForm.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.updateGameForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateGameForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateGameForm.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateGameForm.ForeColor = System.Drawing.Color.White;
            this.updateGameForm.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.update;
            this.updateGameForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateGameForm.Location = new System.Drawing.Point(6, 135);
            this.updateGameForm.Name = "updateGameForm";
            this.updateGameForm.Size = new System.Drawing.Size(286, 63);
            this.updateGameForm.TabIndex = 1;
            this.updateGameForm.Text = "Update Game";
            this.updateGameForm.UseVisualStyleBackColor = false;
            this.updateGameForm.Click += new System.EventHandler(this.updateGameForm_Click);
            // 
            // addGameForm
            // 
            this.addGameForm.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.addGameForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addGameForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGameForm.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addGameForm.ForeColor = System.Drawing.Color.White;
            this.addGameForm.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.above;
            this.addGameForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addGameForm.Location = new System.Drawing.Point(6, 66);
            this.addGameForm.Name = "addGameForm";
            this.addGameForm.Size = new System.Drawing.Size(286, 63);
            this.addGameForm.TabIndex = 0;
            this.addGameForm.Text = "Add Game";
            this.addGameForm.UseVisualStyleBackColor = false;
            this.addGameForm.Click += new System.EventHandler(this.addGameForm_Click);
            // 
            // creatAdmin_account
            // 
            this.creatAdmin_account.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.creatAdmin_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creatAdmin_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creatAdmin_account.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creatAdmin_account.ForeColor = System.Drawing.Color.White;
            this.creatAdmin_account.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.user;
            this.creatAdmin_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.creatAdmin_account.Location = new System.Drawing.Point(6, 93);
            this.creatAdmin_account.Name = "creatAdmin_account";
            this.creatAdmin_account.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.creatAdmin_account.Size = new System.Drawing.Size(286, 63);
            this.creatAdmin_account.TabIndex = 4;
            this.creatAdmin_account.Text = "Create Admin Account";
            this.creatAdmin_account.UseVisualStyleBackColor = false;
            this.creatAdmin_account.Click += new System.EventHandler(this.creatAdmin_account_Click);
            // 
            // panelFormControl
            // 
            this.panelFormControl.Location = new System.Drawing.Point(316, 96);
            this.panelFormControl.Name = "panelFormControl";
            this.panelFormControl.Size = new System.Drawing.Size(856, 349);
            this.panelFormControl.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aboutMessage);
            this.groupBox2.Controls.Add(this.endCurrent_session);
            this.groupBox2.Controls.Add(this.exit_btn);
            this.groupBox2.Controls.Add(this.sign_out);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 373);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // aboutMessage
            // 
            this.aboutMessage.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.aboutMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutMessage.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutMessage.ForeColor = System.Drawing.Color.White;
            this.aboutMessage.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.info;
            this.aboutMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutMessage.Location = new System.Drawing.Point(6, 278);
            this.aboutMessage.Name = "aboutMessage";
            this.aboutMessage.Size = new System.Drawing.Size(286, 63);
            this.aboutMessage.TabIndex = 6;
            this.aboutMessage.Text = "About";
            this.aboutMessage.UseVisualStyleBackColor = false;
            this.aboutMessage.Click += new System.EventHandler(this.aboutMessage_Click);
            // 
            // endCurrent_session
            // 
            this.endCurrent_session.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.endCurrent_session.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endCurrent_session.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endCurrent_session.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endCurrent_session.ForeColor = System.Drawing.Color.White;
            this.endCurrent_session.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.power;
            this.endCurrent_session.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.endCurrent_session.Location = new System.Drawing.Point(6, 71);
            this.endCurrent_session.Name = "endCurrent_session";
            this.endCurrent_session.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.endCurrent_session.Size = new System.Drawing.Size(286, 63);
            this.endCurrent_session.TabIndex = 8;
            this.endCurrent_session.Text = "End Current Session";
            this.endCurrent_session.UseVisualStyleBackColor = false;
            this.endCurrent_session.Click += new System.EventHandler(this.endCurrent_session_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.exit;
            this.exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_btn.Location = new System.Drawing.Point(6, 209);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(286, 63);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // sign_out
            // 
            this.sign_out.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.sign_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_out.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sign_out.ForeColor = System.Drawing.Color.White;
            this.sign_out.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.logout;
            this.sign_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sign_out.Location = new System.Drawing.Point(6, 140);
            this.sign_out.Name = "sign_out";
            this.sign_out.Size = new System.Drawing.Size(286, 63);
            this.sign_out.TabIndex = 5;
            this.sign_out.Text = "Sign Out";
            this.sign_out.UseVisualStyleBackColor = false;
            this.sign_out.Click += new System.EventHandler(this.sign_out_Click);
            // 
            // s
            // 
            this.s.Controls.Add(this.steamgridDB);
            this.s.Controls.Add(this.open_mysql);
            this.s.Controls.Add(this.open_website);
            this.s.Controls.Add(this.creatAdmin_account);
            this.s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.s.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.s.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.s.Location = new System.Drawing.Point(1178, 83);
            this.s.Name = "s";
            this.s.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.s.Size = new System.Drawing.Size(298, 686);
            this.s.TabIndex = 8;
            this.s.TabStop = false;
            this.s.Text = "Settings";
            this.s.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // steamgridDB
            // 
            this.steamgridDB.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.steamgridDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.steamgridDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.steamgridDB.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.steamgridDB.ForeColor = System.Drawing.Color.White;
            this.steamgridDB.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.layers;
            this.steamgridDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.steamgridDB.Location = new System.Drawing.Point(6, 617);
            this.steamgridDB.Name = "steamgridDB";
            this.steamgridDB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.steamgridDB.Size = new System.Drawing.Size(286, 63);
            this.steamgridDB.TabIndex = 7;
            this.steamgridDB.Text = "SteamGridDB";
            this.steamgridDB.UseVisualStyleBackColor = false;
            this.steamgridDB.Click += new System.EventHandler(this.steamgridDB_Click);
            // 
            // open_mysql
            // 
            this.open_mysql.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.open_mysql.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_mysql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_mysql.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.open_mysql.ForeColor = System.Drawing.Color.White;
            this.open_mysql.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.mysql;
            this.open_mysql.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.open_mysql.Location = new System.Drawing.Point(6, 231);
            this.open_mysql.Name = "open_mysql";
            this.open_mysql.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.open_mysql.Size = new System.Drawing.Size(286, 63);
            this.open_mysql.TabIndex = 6;
            this.open_mysql.Text = "MySQL";
            this.open_mysql.UseVisualStyleBackColor = false;
            this.open_mysql.Click += new System.EventHandler(this.open_mysql_Click);
            // 
            // open_website
            // 
            this.open_website.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.open_website.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_website.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_website.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.open_website.ForeColor = System.Drawing.Color.White;
            this.open_website.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.web;
            this.open_website.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.open_website.Location = new System.Drawing.Point(6, 162);
            this.open_website.Name = "open_website";
            this.open_website.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.open_website.Size = new System.Drawing.Size(286, 63);
            this.open_website.TabIndex = 5;
            this.open_website.Text = "Open website";
            this.open_website.UseVisualStyleBackColor = false;
            this.open_website.Click += new System.EventHandler(this.open_website_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 781);
            this.Controls.Add(this.s);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelFormControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gsap);
            this.Controls.Add(this.game_list);
            this.Controls.Add(this.refreshView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSAP";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.s.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button refreshView;
        private ListView game_list;
        private Button aboutMessage;
        private PictureBox pictureBox1;
        private Label gsap;
        private GroupBox groupBox1;
        private Button deleteGameForm;
        private Button updateGameForm;
        private Button addGameForm;
        private Panel panelFormControl;
        private GroupBox groupBox2;
        private Button sign_out;
        private Button creatAdmin_account;
        private Button goto_website;
        private Button exit_btn;
        private GroupBox groupBox3;
        private Button open_website;
        private Button button1;
        private Button open_mysql;
        private GroupBox s;
        private Button root_folder;
        private Button button3;
        private Button endCurrent_session;
        private Button steamgridDB;
    }
}