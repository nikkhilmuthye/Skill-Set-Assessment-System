namespace WindowsFormsApplication10
{
    partial class DeletePaper
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
            this.examIDCombo = new System.Windows.Forms.ComboBox();
            this.examIDLabel = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.selectExamIDLabel = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.deleteExamLabel = new System.Windows.Forms.Label();
            this.deletePaperLegend = new System.Windows.Forms.GroupBox();
            this.deletePaperLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // examIDCombo
            // 
            this.examIDCombo.FormattingEnabled = true;
            this.examIDCombo.Location = new System.Drawing.Point(233, 149);
            this.examIDCombo.Name = "examIDCombo";
            this.examIDCombo.Size = new System.Drawing.Size(121, 21);
            this.examIDCombo.TabIndex = 0;
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(66, 149);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(74, 17);
            this.examIDLabel.TabIndex = 1;
            this.examIDLabel.Text = "Exam ID:";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(253, 270);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(70, 30);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // selectExamIDLabel
            // 
            this.selectExamIDLabel.AutoSize = true;
            this.selectExamIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectExamIDLabel.ForeColor = System.Drawing.Color.White;
            this.selectExamIDLabel.Location = new System.Drawing.Point(130, 94);
            this.selectExamIDLabel.Name = "selectExamIDLabel";
            this.selectExamIDLabel.Size = new System.Drawing.Size(115, 17);
            this.selectExamIDLabel.TabIndex = 3;
            this.selectExamIDLabel.Text = "Select Exam ID";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(57, 270);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // deleteExamLabel
            // 
            this.deleteExamLabel.AutoSize = true;
            this.deleteExamLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteExamLabel.ForeColor = System.Drawing.Color.White;
            this.deleteExamLabel.Location = new System.Drawing.Point(122, 0);
            this.deleteExamLabel.Name = "deleteExamLabel";
            this.deleteExamLabel.Size = new System.Drawing.Size(125, 24);
            this.deleteExamLabel.TabIndex = 28;
            this.deleteExamLabel.Text = "Delete Paper";
            // 
            // deletePaperLegend
            // 
            this.deletePaperLegend.Controls.Add(this.deleteExamLabel);
            this.deletePaperLegend.Controls.Add(this.examIDCombo);
            this.deletePaperLegend.Controls.Add(this.back);
            this.deletePaperLegend.Controls.Add(this.examIDLabel);
            this.deletePaperLegend.Controls.Add(this.selectExamIDLabel);
            this.deletePaperLegend.Controls.Add(this.delete);
            this.deletePaperLegend.Location = new System.Drawing.Point(118, 91);
            this.deletePaperLegend.Name = "deletePaperLegend";
            this.deletePaperLegend.Size = new System.Drawing.Size(427, 365);
            this.deletePaperLegend.TabIndex = 29;
            this.deletePaperLegend.TabStop = false;
            // 
            // DeletePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.deletePaperLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletePaper";
            this.Text = "DeletePaper";
            this.Load += new System.EventHandler(this.DeletePaper_Load);
            this.deletePaperLegend.ResumeLayout(false);
            this.deletePaperLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox examIDCombo;
        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label selectExamIDLabel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label deleteExamLabel;
        private System.Windows.Forms.GroupBox deletePaperLegend;
    }
}