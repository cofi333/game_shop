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
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.refreshView = new System.Windows.Forms.Button();
            this.game_list = new System.Windows.Forms.ListView();
            this.gsap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteGameForm = new System.Windows.Forms.Button();
            this.creatAdmin_account = new System.Windows.Forms.Button();
            this.updateGameForm = new System.Windows.Forms.Button();
            this.addGameForm = new System.Windows.Forms.Button();
            this.panelFormControl = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aboutMessage = new System.Windows.Forms.Button();
            this.sign_out = new System.Windows.Forms.Button();
            this.goTo_website = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.gsap.Location = new System.Drawing.Point(370, 14);
            this.gsap.Margin = new System.Windows.Forms.Padding(5);
            this.gsap.Name = "gsap";
            this.gsap.Size = new System.Drawing.Size(461, 54);
            this.gsap.TabIndex = 4;
            this.gsap.Text = "Game Shop Admin Panel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteGameForm);
            this.groupBox1.Controls.Add(this.creatAdmin_account);
            this.groupBox1.Controls.Add(this.updateGameForm);
            this.groupBox1.Controls.Add(this.addGameForm);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 362);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // deleteGameForm
            // 
            this.deleteGameForm.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.deleteGameForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteGameForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGameForm.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteGameForm.ForeColor = System.Drawing.Color.White;
            this.deleteGameForm.Location = new System.Drawing.Point(6, 204);
            this.deleteGameForm.Name = "deleteGameForm";
            this.deleteGameForm.Size = new System.Drawing.Size(286, 63);
            this.deleteGameForm.TabIndex = 2;
            this.deleteGameForm.Text = "Delete Game";
            this.deleteGameForm.UseVisualStyleBackColor = false;
            this.deleteGameForm.Click += new System.EventHandler(this.deleteGameForm_Click);
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
            this.creatAdmin_account.Location = new System.Drawing.Point(6, 273);
            this.creatAdmin_account.Name = "creatAdmin_account";
            this.creatAdmin_account.Size = new System.Drawing.Size(286, 63);
            this.creatAdmin_account.TabIndex = 4;
            this.creatAdmin_account.Text = "Create Admin Account";
            this.creatAdmin_account.UseVisualStyleBackColor = false;
            this.creatAdmin_account.Click += new System.EventHandler(this.creatAdmin_account_Click);
            // 
            // updateGameForm
            // 
            this.updateGameForm.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.updateGameForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateGameForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateGameForm.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateGameForm.ForeColor = System.Drawing.Color.White;
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
            this.addGameForm.Location = new System.Drawing.Point(6, 66);
            this.addGameForm.Name = "addGameForm";
            this.addGameForm.Size = new System.Drawing.Size(286, 63);
            this.addGameForm.TabIndex = 0;
            this.addGameForm.Text = "Add Game";
            this.addGameForm.UseVisualStyleBackColor = false;
            this.addGameForm.Click += new System.EventHandler(this.addGameForm_Click);
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
            this.groupBox2.Controls.Add(this.sign_out);
            this.groupBox2.Controls.Add(this.goTo_website);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 318);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "More";
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
            this.aboutMessage.Location = new System.Drawing.Point(6, 149);
            this.aboutMessage.Name = "aboutMessage";
            this.aboutMessage.Size = new System.Drawing.Size(286, 63);
            this.aboutMessage.TabIndex = 6;
            this.aboutMessage.Text = "About";
            this.aboutMessage.UseVisualStyleBackColor = false;
            this.aboutMessage.Click += new System.EventHandler(this.aboutMessage_Click);
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
            this.sign_out.Location = new System.Drawing.Point(6, 218);
            this.sign_out.Name = "sign_out";
            this.sign_out.Size = new System.Drawing.Size(286, 63);
            this.sign_out.TabIndex = 5;
            this.sign_out.Text = "Sign Out";
            this.sign_out.UseVisualStyleBackColor = false;
            this.sign_out.Click += new System.EventHandler(this.sign_out_Click);
            // 
            // goTo_website
            // 
            this.goTo_website.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.goTo_website.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goTo_website.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goTo_website.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goTo_website.ForeColor = System.Drawing.Color.White;
            this.goTo_website.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.web;
            this.goTo_website.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goTo_website.Location = new System.Drawing.Point(6, 80);
            this.goTo_website.Name = "goTo_website";
            this.goTo_website.Size = new System.Drawing.Size(286, 63);
            this.goTo_website.TabIndex = 3;
            this.goTo_website.Text = "Go to website";
            this.goTo_website.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 781);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelFormControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gsap);
            this.Controls.Add(this.game_list);
            this.Controls.Add(this.refreshView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSAP";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button refreshView;
        private ListView game_list;
        private Button goTo_website;
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
    }
}