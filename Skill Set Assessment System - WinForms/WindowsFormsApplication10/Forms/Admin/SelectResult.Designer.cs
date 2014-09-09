namespace WindowsFormsApplication10
{
    partial class SelectResult
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
            this.check = new System.Windows.Forms.Button();
            this.examIDLabel = new System.Windows.Forms.Label();
            this.selectResultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.examIDCombo = new System.Windows.Forms.ComboBox();
            this.selectExamLegend = new System.Windows.Forms.GroupBox();
            this.selectExamLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(251, 196);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(70, 30);
            this.check.TabIndex = 37;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(62, 103);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(68, 17);
            this.examIDLabel.TabIndex = 35;
            this.examIDLabel.Text = "Exam ID";
            // 
            // selectResultLabel
            // 
            this.selectResultLabel.AutoSize = true;
            this.selectResultLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectResultLabel.ForeColor = System.Drawing.Color.White;
            this.selectResultLabel.Location = new System.Drawing.Point(146, 0);
            this.selectResultLabel.Name = "selectResultLabel";
            this.selectResultLabel.Size = new System.Drawing.Size(124, 24);
            this.selectResultLabel.TabIndex = 34;
            this.selectResultLabel.Text = "Select Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 38;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(65, 210);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 39;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // examIDCombo
            // 
            this.examIDCombo.FormattingEnabled = true;
            this.examIDCombo.Location = new System.Drawing.Point(200, 99);
            this.examIDCombo.Name = "examIDCombo";
            this.examIDCombo.Size = new System.Drawing.Size(121, 21);
            this.examIDCombo.TabIndex = 40;
            // 
            // selectExamLegend
            // 
            this.selectExamLegend.Controls.Add(this.selectResultLabel);
            this.selectExamLegend.Controls.Add(this.examIDCombo);
            this.selectExamLegend.Controls.Add(this.examIDLabel);
            this.selectExamLegend.Controls.Add(this.back);
            this.selectExamLegend.Controls.Add(this.check);
            this.selectExamLegend.Location = new System.Drawing.Point(60, 50);
            this.selectExamLegend.Name = "selectExamLegend";
            this.selectExamLegend.Size = new System.Drawing.Size(466, 296);
            this.selectExamLegend.TabIndex = 41;
            this.selectExamLegend.TabStop = false;
            // 
            // SelectResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.selectExamLegend);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectResult";
            this.Text = "Select Result";
            this.Load += new System.EventHandler(this.SelectResult_Load);
            this.selectExamLegend.ResumeLayout(false);
            this.selectExamLegend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.Label selectResultLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox examIDCombo;
        private System.Windows.Forms.GroupBox selectExamLegend;
    }
}