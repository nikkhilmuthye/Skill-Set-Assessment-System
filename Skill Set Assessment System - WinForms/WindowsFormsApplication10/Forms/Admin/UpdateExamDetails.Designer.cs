namespace WindowsFormsApplication10
{
    partial class UpdateExamDetail
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.update = new System.Windows.Forms.Button();
            this.examType = new System.Windows.Forms.Label();
            this.examID = new System.Windows.Forms.Label();
            this.updateExam = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.examIDCombo = new System.Windows.Forms.ComboBox();
            this.examTypeCombo = new System.Windows.Forms.ComboBox();
            this.configLabel = new System.Windows.Forms.Label();
            this.noConfigRadio = new System.Windows.Forms.RadioButton();
            this.yesConfigRadio = new System.Windows.Forms.RadioButton();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.duratoinLabel = new System.Windows.Forms.Label();
            this.updateExamLegend = new System.Windows.Forms.GroupBox();
            this.updateExamLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(263, 143);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 33;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(281, 354);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(70, 30);
            this.update.TabIndex = 32;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // examType
            // 
            this.examType.AutoSize = true;
            this.examType.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examType.ForeColor = System.Drawing.Color.White;
            this.examType.Location = new System.Drawing.Point(90, 107);
            this.examType.Name = "examType";
            this.examType.Size = new System.Drawing.Size(86, 17);
            this.examType.TabIndex = 21;
            this.examType.Text = "Exam Type";
            // 
            // examID
            // 
            this.examID.AutoSize = true;
            this.examID.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examID.ForeColor = System.Drawing.Color.White;
            this.examID.Location = new System.Drawing.Point(90, 73);
            this.examID.Name = "examID";
            this.examID.Size = new System.Drawing.Size(68, 17);
            this.examID.TabIndex = 20;
            this.examID.Text = "Exam ID";
            // 
            // updateExam
            // 
            this.updateExam.AutoSize = true;
            this.updateExam.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateExam.ForeColor = System.Drawing.Color.White;
            this.updateExam.Location = new System.Drawing.Point(144, 0);
            this.updateExam.Name = "updateExam";
            this.updateExam.Size = new System.Drawing.Size(132, 24);
            this.updateExam.TabIndex = 19;
            this.updateExam.Text = "Update Exam";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(92, 354);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 34;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(90, 143);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(41, 17);
            this.date.TabIndex = 35;
            this.date.Text = "Date";
            // 
            // examIDCombo
            // 
            this.examIDCombo.FormattingEnabled = true;
            this.examIDCombo.Location = new System.Drawing.Point(263, 73);
            this.examIDCombo.Name = "examIDCombo";
            this.examIDCombo.Size = new System.Drawing.Size(121, 21);
            this.examIDCombo.TabIndex = 36;
            this.examIDCombo.SelectedIndexChanged += new System.EventHandler(this.examIDcombo_SelectedIndexChanged);
            // 
            // examTypeCombo
            // 
            this.examTypeCombo.FormattingEnabled = true;
            this.examTypeCombo.Location = new System.Drawing.Point(263, 107);
            this.examTypeCombo.Name = "examTypeCombo";
            this.examTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.examTypeCombo.TabIndex = 38;
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configLabel.ForeColor = System.Drawing.Color.White;
            this.configLabel.Location = new System.Drawing.Point(102, 249);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(261, 34);
            this.configLabel.TabIndex = 44;
            this.configLabel.Text = "Allow Employees to view the correct\r\n answers after the exam ?";
            // 
            // noConfigRadio
            // 
            this.noConfigRadio.AutoSize = true;
            this.noConfigRadio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noConfigRadio.ForeColor = System.Drawing.Color.White;
            this.noConfigRadio.Location = new System.Drawing.Point(251, 300);
            this.noConfigRadio.Name = "noConfigRadio";
            this.noConfigRadio.Size = new System.Drawing.Size(40, 17);
            this.noConfigRadio.TabIndex = 43;
            this.noConfigRadio.TabStop = true;
            this.noConfigRadio.Text = "No";
            this.noConfigRadio.UseVisualStyleBackColor = true;
            // 
            // yesConfigRadio
            // 
            this.yesConfigRadio.AutoSize = true;
            this.yesConfigRadio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesConfigRadio.ForeColor = System.Drawing.Color.White;
            this.yesConfigRadio.Location = new System.Drawing.Point(177, 300);
            this.yesConfigRadio.Name = "yesConfigRadio";
            this.yesConfigRadio.Size = new System.Drawing.Size(45, 17);
            this.yesConfigRadio.TabIndex = 42;
            this.yesConfigRadio.TabStop = true;
            this.yesConfigRadio.Text = "Yes";
            this.yesConfigRadio.UseVisualStyleBackColor = true;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(263, 183);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 20);
            this.durationTextBox.TabIndex = 46;
            // 
            // duratoinLabel
            // 
            this.duratoinLabel.AutoSize = true;
            this.duratoinLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duratoinLabel.ForeColor = System.Drawing.Color.White;
            this.duratoinLabel.Location = new System.Drawing.Point(90, 184);
            this.duratoinLabel.Name = "duratoinLabel";
            this.duratoinLabel.Size = new System.Drawing.Size(132, 34);
            this.duratoinLabel.TabIndex = 45;
            this.duratoinLabel.Text = "Duration of Exam\r\n(in minutes)";
            // 
            // updateExamLegend
            // 
            this.updateExamLegend.Controls.Add(this.updateExam);
            this.updateExamLegend.Controls.Add(this.durationTextBox);
            this.updateExamLegend.Controls.Add(this.examID);
            this.updateExamLegend.Controls.Add(this.duratoinLabel);
            this.updateExamLegend.Controls.Add(this.examType);
            this.updateExamLegend.Controls.Add(this.configLabel);
            this.updateExamLegend.Controls.Add(this.update);
            this.updateExamLegend.Controls.Add(this.noConfigRadio);
            this.updateExamLegend.Controls.Add(this.datePicker);
            this.updateExamLegend.Controls.Add(this.yesConfigRadio);
            this.updateExamLegend.Controls.Add(this.back);
            this.updateExamLegend.Controls.Add(this.examTypeCombo);
            this.updateExamLegend.Controls.Add(this.date);
            this.updateExamLegend.Controls.Add(this.examIDCombo);
            this.updateExamLegend.Location = new System.Drawing.Point(125, 64);
            this.updateExamLegend.Name = "updateExamLegend";
            this.updateExamLegend.Size = new System.Drawing.Size(525, 423);
            this.updateExamLegend.TabIndex = 47;
            this.updateExamLegend.TabStop = false;
            // 
            // UpdateExamDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.updateExamLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateExamDetail";
            this.Text = "Update Exam";
            this.Load += new System.EventHandler(this.UpdateExamDetail_Load);
            this.updateExamLegend.ResumeLayout(false);
            this.updateExamLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label examType;
        private System.Windows.Forms.Label examID;
        private System.Windows.Forms.Label updateExam;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.ComboBox examIDCombo;
        private System.Windows.Forms.ComboBox examTypeCombo;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.RadioButton noConfigRadio;
        private System.Windows.Forms.RadioButton yesConfigRadio;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.Label duratoinLabel;
        private System.Windows.Forms.GroupBox updateExamLegend;
    }
}