namespace WindowsFormsApplication10
{
    partial class SetPaper
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
            this.examTypeLabel = new System.Windows.Forms.Label();
            this.examTypeText = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.noOfQuestionsCombo = new System.Windows.Forms.ComboBox();
            this.formatCombo = new System.Windows.Forms.ComboBox();
            this.sectionCombo = new System.Windows.Forms.ComboBox();
            this.noOfQuestionsLabel = new System.Windows.Forms.Label();
            this.formatText = new System.Windows.Forms.Label();
            this.sectionText = new System.Windows.Forms.Label();
            this.noOfQuestionsAddedLabel = new System.Windows.Forms.Label();
            this.noOfQuestionsText = new System.Windows.Forms.TextBox();
            this.setPaperLabel = new System.Windows.Forms.Label();
            this.setPaperRegion = new System.Windows.Forms.GroupBox();
            this.setPaperRegion.SuspendLayout();
            this.SuspendLayout();
            // 
            // examTypeLabel
            // 
            this.examTypeLabel.AutoSize = true;
            this.examTypeLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examTypeLabel.ForeColor = System.Drawing.Color.White;
            this.examTypeLabel.Location = new System.Drawing.Point(671, 30);
            this.examTypeLabel.Name = "examTypeLabel";
            this.examTypeLabel.Size = new System.Drawing.Size(92, 17);
            this.examTypeLabel.TabIndex = 0;
            this.examTypeLabel.Text = "Exam Type:";
            // 
            // examTypeText
            // 
            this.examTypeText.Location = new System.Drawing.Point(878, 30);
            this.examTypeText.Name = "examTypeText";
            this.examTypeText.ReadOnly = true;
            this.examTypeText.Size = new System.Drawing.Size(100, 20);
            this.examTypeText.TabIndex = 4;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(313, 264);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(70, 30);
            this.add.TabIndex = 22;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(68, 264);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 21;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // noOfQuestionsCombo
            // 
            this.noOfQuestionsCombo.FormattingEnabled = true;
            this.noOfQuestionsCombo.Location = new System.Drawing.Point(272, 148);
            this.noOfQuestionsCombo.Name = "noOfQuestionsCombo";
            this.noOfQuestionsCombo.Size = new System.Drawing.Size(121, 21);
            this.noOfQuestionsCombo.TabIndex = 18;
            // 
            // formatCombo
            // 
            this.formatCombo.FormattingEnabled = true;
            this.formatCombo.Location = new System.Drawing.Point(272, 103);
            this.formatCombo.Name = "formatCombo";
            this.formatCombo.Size = new System.Drawing.Size(121, 21);
            this.formatCombo.TabIndex = 17;
            this.formatCombo.SelectedIndexChanged += new System.EventHandler(this.formatCombo_SelectedIndexChanged);
            // 
            // sectionCombo
            // 
            this.sectionCombo.FormattingEnabled = true;
            this.sectionCombo.Location = new System.Drawing.Point(272, 47);
            this.sectionCombo.Name = "sectionCombo";
            this.sectionCombo.Size = new System.Drawing.Size(121, 21);
            this.sectionCombo.TabIndex = 16;
            this.sectionCombo.SelectedIndexChanged += new System.EventHandler(this.sectionCombo_SelectedIndexChanged);
            // 
            // noOfQuestionsLabel
            // 
            this.noOfQuestionsLabel.AutoSize = true;
            this.noOfQuestionsLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfQuestionsLabel.ForeColor = System.Drawing.Color.White;
            this.noOfQuestionsLabel.Location = new System.Drawing.Point(65, 152);
            this.noOfQuestionsLabel.Name = "noOfQuestionsLabel";
            this.noOfQuestionsLabel.Size = new System.Drawing.Size(124, 17);
            this.noOfQuestionsLabel.TabIndex = 15;
            this.noOfQuestionsLabel.Text = "No Of Questions";
            // 
            // formatText
            // 
            this.formatText.AutoSize = true;
            this.formatText.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatText.ForeColor = System.Drawing.Color.White;
            this.formatText.Location = new System.Drawing.Point(65, 104);
            this.formatText.Name = "formatText";
            this.formatText.Size = new System.Drawing.Size(58, 17);
            this.formatText.TabIndex = 14;
            this.formatText.Text = "Format";
            // 
            // sectionText
            // 
            this.sectionText.AutoSize = true;
            this.sectionText.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionText.ForeColor = System.Drawing.Color.White;
            this.sectionText.Location = new System.Drawing.Point(65, 48);
            this.sectionText.Name = "sectionText";
            this.sectionText.Size = new System.Drawing.Size(60, 17);
            this.sectionText.TabIndex = 13;
            this.sectionText.Text = "Section";
            // 
            // noOfQuestionsAddedLabel
            // 
            this.noOfQuestionsAddedLabel.AutoSize = true;
            this.noOfQuestionsAddedLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfQuestionsAddedLabel.ForeColor = System.Drawing.Color.White;
            this.noOfQuestionsAddedLabel.Location = new System.Drawing.Point(671, 78);
            this.noOfQuestionsAddedLabel.Name = "noOfQuestionsAddedLabel";
            this.noOfQuestionsAddedLabel.Size = new System.Drawing.Size(180, 17);
            this.noOfQuestionsAddedLabel.TabIndex = 24;
            this.noOfQuestionsAddedLabel.Text = "No Of Questions Added:";
            // 
            // noOfQuestionsText
            // 
            this.noOfQuestionsText.Location = new System.Drawing.Point(878, 78);
            this.noOfQuestionsText.Name = "noOfQuestionsText";
            this.noOfQuestionsText.ReadOnly = true;
            this.noOfQuestionsText.Size = new System.Drawing.Size(100, 20);
            this.noOfQuestionsText.TabIndex = 25;
            // 
            // setPaperLabel
            // 
            this.setPaperLabel.AutoSize = true;
            this.setPaperLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPaperLabel.ForeColor = System.Drawing.Color.White;
            this.setPaperLabel.Location = new System.Drawing.Point(123, 0);
            this.setPaperLabel.Name = "setPaperLabel";
            this.setPaperLabel.Size = new System.Drawing.Size(95, 24);
            this.setPaperLabel.TabIndex = 26;
            this.setPaperLabel.Text = "Set Paper";
            // 
            // setPaperRegion
            // 
            this.setPaperRegion.Controls.Add(this.setPaperLabel);
            this.setPaperRegion.Controls.Add(this.sectionText);
            this.setPaperRegion.Controls.Add(this.formatText);
            this.setPaperRegion.Controls.Add(this.noOfQuestionsLabel);
            this.setPaperRegion.Controls.Add(this.add);
            this.setPaperRegion.Controls.Add(this.sectionCombo);
            this.setPaperRegion.Controls.Add(this.back);
            this.setPaperRegion.Controls.Add(this.formatCombo);
            this.setPaperRegion.Controls.Add(this.noOfQuestionsCombo);
            this.setPaperRegion.Location = new System.Drawing.Point(82, 181);
            this.setPaperRegion.Name = "setPaperRegion";
            this.setPaperRegion.Size = new System.Drawing.Size(477, 345);
            this.setPaperRegion.TabIndex = 27;
            this.setPaperRegion.TabStop = false;
            // 
            // SetPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1560, 550);
            this.ControlBox = false;
            this.Controls.Add(this.setPaperRegion);
            this.Controls.Add(this.noOfQuestionsText);
            this.Controls.Add(this.noOfQuestionsAddedLabel);
            this.Controls.Add(this.examTypeText);
            this.Controls.Add(this.examTypeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetPaper";
            this.Text = "SetPaper";
            this.Load += new System.EventHandler(this.SetPaper_Load);
            this.Click += new System.EventHandler(this.SetPaper_Load);
            this.setPaperRegion.ResumeLayout(false);
            this.setPaperRegion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label examTypeLabel;
        private System.Windows.Forms.TextBox examTypeText;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox noOfQuestionsCombo;
        private System.Windows.Forms.ComboBox formatCombo;
        private System.Windows.Forms.ComboBox sectionCombo;
        private System.Windows.Forms.Label noOfQuestionsLabel;
        private System.Windows.Forms.Label formatText;
        private System.Windows.Forms.Label sectionText;
        private System.Windows.Forms.Label noOfQuestionsAddedLabel;
        private System.Windows.Forms.TextBox noOfQuestionsText;
        private System.Windows.Forms.Label setPaperLabel;
        private System.Windows.Forms.GroupBox setPaperRegion;
    }
}