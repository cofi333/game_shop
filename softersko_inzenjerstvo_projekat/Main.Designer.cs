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
            this.SuspendLayout();
            // 
            // update_game
            // 
            this.update_game.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.update_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_game.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.update_game.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_game.Location = new System.Drawing.Point(359, 458);
            this.update_game.Name = "update_game";
            this.update_game.Size = new System.Drawing.Size(235, 61);
            this.update_game.TabIndex = 1;
            this.update_game.Text = "Update";
            this.update_game.UseVisualStyleBackColor = false;
            this.update_game.Click += new System.EventHandler(this.update_game_Click);
            // 
            // delete_game
            // 
            this.delete_game.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.delete_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_game.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete_game.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_game.Location = new System.Drawing.Point(699, 458);
            this.delete_game.Name = "delete_game";
            this.delete_game.Size = new System.Drawing.Size(235, 61);
            this.delete_game.TabIndex = 2;
            this.delete_game.Text = "Delete Game";
            this.delete_game.UseVisualStyleBackColor = false;
            this.delete_game.Click += new System.EventHandler(this.delete_game_Click);
            // 
            // add_game
            // 
            this.add_game.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.add_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_game.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_game.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_game.Location = new System.Drawing.Point(12, 458);
            this.add_game.Name = "add_game";
            this.add_game.Size = new System.Drawing.Size(235, 61);
            this.add_game.TabIndex = 3;
            this.add_game.Text = "Add Game";
            this.add_game.UseVisualStyleBackColor = false;
            this.add_game.Click += new System.EventHandler(this.add_game_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 531);
            this.Controls.Add(this.add_game);
            this.Controls.Add(this.delete_game);
            this.Controls.Add(this.update_game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private Button update_game;
        private Button delete_game;
        private Button add_game;
    }
}