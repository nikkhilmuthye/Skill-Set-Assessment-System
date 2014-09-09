namespace WindowsFormsApplication10
{
    partial class UpdateQuestion
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
            this.questionIDCombo = new System.Windows.Forms.ComboBox();
            this.questionIDLabel = new System.Windows.Forms.Label();
            this.selectQuestionLabel = new System.Windows.Forms.Label();
            this.updateQuestionLabel = new System.Windows.Forms.Label();
            this.updateQuestionLegend = new System.Windows.Forms.GroupBox();
            this.updateQuestionLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.White;
            this.go.Location = new System.Drawing.Point(363, 310);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(70, 30);
            this.go.TabIndex = 26;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(44, 310);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 25;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // questionIDCombo
            // 
            this.questionIDCombo.FormattingEnabled = true;
            this.questionIDCombo.Location = new System.Drawing.Point(268, 180);
            this.questionIDCombo.Name = "questionIDCombo";
            this.questionIDCombo.Size = new System.Drawing.Size(121, 21);
            this.questionIDCombo.TabIndex = 24;
            // 
            // questionIDLabel
            // 
            this.questionIDLabel.AutoSize = true;
            this.questionIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionIDLabel.ForeColor = System.Drawing.Color.White;
            this.questionIDLabel.Location = new System.Drawing.Point(99, 184);
            this.questionIDLabel.Name = "questionIDLabel";
            this.questionIDLabel.Size = new System.Drawing.Size(98, 17);
            this.questionIDLabel.TabIndex = 23;
            this.questionIDLabel.Text = "Question ID:";
            // 
            // selectQuestionLabel
            // 
            this.selectQuestionLabel.AutoSize = true;
            this.selectQuestionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.selectQuestionLabel.Location = new System.Drawing.Point(198, 135);
            this.selectQuestionLabel.Name = "selectQuestionLabel";
            this.selectQuestionLabel.Size = new System.Drawing.Size(118, 17);
            this.selectQuestionLabel.TabIndex = 22;
            this.selectQuestionLabel.Text = "Select Question";
            // 
            // updateQuestionLabel
            // 
            this.updateQuestionLabel.AutoSize = true;
            this.updateQuestionLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.updateQuestionLabel.Location = new System.Drawing.Point(183, 0);
            this.updateQuestionLabel.Name = "updateQuestionLabel";
            this.updateQuestionLabel.Size = new System.Drawing.Size(164, 24);
            this.updateQuestionLabel.TabIndex = 84;
            this.updateQuestionLabel.Text = "Update Question";
            // 
            // updateQuestionLegend
            // 
            this.updateQuestionLegend.Controls.Add(this.updateQuestionLabel);
            this.updateQuestionLegend.Controls.Add(this.selectQuestionLabel);
            this.updateQuestionLegend.Controls.Add(this.go);
            this.updateQuestionLegend.Controls.Add(this.questionIDLabel);
            this.updateQuestionLegend.Controls.Add(this.back);
            this.updateQuestionLegend.Controls.Add(this.questionIDCombo);
            this.updateQuestionLegend.Location = new System.Drawing.Point(111, 41);
            this.updateQuestionLegend.Name = "updateQuestionLegend";
            this.updateQuestionLegend.Size = new System.Drawing.Size(497, 408);
            this.updateQuestionLegend.TabIndex = 85;
            this.updateQuestionLegend.TabStop = false;
            // 
            // UpdateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.updateQuestionLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateQuestion";
            this.Text = "Update Question";
            this.Load += new System.EventHandler(this.UpdateQuestion_Load);
            this.updateQuestionLegend.ResumeLayout(false);
            this.updateQuestionLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox questionIDCombo;
        private System.Windows.Forms.Label questionIDLabel;
        private System.Windows.Forms.Label selectQuestionLabel;
        private System.Windows.Forms.Label updateQuestionLabel;
        private System.Windows.Forms.GroupBox updateQuestionLegend;
    }
}