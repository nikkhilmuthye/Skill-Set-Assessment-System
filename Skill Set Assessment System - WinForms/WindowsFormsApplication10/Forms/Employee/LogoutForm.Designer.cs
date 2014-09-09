namespace WindowsFormsApplication10
{
    partial class LogoutForm
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
            this.thankYouLabel = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.examIDLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thankYouLabel
            // 
            this.thankYouLabel.AutoSize = true;
            this.thankYouLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thankYouLabel.ForeColor = System.Drawing.Color.White;
            this.thankYouLabel.Location = new System.Drawing.Point(748, 392);
            this.thankYouLabel.Name = "thankYouLabel";
            this.thankYouLabel.Size = new System.Drawing.Size(88, 17);
            this.thankYouLabel.TabIndex = 0;
            this.thankYouLabel.Text = "Thank You.";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(763, 453);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(70, 30);
            this.logout.TabIndex = 1;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(260, 149);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(74, 17);
            this.examIDLabel.TabIndex = 2;
            this.examIDLabel.Text = "Exam ID:";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.ForeColor = System.Drawing.Color.White;
            this.employeeNameLabel.Location = new System.Drawing.Point(260, 115);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(119, 17);
            this.employeeNameLabel.TabIndex = 3;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // LogoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1570, 664);
            this.ControlBox = false;
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.examIDLabel);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.thankYouLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LogoutForm";
            this.Text = "Skill Set Assessment System";
            this.Load += new System.EventHandler(this.LogoutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thankYouLabel;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.Label employeeNameLabel;
    }
}