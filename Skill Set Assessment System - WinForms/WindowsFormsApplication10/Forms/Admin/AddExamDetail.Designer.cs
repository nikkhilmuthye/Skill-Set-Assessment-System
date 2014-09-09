namespace WindowsFormsApplication10
{
    partial class AddExam
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
            this.addExamLabel = new System.Windows.Forms.Label();
            this.examTypeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.back = new System.Windows.Forms.Button();
            this.examTypeCombo = new System.Windows.Forms.ComboBox();
            this.configLabel = new System.Windows.Forms.Label();
            this.noConfigRadio = new System.Windows.Forms.RadioButton();
            this.yesConfigRadio = new System.Windows.Forms.RadioButton();
            this.duratoinLabel = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.addExamDetailsLegend = new System.Windows.Forms.GroupBox();
            this.addExamDetailsLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // addExamLabel
            // 
            this.addExamLabel.AutoSize = true;
            this.addExamLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExamLabel.ForeColor = System.Drawing.Color.White;
            this.addExamLabel.Location = new System.Drawing.Point(167, 0);
            this.addExamLabel.Name = "addExamLabel";
            this.addExamLabel.Size = new System.Drawing.Size(105, 24);
            this.addExamLabel.TabIndex = 0;
            this.addExamLabel.Text = "Add Exam";
            // 
            // examTypeLabel
            // 
            this.examTypeLabel.AutoSize = true;
            this.examTypeLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examTypeLabel.ForeColor = System.Drawing.Color.White;
            this.examTypeLabel.Location = new System.Drawing.Point(84, 75);
            this.examTypeLabel.Name = "examTypeLabel";
            this.examTypeLabel.Size = new System.Drawing.Size(86, 17);
            this.examTypeLabel.TabIndex = 2;
            this.examTypeLabel.Text = "Exam Type";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(84, 128);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(41, 17);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(295, 369);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(70, 30);
            this.add.TabIndex = 17;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(244, 128);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 18;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(70, 369);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 19;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // examTypeCombo
            // 
            this.examTypeCombo.FormattingEnabled = true;
            this.examTypeCombo.Location = new System.Drawing.Point(244, 75);
            this.examTypeCombo.Name = "examTypeCombo";
            this.examTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.examTypeCombo.TabIndex = 20;
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configLabel.ForeColor = System.Drawing.Color.White;
            this.configLabel.Location = new System.Drawing.Point(87, 266);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(214, 26);
            this.configLabel.TabIndex = 23;
            this.configLabel.Text = "Allow Employees to view the correct\r\n answers after the exam ?";
            // 
            // noConfigRadio
            // 
            this.noConfigRadio.AutoSize = true;
            this.noConfigRadio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noConfigRadio.ForeColor = System.Drawing.Color.White;
            this.noConfigRadio.Location = new System.Drawing.Point(213, 323);
            this.noConfigRadio.Name = "noConfigRadio";
            this.noConfigRadio.Size = new System.Drawing.Size(40, 17);
            this.noConfigRadio.TabIndex = 22;
            this.noConfigRadio.TabStop = true;
            this.noConfigRadio.Text = "No";
            this.noConfigRadio.UseVisualStyleBackColor = true;
            // 
            // yesConfigRadio
            // 
            this.yesConfigRadio.AutoSize = true;
            this.yesConfigRadio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesConfigRadio.ForeColor = System.Drawing.Color.White;
            this.yesConfigRadio.Location = new System.Drawing.Point(110, 323);
            this.yesConfigRadio.Name = "yesConfigRadio";
            this.yesConfigRadio.Size = new System.Drawing.Size(45, 17);
            this.yesConfigRadio.TabIndex = 21;
            this.yesConfigRadio.TabStop = true;
            this.yesConfigRadio.Text = "Yes";
            this.yesConfigRadio.UseVisualStyleBackColor = true;
            // 
            // duratoinLabel
            // 
            this.duratoinLabel.AutoSize = true;
            this.duratoinLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duratoinLabel.ForeColor = System.Drawing.Color.White;
            this.duratoinLabel.Location = new System.Drawing.Point(87, 188);
            this.duratoinLabel.Name = "duratoinLabel";
            this.duratoinLabel.Size = new System.Drawing.Size(132, 34);
            this.duratoinLabel.TabIndex = 24;
            this.duratoinLabel.Text = "Duration of Exam\r\n(in minutes)";
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(244, 188);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 20);
            this.durationTextBox.TabIndex = 25;
            // 
            // addExamDetailsLegend
            // 
            this.addExamDetailsLegend.Controls.Add(this.addExamLabel);
            this.addExamDetailsLegend.Controls.Add(this.durationTextBox);
            this.addExamDetailsLegend.Controls.Add(this.examTypeLabel);
            this.addExamDetailsLegend.Controls.Add(this.duratoinLabel);
            this.addExamDetailsLegend.Controls.Add(this.dateLabel);
            this.addExamDetailsLegend.Controls.Add(this.configLabel);
            this.addExamDetailsLegend.Controls.Add(this.add);
            this.addExamDetailsLegend.Controls.Add(this.noConfigRadio);
            this.addExamDetailsLegend.Controls.Add(this.datePicker);
            this.addExamDetailsLegend.Controls.Add(this.yesConfigRadio);
            this.addExamDetailsLegend.Controls.Add(this.back);
            this.addExamDetailsLegend.Controls.Add(this.examTypeCombo);
            this.addExamDetailsLegend.Location = new System.Drawing.Point(54, 39);
            this.addExamDetailsLegend.Name = "addExamDetailsLegend";
            this.addExamDetailsLegend.Size = new System.Drawing.Size(471, 414);
            this.addExamDetailsLegend.TabIndex = 26;
            this.addExamDetailsLegend.TabStop = false;
            // 
            // AddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.addExamDetailsLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddExam";
            this.Text = "Add Exam";
            this.Load += new System.EventHandler(this.AddExam_Load);
            this.addExamDetailsLegend.ResumeLayout(false);
            this.addExamDetailsLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addExamLabel;
        private System.Windows.Forms.Label examTypeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox examTypeCombo;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.RadioButton noConfigRadio;
        private System.Windows.Forms.RadioButton yesConfigRadio;
        private System.Windows.Forms.Label duratoinLabel;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.GroupBox addExamDetailsLegend;
    }
}