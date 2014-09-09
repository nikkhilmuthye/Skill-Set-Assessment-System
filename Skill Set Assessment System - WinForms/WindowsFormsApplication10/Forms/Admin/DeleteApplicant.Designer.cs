namespace WindowsFormsApplication10
{
    partial class DeleteApplicant
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
            this.empIDexamIDcombo = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.deleteApplicantLabel = new System.Windows.Forms.Label();
            this.empIDexamIDLabel = new System.Windows.Forms.Label();
            this.deleteApplicantLegend = new System.Windows.Forms.GroupBox();
            this.deleteApplicantLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // empIDexamIDcombo
            // 
            this.empIDexamIDcombo.FormattingEnabled = true;
            this.empIDexamIDcombo.Location = new System.Drawing.Point(94, 137);
            this.empIDexamIDcombo.Name = "empIDexamIDcombo";
            this.empIDexamIDcombo.Size = new System.Drawing.Size(221, 21);
            this.empIDexamIDcombo.TabIndex = 0;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(77, 254);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(281, 254);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(70, 30);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // deleteApplicantLabel
            // 
            this.deleteApplicantLabel.AutoSize = true;
            this.deleteApplicantLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteApplicantLabel.ForeColor = System.Drawing.Color.White;
            this.deleteApplicantLabel.Location = new System.Drawing.Point(128, 0);
            this.deleteApplicantLabel.Name = "deleteApplicantLabel";
            this.deleteApplicantLabel.Size = new System.Drawing.Size(163, 24);
            this.deleteApplicantLabel.TabIndex = 4;
            this.deleteApplicantLabel.Text = "Delete Applicant";
            // 
            // empIDexamIDLabel
            // 
            this.empIDexamIDLabel.AutoSize = true;
            this.empIDexamIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIDexamIDLabel.ForeColor = System.Drawing.Color.White;
            this.empIDexamIDLabel.Location = new System.Drawing.Point(119, 103);
            this.empIDexamIDLabel.Name = "empIDexamIDLabel";
            this.empIDexamIDLabel.Size = new System.Drawing.Size(172, 17);
            this.empIDexamIDLabel.TabIndex = 5;
            this.empIDexamIDLabel.Text = "Employee ID : Exam ID";
            // 
            // deleteApplicantLegend
            // 
            this.deleteApplicantLegend.Controls.Add(this.deleteApplicantLabel);
            this.deleteApplicantLegend.Controls.Add(this.empIDexamIDLabel);
            this.deleteApplicantLegend.Controls.Add(this.empIDexamIDcombo);
            this.deleteApplicantLegend.Controls.Add(this.back);
            this.deleteApplicantLegend.Controls.Add(this.delete);
            this.deleteApplicantLegend.Location = new System.Drawing.Point(98, 82);
            this.deleteApplicantLegend.Name = "deleteApplicantLegend";
            this.deleteApplicantLegend.Size = new System.Drawing.Size(416, 363);
            this.deleteApplicantLegend.TabIndex = 6;
            this.deleteApplicantLegend.TabStop = false;
            // 
            // DeleteApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.deleteApplicantLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteApplicant";
            this.Text = "DeleteApplicant";
            this.Load += new System.EventHandler(this.DeleteApplicant_Load);
            this.deleteApplicantLegend.ResumeLayout(false);
            this.deleteApplicantLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox empIDexamIDcombo;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label deleteApplicantLabel;
        private System.Windows.Forms.Label empIDexamIDLabel;
        private System.Windows.Forms.GroupBox deleteApplicantLegend;
    }
}