namespace softersko_inzenjerstvo_projekat
{
    partial class deleteGame
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.gameList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Location = new System.Drawing.Point(12, 246);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(816, 52);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete Game";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // gameList
            // 
            this.gameList.AccessibleDescription = "";
            this.gameList.AccessibleName = "";
            this.gameList.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gameList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameList.ForeColor = System.Drawing.Color.White;
            this.gameList.FormattingEnabled = true;
            this.gameList.Location = new System.Drawing.Point(180, 37);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(468, 25);
            this.gameList.TabIndex = 0;
            this.gameList.SelectedIndexChanged += new System.EventHandler(this.gameList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select game from dropdown list:";
            // 
            // deleteGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.gameList);
            this.Name = "deleteGame";
            this.Text = "deleteGame";
            this.Load += new System.EventHandler(this.deleteGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button deleteBtn;
        private ComboBox gameList;
        private Label label1;
    }
}