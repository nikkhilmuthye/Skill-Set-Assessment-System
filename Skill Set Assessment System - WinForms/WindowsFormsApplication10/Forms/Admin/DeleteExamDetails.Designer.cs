namespace WindowsFormsApplication10
{
    partial class DeleteExamDetail
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
            this.examIDLabel = new System.Windows.Forms.Label();
            this.deleteExamLabel = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.examIDCombo = new System.Windows.Forms.ComboBox();
            this.deleteExamLegend = new System.Windows.Forms.GroupBox();
            this.deleteExamLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(67, 116);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(68, 17);
            this.examIDLabel.TabIndex = 28;
            this.examIDLabel.Text = "Exam ID";
            // 
            // deleteExamLabel
            // 
            this.deleteExamLabel.AutoSize = true;
            this.deleteExamLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteExamLabel.ForeColor = System.Drawing.Color.White;
            this.deleteExamLabel.Location = new System.Drawing.Point(126, 0);
            this.deleteExamLabel.Name = "deleteExamLabel";
            this.deleteExamLabel.Size = new System.Drawing.Size(123, 24);
            this.deleteExamLabel.TabIndex = 27;
            this.deleteExamLabel.Text = "Delete Exam";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(256, 237);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(70, 30);
            this.delete.TabIndex = 33;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(56, 237);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 34;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // examIDCombo
            // 
            this.examIDCombo.FormattingEnabled = true;
            this.examIDCombo.Location = new System.Drawing.Point(205, 116);
            this.examIDCombo.Name = "examIDCombo";
            this.examIDCombo.Size = new System.Drawing.Size(121, 21);
            this.examIDCombo.TabIndex = 35;
            // 
            // deleteExamLegend
            // 
            this.deleteExamLegend.Controls.Add(this.deleteExamLabel);
            this.deleteExamLegend.Controls.Add(this.examIDCombo);
            this.deleteExamLegend.Controls.Add(this.examIDLabel);
            this.deleteExamLegend.Controls.Add(this.back);
            this.deleteExamLegend.Controls.Add(this.delete);
            this.deleteExamLegend.Location = new System.Drawing.Point(119, 98);
            this.deleteExamLegend.Name = "deleteExamLegend";
            this.deleteExamLegend.Size = new System.Drawing.Size(387, 287);
            this.deleteExamLegend.TabIndex = 36;
            this.deleteExamLegend.TabStop = false;
            // 
            // DeleteExamDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.deleteExamLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteExamDetail";
            this.Text = "Delete Exam";
            this.Load += new System.EventHandler(this.DeleteExamDetail_Load);
            this.deleteExamLegend.ResumeLayout(false);
            this.deleteExamLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.Label deleteExamLabel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox examIDCombo;
        private System.Windows.Forms.GroupBox deleteExamLegend;
    }
}