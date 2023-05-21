namespace softersko_inzenjerstvo_projekat
{
    partial class createAdminAccount
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
            this.adminUsername = new System.Windows.Forms.TextBox();
            this.adminPassword = new System.Windows.Forms.TextBox();
            this.adminConfirmPassword = new System.Windows.Forms.TextBox();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.checkBtn_show_password = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(73, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(73, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(73, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm password:";
            // 
            // adminUsername
            // 
            this.adminUsername.BackColor = System.Drawing.SystemColors.Control;
            this.adminUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminUsername.Location = new System.Drawing.Point(281, 33);
            this.adminUsername.Name = "adminUsername";
            this.adminUsername.Size = new System.Drawing.Size(547, 29);
            this.adminUsername.TabIndex = 3;
            // 
            // adminPassword
            // 
            this.adminPassword.BackColor = System.Drawing.SystemColors.Control;
            this.adminPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminPassword.Location = new System.Drawing.Point(281, 81);
            this.adminPassword.Name = "adminPassword";
            this.adminPassword.PasswordChar = '●';
            this.adminPassword.Size = new System.Drawing.Size(547, 29);
            this.adminPassword.TabIndex = 4;
            // 
            // adminConfirmPassword
            // 
            this.adminConfirmPassword.BackColor = System.Drawing.SystemColors.Control;
            this.adminConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminConfirmPassword.Location = new System.Drawing.Point(281, 129);
            this.adminConfirmPassword.Name = "adminConfirmPassword";
            this.adminConfirmPassword.PasswordChar = '●';
            this.adminConfirmPassword.Size = new System.Drawing.Size(547, 29);
            this.adminConfirmPassword.TabIndex = 5;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.createAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAccountBtn.ForeColor = System.Drawing.Color.Transparent;
            this.createAccountBtn.Image = global::softersko_inzenjerstvo_projekat.Properties.Resources.add;
            this.createAccountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createAccountBtn.Location = new System.Drawing.Point(12, 237);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(816, 61);
            this.createAccountBtn.TabIndex = 6;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = false;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // checkBtn_show_password
            // 
            this.checkBtn_show_password.AutoSize = true;
            this.checkBtn_show_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBtn_show_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBtn_show_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBtn_show_password.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.checkBtn_show_password.Location = new System.Drawing.Point(689, 164);
            this.checkBtn_show_password.Name = "checkBtn_show_password";
            this.checkBtn_show_password.Size = new System.Drawing.Size(136, 25);
            this.checkBtn_show_password.TabIndex = 11;
            this.checkBtn_show_password.Text = "Show password";
            this.checkBtn_show_password.UseVisualStyleBackColor = true;
            this.checkBtn_show_password.CheckedChanged += new System.EventHandler(this.checkBtn_show_password_CheckedChanged);
            // 
            // createAdminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 310);
            this.Controls.Add(this.checkBtn_show_password);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.adminConfirmPassword);
            this.Controls.Add(this.adminPassword);
            this.Controls.Add(this.adminUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "createAdminAccount";
            this.Text = "createAdminAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox adminUsername;
        private TextBox adminPassword;
        private TextBox adminConfirmPassword;
        private Button createAccountBtn;
        private CheckBox checkBtn_show_password;
    }
}