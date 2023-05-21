namespace softersko_inzenjerstvo_projekat
{
    partial class greetingFrom
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
            this.greetingMsg = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // greetingMsg
            // 
            this.greetingMsg.AutoSize = true;
            this.greetingMsg.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.greetingMsg.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.greetingMsg.Location = new System.Drawing.Point(84, 131);
            this.greetingMsg.Name = "greetingMsg";
            this.greetingMsg.Size = new System.Drawing.Size(109, 46);
            this.greetingMsg.TabIndex = 0;
            this.greetingMsg.Text = "label1";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(335, 87);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(65, 28);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "label2";
            // 
            // greetingFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 310);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.greetingMsg);
            this.Name = "greetingFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "c";
            this.Load += new System.EventHandler(this.greetingFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label dateLabel;
        private Label greetingMsg;
    }
}