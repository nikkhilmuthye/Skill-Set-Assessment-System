namespace WindowsFormsApplication10
{
    partial class ViewPaper
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
            this.selectExamIDLabel = new System.Windows.Forms.Label();
            this.examIDLabel = new System.Windows.Forms.Label();
            this.examIDCombo = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.viewPaperLabel = new System.Windows.Forms.Label();
            this.viewPaperLegend = new System.Windows.Forms.GroupBox();
            this.viewPaperLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectExamIDLabel
            // 
            this.selectExamIDLabel.AutoSize = true;
            this.selectExamIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectExamIDLabel.ForeColor = System.Drawing.Color.White;
            this.selectExamIDLabel.Location = new System.Drawing.Point(62, 133);
            this.selectExamIDLabel.Name = "selectExamIDLabel";
            this.selectExamIDLabel.Size = new System.Drawing.Size(265, 17);
            this.selectExamIDLabel.TabIndex = 0;
            this.selectExamIDLabel.Text = "Select Exam ID to view paper details";
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(49, 174);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(74, 17);
            this.examIDLabel.TabIndex = 1;
            this.examIDLabel.Text = "Exam ID:";
            // 
            // examIDCombo
            // 
            this.examIDCombo.FormattingEnabled = true;
            this.examIDCombo.Location = new System.Drawing.Point(221, 170);
            this.examIDCombo.Name = "examIDCombo";
            this.examIDCombo.Size = new System.Drawing.Size(121, 21);
            this.examIDCombo.TabIndex = 2;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(11, 296);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.White;
            this.view.Location = new System.Drawing.Point(329, 296);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(70, 30);
            this.view.TabIndex = 4;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // viewPaperLabel
            // 
            this.viewPaperLabel.AutoSize = true;
            this.viewPaperLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPaperLabel.ForeColor = System.Drawing.Color.White;
            this.viewPaperLabel.Location = new System.Drawing.Point(171, 0);
            this.viewPaperLabel.Name = "viewPaperLabel";
            this.viewPaperLabel.Size = new System.Drawing.Size(114, 24);
            this.viewPaperLabel.TabIndex = 27;
            this.viewPaperLabel.Text = "View Paper";
            // 
            // viewPaperLegend
            // 
            this.viewPaperLegend.Controls.Add(this.viewPaperLabel);
            this.viewPaperLegend.Controls.Add(this.selectExamIDLabel);
            this.viewPaperLegend.Controls.Add(this.view);
            this.viewPaperLegend.Controls.Add(this.examIDLabel);
            this.viewPaperLegend.Controls.Add(this.back);
            this.viewPaperLegend.Controls.Add(this.examIDCombo);
            this.viewPaperLegend.Location = new System.Drawing.Point(142, 36);
            this.viewPaperLegend.Name = "viewPaperLegend";
            this.viewPaperLegend.Size = new System.Drawing.Size(413, 383);
            this.viewPaperLegend.TabIndex = 28;
            this.viewPaperLegend.TabStop = false;
            // 
            // ViewPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.viewPaperLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPaper";
            this.Text = "ViewPaper";
            this.Load += new System.EventHandler(this.ViewPaper_Load);
            this.viewPaperLegend.ResumeLayout(false);
            this.viewPaperLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label selectExamIDLabel;
        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.ComboBox examIDCombo;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Label viewPaperLabel;
        private System.Windows.Forms.GroupBox viewPaperLegend;
    }
}