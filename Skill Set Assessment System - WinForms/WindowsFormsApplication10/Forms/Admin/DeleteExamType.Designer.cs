namespace WindowsFormsApplication10
{
    partial class DeleteExamType
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
            this.deleteExamTypeLabel = new System.Windows.Forms.Label();
            this.examTypeLabel = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.examTypeCombo = new System.Windows.Forms.ComboBox();
            this.deleteExamTypeLegend = new System.Windows.Forms.GroupBox();
            this.deleteExamTypeLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteExamTypeLabel
            // 
            this.deleteExamTypeLabel.AutoSize = true;
            this.deleteExamTypeLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteExamTypeLabel.ForeColor = System.Drawing.Color.White;
            this.deleteExamTypeLabel.Location = new System.Drawing.Point(138, 0);
            this.deleteExamTypeLabel.Name = "deleteExamTypeLabel";
            this.deleteExamTypeLabel.Size = new System.Drawing.Size(173, 24);
            this.deleteExamTypeLabel.TabIndex = 0;
            this.deleteExamTypeLabel.Text = "Delete Exam Type";
            // 
            // examTypeLabel
            // 
            this.examTypeLabel.AutoSize = true;
            this.examTypeLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examTypeLabel.ForeColor = System.Drawing.Color.White;
            this.examTypeLabel.Location = new System.Drawing.Point(102, 142);
            this.examTypeLabel.Name = "examTypeLabel";
            this.examTypeLabel.Size = new System.Drawing.Size(86, 17);
            this.examTypeLabel.TabIndex = 1;
            this.examTypeLabel.Text = "Exam Type";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(304, 267);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(70, 30);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(105, 267);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // examTypeCombo
            // 
            this.examTypeCombo.FormattingEnabled = true;
            this.examTypeCombo.Location = new System.Drawing.Point(253, 142);
            this.examTypeCombo.Name = "examTypeCombo";
            this.examTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.examTypeCombo.TabIndex = 5;
            // 
            // deleteExamTypeLegend
            // 
            this.deleteExamTypeLegend.Controls.Add(this.deleteExamTypeLabel);
            this.deleteExamTypeLegend.Controls.Add(this.examTypeCombo);
            this.deleteExamTypeLegend.Controls.Add(this.examTypeLabel);
            this.deleteExamTypeLegend.Controls.Add(this.back);
            this.deleteExamTypeLegend.Controls.Add(this.delete);
            this.deleteExamTypeLegend.Location = new System.Drawing.Point(141, 70);
            this.deleteExamTypeLegend.Name = "deleteExamTypeLegend";
            this.deleteExamTypeLegend.Size = new System.Drawing.Size(463, 365);
            this.deleteExamTypeLegend.TabIndex = 6;
            this.deleteExamTypeLegend.TabStop = false;
            // 
            // DeleteExamType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.deleteExamTypeLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteExamType";
            this.Text = "Delete Exam Type";
            this.Load += new System.EventHandler(this.DeleteExamType_Load);
            this.deleteExamTypeLegend.ResumeLayout(false);
            this.deleteExamTypeLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label deleteExamTypeLabel;
        private System.Windows.Forms.Label examTypeLabel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox examTypeCombo;
        private System.Windows.Forms.GroupBox deleteExamTypeLegend;
    }
}