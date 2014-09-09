namespace WindowsFormsApplication10
{
    partial class SelectUpdatePaper
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
            this.go = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.examIDCombo = new System.Windows.Forms.ComboBox();
            this.examIDLabel = new System.Windows.Forms.Label();
            this.selectExamIDLabel = new System.Windows.Forms.Label();
            this.selectPaperLegend = new System.Windows.Forms.GroupBox();
            this.selectPaperLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.White;
            this.go.Location = new System.Drawing.Point(248, 234);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(70, 30);
            this.go.TabIndex = 21;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(52, 234);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 20;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // examIDCombo
            // 
            this.examIDCombo.FormattingEnabled = true;
            this.examIDCombo.Location = new System.Drawing.Point(197, 115);
            this.examIDCombo.Name = "examIDCombo";
            this.examIDCombo.Size = new System.Drawing.Size(121, 21);
            this.examIDCombo.TabIndex = 19;
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(49, 115);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(68, 17);
            this.examIDLabel.TabIndex = 18;
            this.examIDLabel.Text = "Exam ID";
            // 
            // selectExamIDLabel
            // 
            this.selectExamIDLabel.AutoSize = true;
            this.selectExamIDLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectExamIDLabel.ForeColor = System.Drawing.Color.White;
            this.selectExamIDLabel.Location = new System.Drawing.Point(84, 0);
            this.selectExamIDLabel.Name = "selectExamIDLabel";
            this.selectExamIDLabel.Size = new System.Drawing.Size(145, 24);
            this.selectExamIDLabel.TabIndex = 17;
            this.selectExamIDLabel.Text = "Select Exam ID";
            // 
            // selectPaperLegend
            // 
            this.selectPaperLegend.Controls.Add(this.selectExamIDLabel);
            this.selectPaperLegend.Controls.Add(this.go);
            this.selectPaperLegend.Controls.Add(this.examIDLabel);
            this.selectPaperLegend.Controls.Add(this.back);
            this.selectPaperLegend.Controls.Add(this.examIDCombo);
            this.selectPaperLegend.Location = new System.Drawing.Point(72, 41);
            this.selectPaperLegend.Name = "selectPaperLegend";
            this.selectPaperLegend.Size = new System.Drawing.Size(383, 298);
            this.selectPaperLegend.TabIndex = 22;
            this.selectPaperLegend.TabStop = false;
            // 
            // SelectUpdatePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.selectPaperLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectUpdatePaper";
            this.Text = "Select Update Paper";
            this.Load += new System.EventHandler(this.SelectUpdatePaper_Load);
            this.selectPaperLegend.ResumeLayout(false);
            this.selectPaperLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox examIDCombo;
        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.Label selectExamIDLabel;
        private System.Windows.Forms.GroupBox selectPaperLegend;
    }
}