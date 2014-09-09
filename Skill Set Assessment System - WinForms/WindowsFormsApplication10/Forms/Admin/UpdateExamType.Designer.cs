namespace WindowsFormsApplication10
{
    partial class UpdateExamType
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
            this.update = new System.Windows.Forms.Button();
            this.noOfAttemptsLabel = new System.Windows.Forms.Label();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.examTypeLabel = new System.Windows.Forms.Label();
            this.updateExamTypeLabel = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.examTypeCombo = new System.Windows.Forms.ComboBox();
            this.levelCombo = new System.Windows.Forms.ComboBox();
            this.noOfAttemptsCombo = new System.Windows.Forms.ComboBox();
            this.updateExamTypeLegend = new System.Windows.Forms.GroupBox();
            this.updateExamTypeLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(319, 346);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(70, 30);
            this.update.TabIndex = 19;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // noOfAttemptsLabel
            // 
            this.noOfAttemptsLabel.AutoSize = true;
            this.noOfAttemptsLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfAttemptsLabel.ForeColor = System.Drawing.Color.White;
            this.noOfAttemptsLabel.Location = new System.Drawing.Point(100, 202);
            this.noOfAttemptsLabel.Name = "noOfAttemptsLabel";
            this.noOfAttemptsLabel.Size = new System.Drawing.Size(82, 34);
            this.noOfAttemptsLabel.TabIndex = 17;
            this.noOfAttemptsLabel.Text = "Number of\r\nAttempts";
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(287, 108);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(121, 20);
            this.subjectText.TabIndex = 15;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.White;
            this.levelLabel.Location = new System.Drawing.Point(100, 153);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(43, 17);
            this.levelLabel.TabIndex = 13;
            this.levelLabel.Text = "Level";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.ForeColor = System.Drawing.Color.White;
            this.subjectLabel.Location = new System.Drawing.Point(100, 108);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(62, 17);
            this.subjectLabel.TabIndex = 12;
            this.subjectLabel.Text = "Subject";
            // 
            // examTypeLabel
            // 
            this.examTypeLabel.AutoSize = true;
            this.examTypeLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examTypeLabel.ForeColor = System.Drawing.Color.White;
            this.examTypeLabel.Location = new System.Drawing.Point(100, 66);
            this.examTypeLabel.Name = "examTypeLabel";
            this.examTypeLabel.Size = new System.Drawing.Size(86, 17);
            this.examTypeLabel.TabIndex = 11;
            this.examTypeLabel.Text = "Exam Type";
            // 
            // updateExamTypeLabel
            // 
            this.updateExamTypeLabel.AutoSize = true;
            this.updateExamTypeLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateExamTypeLabel.ForeColor = System.Drawing.Color.White;
            this.updateExamTypeLabel.Location = new System.Drawing.Point(143, 0);
            this.updateExamTypeLabel.Name = "updateExamTypeLabel";
            this.updateExamTypeLabel.Size = new System.Drawing.Size(182, 24);
            this.updateExamTypeLabel.TabIndex = 10;
            this.updateExamTypeLabel.Text = "Update Exam Type";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(103, 346);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 20;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // examTypeCombo
            // 
            this.examTypeCombo.FormattingEnabled = true;
            this.examTypeCombo.Location = new System.Drawing.Point(287, 66);
            this.examTypeCombo.Name = "examTypeCombo";
            this.examTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.examTypeCombo.TabIndex = 21;
            this.examTypeCombo.SelectedIndexChanged += new System.EventHandler(this.examTypeCombo_SelectedIndexChanged);
            // 
            // levelCombo
            // 
            this.levelCombo.FormattingEnabled = true;
            this.levelCombo.Location = new System.Drawing.Point(287, 153);
            this.levelCombo.Name = "levelCombo";
            this.levelCombo.Size = new System.Drawing.Size(121, 21);
            this.levelCombo.TabIndex = 23;
            // 
            // noOfAttemptsCombo
            // 
            this.noOfAttemptsCombo.FormattingEnabled = true;
            this.noOfAttemptsCombo.Location = new System.Drawing.Point(287, 202);
            this.noOfAttemptsCombo.Name = "noOfAttemptsCombo";
            this.noOfAttemptsCombo.Size = new System.Drawing.Size(121, 21);
            this.noOfAttemptsCombo.TabIndex = 24;
            // 
            // updateExamTypeLegend
            // 
            this.updateExamTypeLegend.Controls.Add(this.updateExamTypeLabel);
            this.updateExamTypeLegend.Controls.Add(this.noOfAttemptsCombo);
            this.updateExamTypeLegend.Controls.Add(this.examTypeLabel);
            this.updateExamTypeLegend.Controls.Add(this.levelCombo);
            this.updateExamTypeLegend.Controls.Add(this.subjectLabel);
            this.updateExamTypeLegend.Controls.Add(this.examTypeCombo);
            this.updateExamTypeLegend.Controls.Add(this.levelLabel);
            this.updateExamTypeLegend.Controls.Add(this.back);
            this.updateExamTypeLegend.Controls.Add(this.subjectText);
            this.updateExamTypeLegend.Controls.Add(this.update);
            this.updateExamTypeLegend.Controls.Add(this.noOfAttemptsLabel);
            this.updateExamTypeLegend.Location = new System.Drawing.Point(85, 71);
            this.updateExamTypeLegend.Name = "updateExamTypeLegend";
            this.updateExamTypeLegend.Size = new System.Drawing.Size(479, 386);
            this.updateExamTypeLegend.TabIndex = 25;
            this.updateExamTypeLegend.TabStop = false;
            // 
            // UpdateExamType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.updateExamTypeLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateExamType";
            this.Text = "Update Exam Type";
            this.Load += new System.EventHandler(this.UpdateExamType_Load);
            this.updateExamTypeLegend.ResumeLayout(false);
            this.updateExamTypeLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label noOfAttemptsLabel;
        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label examTypeLabel;
        private System.Windows.Forms.Label updateExamTypeLabel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox examTypeCombo;
        private System.Windows.Forms.ComboBox levelCombo;
        private System.Windows.Forms.ComboBox noOfAttemptsCombo;
        private System.Windows.Forms.GroupBox updateExamTypeLegend;
    }
}