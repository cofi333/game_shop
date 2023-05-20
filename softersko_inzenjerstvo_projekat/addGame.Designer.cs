namespace softersko_inzenjerstvo_projekat
{
    partial class addGame
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gameID = new System.Windows.Forms.TextBox();
            this.gameName = new System.Windows.Forms.TextBox();
            this.gameCategory = new System.Windows.Forms.TextBox();
            this.gamePictureUrl = new System.Windows.Forms.TextBox();
            this.gamePictureName = new System.Windows.Forms.TextBox();
            this.gamePrice = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Game name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Game category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Game picture URL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Game picture name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Game price:";
            // 
            // gameID
            // 
            this.gameID.Location = new System.Drawing.Point(128, 28);
            this.gameID.Name = "gameID";
            this.gameID.Size = new System.Drawing.Size(666, 23);
            this.gameID.TabIndex = 6;
            // 
            // gameName
            // 
            this.gameName.Location = new System.Drawing.Point(133, 70);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(666, 23);
            this.gameName.TabIndex = 7;
            // 
            // gameCategory
            // 
            this.gameCategory.Location = new System.Drawing.Point(149, 106);
            this.gameCategory.Name = "gameCategory";
            this.gameCategory.Size = new System.Drawing.Size(666, 23);
            this.gameCategory.TabIndex = 8;
            // 
            // gamePictureUrl
            // 
            this.gamePictureUrl.Location = new System.Drawing.Point(164, 143);
            this.gamePictureUrl.Name = "gamePictureUrl";
            this.gamePictureUrl.Size = new System.Drawing.Size(666, 23);
            this.gamePictureUrl.TabIndex = 9;
            // 
            // gamePictureName
            // 
            this.gamePictureName.Location = new System.Drawing.Point(173, 181);
            this.gamePictureName.Name = "gamePictureName";
            this.gamePictureName.Size = new System.Drawing.Size(666, 23);
            this.gamePictureName.TabIndex = 10;
            // 
            // gamePrice
            // 
            this.gamePrice.Location = new System.Drawing.Point(133, 216);
            this.gamePrice.Name = "gamePrice";
            this.gamePrice.Size = new System.Drawing.Size(666, 23);
            this.gamePrice.TabIndex = 11;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(309, 273);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add Game";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 310);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.gamePrice);
            this.Controls.Add(this.gamePictureName);
            this.Controls.Add(this.gamePictureUrl);
            this.Controls.Add(this.gameCategory);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.gameID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox gameID;
        private TextBox gameName;
        private TextBox gameCategory;
        private TextBox gamePictureUrl;
        private TextBox gamePictureName;
        private TextBox gamePrice;
        private Button addBtn;
    }
}