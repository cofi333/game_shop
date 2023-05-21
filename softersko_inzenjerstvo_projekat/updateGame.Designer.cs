namespace softersko_inzenjerstvo_projekat
{
    partial class updateGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gameName = new System.Windows.Forms.TextBox();
            this.gameCategory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gamePictureUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gamePictureName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gamePrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(284, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select game from dropdown list:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select game from dropdown list:";
            // 
            // gameList
            // 
            this.gameList.AccessibleDescription = "";
            this.gameList.AccessibleName = "";
            this.gameList.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gameList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameList.ForeColor = System.Drawing.Color.White;
            this.gameList.FormattingEnabled = true;
            this.gameList.Location = new System.Drawing.Point(224, 12);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(604, 29);
            this.gameList.TabIndex = 4;
            this.gameList.SelectedIndexChanged += new System.EventHandler(this.gameList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Game name:";
            // 
            // gameName
            // 
            this.gameName.BackColor = System.Drawing.SystemColors.Control;
            this.gameName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gameName.Location = new System.Drawing.Point(224, 59);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(604, 29);
            this.gameName.TabIndex = 8;
            this.gameName.TextChanged += new System.EventHandler(this.gameName_TextChanged);
            // 
            // gameCategory
            // 
            this.gameCategory.BackColor = System.Drawing.SystemColors.Control;
            this.gameCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameCategory.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gameCategory.Location = new System.Drawing.Point(224, 94);
            this.gameCategory.Name = "gameCategory";
            this.gameCategory.Size = new System.Drawing.Size(604, 29);
            this.gameCategory.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Game category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Game picture URL:";
            // 
            // gamePictureUrl
            // 
            this.gamePictureUrl.BackColor = System.Drawing.SystemColors.Control;
            this.gamePictureUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gamePictureUrl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gamePictureUrl.Location = new System.Drawing.Point(224, 129);
            this.gamePictureUrl.Name = "gamePictureUrl";
            this.gamePictureUrl.Size = new System.Drawing.Size(604, 29);
            this.gamePictureUrl.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Game picture name:";
            // 
            // gamePictureName
            // 
            this.gamePictureName.BackColor = System.Drawing.SystemColors.Control;
            this.gamePictureName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gamePictureName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gamePictureName.Location = new System.Drawing.Point(224, 164);
            this.gamePictureName.Name = "gamePictureName";
            this.gamePictureName.Size = new System.Drawing.Size(604, 29);
            this.gamePictureName.TabIndex = 14;
            this.gamePictureName.TextChanged += new System.EventHandler(this.gamePictureName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(12, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Game price:";
            // 
            // gamePrice
            // 
            this.gamePrice.BackColor = System.Drawing.SystemColors.Control;
            this.gamePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gamePrice.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gamePrice.Location = new System.Drawing.Point(224, 199);
            this.gamePrice.Name = "gamePrice";
            this.gamePrice.Size = new System.Drawing.Size(604, 29);
            this.gamePrice.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.update;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(816, 53);
            this.button1.TabIndex = 17;
            this.button1.Text = "Update Game";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // updateGame
            // 
            this.ClientSize = new System.Drawing.Size(840, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gamePrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gamePictureName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gamePictureUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gameCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gameList);
            this.Controls.Add(this.label2);
            this.Name = "updateGame";
            this.Load += new System.EventHandler(this.updateGame_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox gameList;
        private Label label3;
        private TextBox gameName;
        private TextBox gameCategory;
        private Label label4;
        private Label label5;
        private TextBox gamePictureUrl;
        private Label label6;
        private TextBox gamePictureName;
        private Label label7;
        private TextBox gamePrice;
        private Button button1;
    }
}