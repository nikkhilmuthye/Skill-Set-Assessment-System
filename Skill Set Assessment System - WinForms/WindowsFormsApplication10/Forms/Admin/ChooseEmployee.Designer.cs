namespace WindowsFormsApplication10
{
    partial class ChooseEmployee
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
            this.employeeIDCombo = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.examIDLabel = new System.Windows.Forms.Label();
            this.selectResultLabel = new System.Windows.Forms.Label();
            this.employeeResultLabel = new System.Windows.Forms.GroupBox();
            this.employeeResultLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeIDCombo
            // 
            this.employeeIDCombo.FormattingEnabled = true;
            this.employeeIDCombo.Location = new System.Drawing.Point(253, 127);
            this.employeeIDCombo.Name = "employeeIDCombo";
            this.employeeIDCombo.Size = new System.Drawing.Size(121, 21);
            this.employeeIDCombo.TabIndex = 51;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(69, 237);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 50;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(283, 237);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(70, 30);
            this.check.TabIndex = 49;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(43, 127);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(96, 17);
            this.examIDLabel.TabIndex = 48;
            this.examIDLabel.Text = "Employee ID";
            // 
            // selectResultLabel
            // 
            this.selectResultLabel.AutoSize = true;
            this.selectResultLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectResultLabel.ForeColor = System.Drawing.Color.White;
            this.selectResultLabel.Location = new System.Drawing.Point(157, 0);
            this.selectResultLabel.Name = "selectResultLabel";
            this.selectResultLabel.Size = new System.Drawing.Size(124, 24);
            this.selectResultLabel.TabIndex = 47;
            this.selectResultLabel.Text = "Select Result";
            // 
            // employeeResultLabel
            // 
            this.employeeResultLabel.Controls.Add(this.selectResultLabel);
            this.employeeResultLabel.Controls.Add(this.employeeIDCombo);
            this.employeeResultLabel.Controls.Add(this.examIDLabel);
            this.employeeResultLabel.Controls.Add(this.back);
            this.employeeResultLabel.Controls.Add(this.check);
            this.employeeResultLabel.Location = new System.Drawing.Point(91, 99);
            this.employeeResultLabel.Name = "employeeResultLabel";
            this.employeeResultLabel.Size = new System.Drawing.Size(433, 284);
            this.employeeResultLabel.TabIndex = 52;
            this.employeeResultLabel.TabStop = false;
            // 
            // ChooseEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.employeeResultLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseEmployee";
            this.Text = "ChooseEmployee";
            this.Load += new System.EventHandler(this.ChooseEmployee_Load);
            this.employeeResultLabel.ResumeLayout(false);
            this.employeeResultLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox employeeIDCombo;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.Label selectResultLabel;
        private System.Windows.Forms.GroupBox employeeResultLabel;
    }
}