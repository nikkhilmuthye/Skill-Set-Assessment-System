namespace WindowsFormsApplication10
{
    partial class AddApplicant
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
            this.add = new System.Windows.Forms.Button();
            this.examIDLabel = new System.Windows.Forms.Label();
            this.addApplicantLabel = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.examIDCombo = new System.Windows.Forms.ComboBox();
            this.employeeIDCombo = new System.Windows.Forms.ComboBox();
            this.addApplicantLegend = new System.Windows.Forms.GroupBox();
            this.addApplicantLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(343, 328);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(70, 30);
            this.add.TabIndex = 41;
            this.add.Text = "Add ";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(68, 178);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(68, 17);
            this.examIDLabel.TabIndex = 39;
            this.examIDLabel.Text = "Exam ID";
            // 
            // addApplicantLabel
            // 
            this.addApplicantLabel.AutoSize = true;
            this.addApplicantLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addApplicantLabel.ForeColor = System.Drawing.Color.White;
            this.addApplicantLabel.Location = new System.Drawing.Point(144, 0);
            this.addApplicantLabel.Name = "addApplicantLabel";
            this.addApplicantLabel.Size = new System.Drawing.Size(145, 24);
            this.addApplicantLabel.TabIndex = 38;
            this.addApplicantLabel.Text = "Add Applicant";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.ForeColor = System.Drawing.Color.White;
            this.employeeIDLabel.Location = new System.Drawing.Point(68, 134);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(96, 17);
            this.employeeIDLabel.TabIndex = 42;
            this.employeeIDLabel.Text = "Employee ID";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(58, 328);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 44;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // examIDCombo
            // 
            this.examIDCombo.FormattingEnabled = true;
            this.examIDCombo.Location = new System.Drawing.Point(248, 178);
            this.examIDCombo.Name = "examIDCombo";
            this.examIDCombo.Size = new System.Drawing.Size(121, 21);
            this.examIDCombo.TabIndex = 45;
            // 
            // employeeIDCombo
            // 
            this.employeeIDCombo.FormattingEnabled = true;
            this.employeeIDCombo.Location = new System.Drawing.Point(248, 134);
            this.employeeIDCombo.Name = "employeeIDCombo";
            this.employeeIDCombo.Size = new System.Drawing.Size(121, 21);
            this.employeeIDCombo.TabIndex = 46;
            // 
            // addApplicantLegend
            // 
            this.addApplicantLegend.Controls.Add(this.addApplicantLabel);
            this.addApplicantLegend.Controls.Add(this.employeeIDCombo);
            this.addApplicantLegend.Controls.Add(this.examIDLabel);
            this.addApplicantLegend.Controls.Add(this.examIDCombo);
            this.addApplicantLegend.Controls.Add(this.add);
            this.addApplicantLegend.Controls.Add(this.back);
            this.addApplicantLegend.Controls.Add(this.employeeIDLabel);
            this.addApplicantLegend.Location = new System.Drawing.Point(266, 69);
            this.addApplicantLegend.Name = "addApplicantLegend";
            this.addApplicantLegend.Size = new System.Drawing.Size(440, 390);
            this.addApplicantLegend.TabIndex = 47;
            this.addApplicantLegend.TabStop = false;
            // 
            // AddApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.addApplicantLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddApplicant";
            this.Text = "Add Applicant";
            this.Load += new System.EventHandler(this.AddApplicant_Load);
            this.addApplicantLegend.ResumeLayout(false);
            this.addApplicantLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.Label addApplicantLabel;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox examIDCombo;
        private System.Windows.Forms.ComboBox employeeIDCombo;
        private System.Windows.Forms.GroupBox addApplicantLegend;
    }
}