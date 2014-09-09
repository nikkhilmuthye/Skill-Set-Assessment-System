namespace WindowsFormsApplication10
{
    partial class AddExamType
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
            this.addExamTypeLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.noOfAttemptsLabel = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.levelCombo = new System.Windows.Forms.ComboBox();
            this.noOfAttemptsCombo = new System.Windows.Forms.ComboBox();
            this.addExamTypeLegend = new System.Windows.Forms.GroupBox();
            this.addExamTypeLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // addExamTypeLabel
            // 
            this.addExamTypeLabel.AutoSize = true;
            this.addExamTypeLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExamTypeLabel.ForeColor = System.Drawing.Color.White;
            this.addExamTypeLabel.Location = new System.Drawing.Point(166, 0);
            this.addExamTypeLabel.Name = "addExamTypeLabel";
            this.addExamTypeLabel.Size = new System.Drawing.Size(155, 24);
            this.addExamTypeLabel.TabIndex = 0;
            this.addExamTypeLabel.Text = "Add Exam Type";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.ForeColor = System.Drawing.Color.White;
            this.subjectLabel.Location = new System.Drawing.Point(113, 79);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(62, 17);
            this.subjectLabel.TabIndex = 2;
            this.subjectLabel.Text = "Subject";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.White;
            this.levelLabel.Location = new System.Drawing.Point(113, 133);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(43, 17);
            this.levelLabel.TabIndex = 3;
            this.levelLabel.Text = "Level";
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(235, 79);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(121, 20);
            this.subjectText.TabIndex = 5;
            // 
            // noOfAttemptsLabel
            // 
            this.noOfAttemptsLabel.AutoSize = true;
            this.noOfAttemptsLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfAttemptsLabel.ForeColor = System.Drawing.Color.White;
            this.noOfAttemptsLabel.Location = new System.Drawing.Point(113, 187);
            this.noOfAttemptsLabel.Name = "noOfAttemptsLabel";
            this.noOfAttemptsLabel.Size = new System.Drawing.Size(82, 34);
            this.noOfAttemptsLabel.TabIndex = 7;
            this.noOfAttemptsLabel.Text = "Number of\r\nAttempts";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(322, 302);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(70, 30);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.add_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(105, 302);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 10;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // levelCombo
            // 
            this.levelCombo.FormattingEnabled = true;
            this.levelCombo.Location = new System.Drawing.Point(235, 133);
            this.levelCombo.Name = "levelCombo";
            this.levelCombo.Size = new System.Drawing.Size(121, 21);
            this.levelCombo.TabIndex = 11;
            // 
            // noOfAttemptsCombo
            // 
            this.noOfAttemptsCombo.FormattingEnabled = true;
            this.noOfAttemptsCombo.Location = new System.Drawing.Point(235, 187);
            this.noOfAttemptsCombo.Name = "noOfAttemptsCombo";
            this.noOfAttemptsCombo.Size = new System.Drawing.Size(121, 21);
            this.noOfAttemptsCombo.TabIndex = 12;
            // 
            // addExamTypeLegend
            // 
            this.addExamTypeLegend.Controls.Add(this.addExamTypeLabel);
            this.addExamTypeLegend.Controls.Add(this.noOfAttemptsCombo);
            this.addExamTypeLegend.Controls.Add(this.subjectLabel);
            this.addExamTypeLegend.Controls.Add(this.levelCombo);
            this.addExamTypeLegend.Controls.Add(this.levelLabel);
            this.addExamTypeLegend.Controls.Add(this.back);
            this.addExamTypeLegend.Controls.Add(this.subjectText);
            this.addExamTypeLegend.Controls.Add(this.Add);
            this.addExamTypeLegend.Controls.Add(this.noOfAttemptsLabel);
            this.addExamTypeLegend.Location = new System.Drawing.Point(62, 72);
            this.addExamTypeLegend.Name = "addExamTypeLegend";
            this.addExamTypeLegend.Size = new System.Drawing.Size(482, 360);
            this.addExamTypeLegend.TabIndex = 13;
            this.addExamTypeLegend.TabStop = false;
            // 
            // AddExamType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.addExamTypeLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddExamType";
            this.Text = "Add Exam Type";
            this.Load += new System.EventHandler(this.AddExamType_Load);
            this.addExamTypeLegend.ResumeLayout(false);
            this.addExamTypeLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addExamTypeLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.Label noOfAttemptsLabel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox levelCombo;
        private System.Windows.Forms.ComboBox noOfAttemptsCombo;
        private System.Windows.Forms.GroupBox addExamTypeLegend;
    }
}