namespace WindowsFormsApplication10
{
    partial class UpdatePaper
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
            this.noOfQuestionsText = new System.Windows.Forms.TextBox();
            this.noOfQuestionsAddedLabel = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.noOfQuestionsCombo = new System.Windows.Forms.ComboBox();
            this.formatCombo = new System.Windows.Forms.ComboBox();
            this.sectionCombo = new System.Windows.Forms.ComboBox();
            this.noOfQuestionsLabel = new System.Windows.Forms.Label();
            this.formatLabel = new System.Windows.Forms.Label();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.examTypeLabel = new System.Windows.Forms.Label();
            this.examTypeText = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.updateQuestionLabel = new System.Windows.Forms.Label();
            this.updatePaperLegend = new System.Windows.Forms.GroupBox();
            this.updatePaperLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // noOfQuestionsText
            // 
            this.noOfQuestionsText.Location = new System.Drawing.Point(884, 62);
            this.noOfQuestionsText.Name = "noOfQuestionsText";
            this.noOfQuestionsText.ReadOnly = true;
            this.noOfQuestionsText.Size = new System.Drawing.Size(100, 20);
            this.noOfQuestionsText.TabIndex = 42;
            this.noOfQuestionsText.TextChanged += new System.EventHandler(this.UpdatePaper_Load);
            // 
            // noOfQuestionsAddedLabel
            // 
            this.noOfQuestionsAddedLabel.AutoSize = true;
            this.noOfQuestionsAddedLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfQuestionsAddedLabel.ForeColor = System.Drawing.Color.White;
            this.noOfQuestionsAddedLabel.Location = new System.Drawing.Point(647, 62);
            this.noOfQuestionsAddedLabel.Name = "noOfQuestionsAddedLabel";
            this.noOfQuestionsAddedLabel.Size = new System.Drawing.Size(180, 17);
            this.noOfQuestionsAddedLabel.TabIndex = 41;
            this.noOfQuestionsAddedLabel.Text = "No Of Questions Added:";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(368, 328);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(70, 30);
            this.update.TabIndex = 39;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(30, 328);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 38;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // noOfQuestionsCombo
            // 
            this.noOfQuestionsCombo.FormattingEnabled = true;
            this.noOfQuestionsCombo.Location = new System.Drawing.Point(299, 248);
            this.noOfQuestionsCombo.Name = "noOfQuestionsCombo";
            this.noOfQuestionsCombo.Size = new System.Drawing.Size(121, 21);
            this.noOfQuestionsCombo.TabIndex = 35;
            // 
            // formatCombo
            // 
            this.formatCombo.FormattingEnabled = true;
            this.formatCombo.Location = new System.Drawing.Point(299, 198);
            this.formatCombo.Name = "formatCombo";
            this.formatCombo.Size = new System.Drawing.Size(121, 21);
            this.formatCombo.TabIndex = 34;
            this.formatCombo.SelectedIndexChanged += new System.EventHandler(this.formatCombo_SelectedIndexChanged);
            // 
            // sectionCombo
            // 
            this.sectionCombo.FormattingEnabled = true;
            this.sectionCombo.Location = new System.Drawing.Point(299, 153);
            this.sectionCombo.Name = "sectionCombo";
            this.sectionCombo.Size = new System.Drawing.Size(121, 21);
            this.sectionCombo.TabIndex = 33;
            this.sectionCombo.SelectedIndexChanged += new System.EventHandler(this.sectionCombo_SelectedIndexChanged);
            // 
            // noOfQuestionsLabel
            // 
            this.noOfQuestionsLabel.AutoSize = true;
            this.noOfQuestionsLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfQuestionsLabel.ForeColor = System.Drawing.Color.White;
            this.noOfQuestionsLabel.Location = new System.Drawing.Point(62, 248);
            this.noOfQuestionsLabel.Name = "noOfQuestionsLabel";
            this.noOfQuestionsLabel.Size = new System.Drawing.Size(130, 17);
            this.noOfQuestionsLabel.TabIndex = 32;
            this.noOfQuestionsLabel.Text = "No Of Questions:";
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatLabel.ForeColor = System.Drawing.Color.White;
            this.formatLabel.Location = new System.Drawing.Point(62, 198);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(64, 17);
            this.formatLabel.TabIndex = 31;
            this.formatLabel.Text = "Format:";
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionLabel.ForeColor = System.Drawing.Color.White;
            this.sectionLabel.Location = new System.Drawing.Point(62, 153);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(66, 17);
            this.sectionLabel.TabIndex = 30;
            this.sectionLabel.Text = "Section:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, -37);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, -34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Exam Type:";
            // 
            // examTypeLabel
            // 
            this.examTypeLabel.AutoSize = true;
            this.examTypeLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examTypeLabel.ForeColor = System.Drawing.Color.White;
            this.examTypeLabel.Location = new System.Drawing.Point(647, 20);
            this.examTypeLabel.Name = "examTypeLabel";
            this.examTypeLabel.Size = new System.Drawing.Size(86, 17);
            this.examTypeLabel.TabIndex = 43;
            this.examTypeLabel.Text = "Exam Type";
            // 
            // examTypeText
            // 
            this.examTypeText.Location = new System.Drawing.Point(884, 20);
            this.examTypeText.Name = "examTypeText";
            this.examTypeText.ReadOnly = true;
            this.examTypeText.Size = new System.Drawing.Size(100, 20);
            this.examTypeText.TabIndex = 44;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.Color.White;
            this.instructionLabel.Location = new System.Drawing.Point(97, 53);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(245, 51);
            this.instructionLabel.TabIndex = 45;
            this.instructionLabel.Text = "Select \'Section\' & \'Format\' to get\r\nthe current No Of Question count\r\nand update " +
                "it, if necessary.";
            // 
            // updateQuestionLabel
            // 
            this.updateQuestionLabel.AutoSize = true;
            this.updateQuestionLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.updateQuestionLabel.Location = new System.Drawing.Point(136, 0);
            this.updateQuestionLabel.Name = "updateQuestionLabel";
            this.updateQuestionLabel.Size = new System.Drawing.Size(134, 24);
            this.updateQuestionLabel.TabIndex = 136;
            this.updateQuestionLabel.Text = "Update Paper";
            // 
            // updatePaperLegend
            // 
            this.updatePaperLegend.Controls.Add(this.updateQuestionLabel);
            this.updatePaperLegend.Controls.Add(this.sectionLabel);
            this.updatePaperLegend.Controls.Add(this.instructionLabel);
            this.updatePaperLegend.Controls.Add(this.formatLabel);
            this.updatePaperLegend.Controls.Add(this.noOfQuestionsLabel);
            this.updatePaperLegend.Controls.Add(this.sectionCombo);
            this.updatePaperLegend.Controls.Add(this.formatCombo);
            this.updatePaperLegend.Controls.Add(this.noOfQuestionsCombo);
            this.updatePaperLegend.Controls.Add(this.update);
            this.updatePaperLegend.Controls.Add(this.back);
            this.updatePaperLegend.Location = new System.Drawing.Point(123, 83);
            this.updatePaperLegend.Name = "updatePaperLegend";
            this.updatePaperLegend.Size = new System.Drawing.Size(501, 432);
            this.updatePaperLegend.TabIndex = 137;
            this.updatePaperLegend.TabStop = false;
            // 
            // UpdatePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.updatePaperLegend);
            this.Controls.Add(this.examTypeText);
            this.Controls.Add(this.examTypeLabel);
            this.Controls.Add(this.noOfQuestionsText);
            this.Controls.Add(this.noOfQuestionsAddedLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePaper";
            this.Text = "Update Paper";
            this.Load += new System.EventHandler(this.UpdatePaper_Load);
            this.updatePaperLegend.ResumeLayout(false);
            this.updatePaperLegend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox noOfQuestionsText;
        private System.Windows.Forms.Label noOfQuestionsAddedLabel;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox noOfQuestionsCombo;
        private System.Windows.Forms.ComboBox formatCombo;
        private System.Windows.Forms.ComboBox sectionCombo;
        private System.Windows.Forms.Label noOfQuestionsLabel;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label examTypeLabel;
        private System.Windows.Forms.TextBox examTypeText;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label updateQuestionLabel;
        private System.Windows.Forms.GroupBox updatePaperLegend;
    }
}