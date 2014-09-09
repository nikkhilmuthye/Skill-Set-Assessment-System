namespace WindowsFormsApplication10
{
    partial class DeleteQuestion
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
            this.deleteQuestionLabel = new System.Windows.Forms.Label();
            this.questionIDLabel = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.questionIDCombo = new System.Windows.Forms.ComboBox();
            this.deleteQuestionLegend = new System.Windows.Forms.GroupBox();
            this.deleteQuestionLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteQuestionLabel
            // 
            this.deleteQuestionLabel.AutoSize = true;
            this.deleteQuestionLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.deleteQuestionLabel.Location = new System.Drawing.Point(149, 0);
            this.deleteQuestionLabel.Name = "deleteQuestionLabel";
            this.deleteQuestionLabel.Size = new System.Drawing.Size(155, 24);
            this.deleteQuestionLabel.TabIndex = 0;
            this.deleteQuestionLabel.Text = "Delete Question";
            // 
            // questionIDLabel
            // 
            this.questionIDLabel.AutoSize = true;
            this.questionIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionIDLabel.ForeColor = System.Drawing.Color.White;
            this.questionIDLabel.Location = new System.Drawing.Point(72, 107);
            this.questionIDLabel.Name = "questionIDLabel";
            this.questionIDLabel.Size = new System.Drawing.Size(92, 17);
            this.questionIDLabel.TabIndex = 1;
            this.questionIDLabel.Text = "Question ID";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(303, 274);
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
            this.back.Location = new System.Drawing.Point(94, 274);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // questionIDCombo
            // 
            this.questionIDCombo.FormattingEnabled = true;
            this.questionIDCombo.Location = new System.Drawing.Point(263, 107);
            this.questionIDCombo.Name = "questionIDCombo";
            this.questionIDCombo.Size = new System.Drawing.Size(121, 21);
            this.questionIDCombo.TabIndex = 5;
            // 
            // deleteQuestionLegend
            // 
            this.deleteQuestionLegend.Controls.Add(this.deleteQuestionLabel);
            this.deleteQuestionLegend.Controls.Add(this.questionIDCombo);
            this.deleteQuestionLegend.Controls.Add(this.questionIDLabel);
            this.deleteQuestionLegend.Controls.Add(this.back);
            this.deleteQuestionLegend.Controls.Add(this.delete);
            this.deleteQuestionLegend.Location = new System.Drawing.Point(72, 74);
            this.deleteQuestionLegend.Name = "deleteQuestionLegend";
            this.deleteQuestionLegend.Size = new System.Drawing.Size(447, 391);
            this.deleteQuestionLegend.TabIndex = 6;
            this.deleteQuestionLegend.TabStop = false;
            // 
            // DeleteQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.deleteQuestionLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteQuestion";
            this.Text = "Delete Question";
            this.Load += new System.EventHandler(this.DeleteQuestion_Load);
            this.deleteQuestionLegend.ResumeLayout(false);
            this.deleteQuestionLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label deleteQuestionLabel;
        private System.Windows.Forms.Label questionIDLabel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox questionIDCombo;
        private System.Windows.Forms.GroupBox deleteQuestionLegend;
    }
}