namespace WindowsFormsApplication10
{
    partial class AddSingleChoiceQuestion
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
            this.examTypeCombo = new System.Windows.Forms.ComboBox();
            this.marksCombo = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.option4Text = new System.Windows.Forms.TextBox();
            this.option3Text = new System.Windows.Forms.TextBox();
            this.option2Text = new System.Windows.Forms.TextBox();
            this.option1Text = new System.Windows.Forms.TextBox();
            this.questionText = new System.Windows.Forms.TextBox();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.marksLabel = new System.Windows.Forms.Label();
            this.formatLabel = new System.Windows.Forms.Label();
            this.solutionLabel = new System.Windows.Forms.Label();
            this.option4Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.examTypeLabel = new System.Windows.Forms.Label();
            this.addQuestionLabel = new System.Windows.Forms.Label();
            this.formatText = new System.Windows.Forms.TextBox();
            this.option1Radio = new System.Windows.Forms.RadioButton();
            this.option2Radio = new System.Windows.Forms.RadioButton();
            this.option3Radio = new System.Windows.Forms.RadioButton();
            this.option4Radio = new System.Windows.Forms.RadioButton();
            this.sectioncomboBox = new System.Windows.Forms.ComboBox();
            this.AddSingleChoiceLegend = new System.Windows.Forms.GroupBox();
            this.AddSingleChoiceLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // examTypeCombo
            // 
            this.examTypeCombo.FormattingEnabled = true;
            this.examTypeCombo.Location = new System.Drawing.Point(293, 74);
            this.examTypeCombo.Name = "examTypeCombo";
            this.examTypeCombo.Size = new System.Drawing.Size(100, 21);
            this.examTypeCombo.TabIndex = 58;
            // 
            // marksCombo
            // 
            this.marksCombo.FormattingEnabled = true;
            this.marksCombo.Location = new System.Drawing.Point(293, 378);
            this.marksCombo.Name = "marksCombo";
            this.marksCombo.Size = new System.Drawing.Size(100, 21);
            this.marksCombo.TabIndex = 57;
            this.marksCombo.SelectedIndexChanged += new System.EventHandler(this.marksCombo_SelectedIndexChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(103, 458);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 56;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(354, 458);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(70, 30);
            this.add.TabIndex = 55;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // option4Text
            // 
            this.option4Text.Location = new System.Drawing.Point(293, 252);
            this.option4Text.Name = "option4Text";
            this.option4Text.Size = new System.Drawing.Size(100, 20);
            this.option4Text.TabIndex = 53;
            // 
            // option3Text
            // 
            this.option3Text.Location = new System.Drawing.Point(293, 223);
            this.option3Text.Name = "option3Text";
            this.option3Text.Size = new System.Drawing.Size(100, 20);
            this.option3Text.TabIndex = 52;
            // 
            // option2Text
            // 
            this.option2Text.Location = new System.Drawing.Point(293, 195);
            this.option2Text.Name = "option2Text";
            this.option2Text.Size = new System.Drawing.Size(100, 20);
            this.option2Text.TabIndex = 51;
            // 
            // option1Text
            // 
            this.option1Text.Location = new System.Drawing.Point(293, 165);
            this.option1Text.Name = "option1Text";
            this.option1Text.Size = new System.Drawing.Size(100, 20);
            this.option1Text.TabIndex = 50;
            // 
            // questionText
            // 
            this.questionText.Location = new System.Drawing.Point(293, 107);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(100, 20);
            this.questionText.TabIndex = 49;
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionLabel.ForeColor = System.Drawing.Color.White;
            this.sectionLabel.Location = new System.Drawing.Point(124, 418);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(60, 17);
            this.sectionLabel.TabIndex = 47;
            this.sectionLabel.Text = "Section";
            // 
            // marksLabel
            // 
            this.marksLabel.AutoSize = true;
            this.marksLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksLabel.ForeColor = System.Drawing.Color.White;
            this.marksLabel.Location = new System.Drawing.Point(124, 382);
            this.marksLabel.Name = "marksLabel";
            this.marksLabel.Size = new System.Drawing.Size(49, 17);
            this.marksLabel.TabIndex = 46;
            this.marksLabel.Text = "Marks";
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatLabel.ForeColor = System.Drawing.Color.White;
            this.formatLabel.Location = new System.Drawing.Point(124, 134);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(58, 17);
            this.formatLabel.TabIndex = 45;
            this.formatLabel.Text = "Format";
            // 
            // solutionLabel
            // 
            this.solutionLabel.AutoSize = true;
            this.solutionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionLabel.ForeColor = System.Drawing.Color.White;
            this.solutionLabel.Location = new System.Drawing.Point(212, 293);
            this.solutionLabel.Name = "solutionLabel";
            this.solutionLabel.Size = new System.Drawing.Size(66, 17);
            this.solutionLabel.TabIndex = 44;
            this.solutionLabel.Text = "Solution";
            // 
            // option4Label
            // 
            this.option4Label.AutoSize = true;
            this.option4Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4Label.ForeColor = System.Drawing.Color.White;
            this.option4Label.Location = new System.Drawing.Point(124, 252);
            this.option4Label.Name = "option4Label";
            this.option4Label.Size = new System.Drawing.Size(69, 17);
            this.option4Label.TabIndex = 43;
            this.option4Label.Text = "Option 4";
            // 
            // option3Label
            // 
            this.option3Label.AutoSize = true;
            this.option3Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.ForeColor = System.Drawing.Color.White;
            this.option3Label.Location = new System.Drawing.Point(124, 223);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(69, 17);
            this.option3Label.TabIndex = 42;
            this.option3Label.Text = "Option 3";
            // 
            // option2Label
            // 
            this.option2Label.AutoSize = true;
            this.option2Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(124, 195);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(69, 17);
            this.option2Label.TabIndex = 41;
            this.option2Label.Text = "Option 2";
            // 
            // option1Label
            // 
            this.option1Label.AutoSize = true;
            this.option1Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(124, 165);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(69, 17);
            this.option1Label.TabIndex = 40;
            this.option1Label.Text = "Option 1";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(124, 107);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(71, 17);
            this.questionLabel.TabIndex = 39;
            this.questionLabel.Text = "Question";
            // 
            // examTypeLabel
            // 
            this.examTypeLabel.AutoSize = true;
            this.examTypeLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examTypeLabel.ForeColor = System.Drawing.Color.White;
            this.examTypeLabel.Location = new System.Drawing.Point(124, 74);
            this.examTypeLabel.Name = "examTypeLabel";
            this.examTypeLabel.Size = new System.Drawing.Size(86, 17);
            this.examTypeLabel.TabIndex = 38;
            this.examTypeLabel.Text = "Exam Type";
            // 
            // addQuestionLabel
            // 
            this.addQuestionLabel.AutoSize = true;
            this.addQuestionLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.addQuestionLabel.Location = new System.Drawing.Point(160, 0);
            this.addQuestionLabel.Name = "addQuestionLabel";
            this.addQuestionLabel.Size = new System.Drawing.Size(137, 24);
            this.addQuestionLabel.TabIndex = 36;
            this.addQuestionLabel.Text = "Add Question";
            // 
            // formatText
            // 
            this.formatText.Location = new System.Drawing.Point(293, 134);
            this.formatText.Name = "formatText";
            this.formatText.ReadOnly = true;
            this.formatText.Size = new System.Drawing.Size(100, 20);
            this.formatText.TabIndex = 66;
            // 
            // option1Radio
            // 
            this.option1Radio.AutoSize = true;
            this.option1Radio.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Radio.ForeColor = System.Drawing.Color.White;
            this.option1Radio.Location = new System.Drawing.Point(126, 313);
            this.option1Radio.Name = "option1Radio";
            this.option1Radio.Size = new System.Drawing.Size(87, 21);
            this.option1Radio.TabIndex = 67;
            this.option1Radio.TabStop = true;
            this.option1Radio.Text = "Option 1";
            this.option1Radio.UseVisualStyleBackColor = true;
            // 
            // option2Radio
            // 
            this.option2Radio.AutoSize = true;
            this.option2Radio.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Radio.ForeColor = System.Drawing.Color.White;
            this.option2Radio.Location = new System.Drawing.Point(306, 313);
            this.option2Radio.Name = "option2Radio";
            this.option2Radio.Size = new System.Drawing.Size(87, 21);
            this.option2Radio.TabIndex = 68;
            this.option2Radio.TabStop = true;
            this.option2Radio.Text = "Option 2";
            this.option2Radio.UseVisualStyleBackColor = true;
            // 
            // option3Radio
            // 
            this.option3Radio.AutoSize = true;
            this.option3Radio.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Radio.ForeColor = System.Drawing.Color.White;
            this.option3Radio.Location = new System.Drawing.Point(127, 337);
            this.option3Radio.Name = "option3Radio";
            this.option3Radio.Size = new System.Drawing.Size(87, 21);
            this.option3Radio.TabIndex = 69;
            this.option3Radio.TabStop = true;
            this.option3Radio.Text = "Option 3";
            this.option3Radio.UseVisualStyleBackColor = true;
            // 
            // option4Radio
            // 
            this.option4Radio.AutoSize = true;
            this.option4Radio.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4Radio.ForeColor = System.Drawing.Color.White;
            this.option4Radio.Location = new System.Drawing.Point(306, 337);
            this.option4Radio.Name = "option4Radio";
            this.option4Radio.Size = new System.Drawing.Size(87, 21);
            this.option4Radio.TabIndex = 70;
            this.option4Radio.TabStop = true;
            this.option4Radio.Text = "Option 4";
            this.option4Radio.UseVisualStyleBackColor = true;
            // 
            // sectioncomboBox
            // 
            this.sectioncomboBox.FormattingEnabled = true;
            this.sectioncomboBox.Location = new System.Drawing.Point(293, 418);
            this.sectioncomboBox.Name = "sectioncomboBox";
            this.sectioncomboBox.Size = new System.Drawing.Size(121, 21);
            this.sectioncomboBox.TabIndex = 71;
            // 
            // AddSingleChoiceLegend
            // 
            this.AddSingleChoiceLegend.Controls.Add(this.addQuestionLabel);
            this.AddSingleChoiceLegend.Controls.Add(this.sectioncomboBox);
            this.AddSingleChoiceLegend.Controls.Add(this.examTypeLabel);
            this.AddSingleChoiceLegend.Controls.Add(this.option4Radio);
            this.AddSingleChoiceLegend.Controls.Add(this.questionLabel);
            this.AddSingleChoiceLegend.Controls.Add(this.option3Radio);
            this.AddSingleChoiceLegend.Controls.Add(this.option1Label);
            this.AddSingleChoiceLegend.Controls.Add(this.option2Radio);
            this.AddSingleChoiceLegend.Controls.Add(this.option2Label);
            this.AddSingleChoiceLegend.Controls.Add(this.option1Radio);
            this.AddSingleChoiceLegend.Controls.Add(this.option3Label);
            this.AddSingleChoiceLegend.Controls.Add(this.formatText);
            this.AddSingleChoiceLegend.Controls.Add(this.option4Label);
            this.AddSingleChoiceLegend.Controls.Add(this.examTypeCombo);
            this.AddSingleChoiceLegend.Controls.Add(this.solutionLabel);
            this.AddSingleChoiceLegend.Controls.Add(this.marksCombo);
            this.AddSingleChoiceLegend.Controls.Add(this.formatLabel);
            this.AddSingleChoiceLegend.Controls.Add(this.back);
            this.AddSingleChoiceLegend.Controls.Add(this.marksLabel);
            this.AddSingleChoiceLegend.Controls.Add(this.add);
            this.AddSingleChoiceLegend.Controls.Add(this.sectionLabel);
            this.AddSingleChoiceLegend.Controls.Add(this.option4Text);
            this.AddSingleChoiceLegend.Controls.Add(this.questionText);
            this.AddSingleChoiceLegend.Controls.Add(this.option3Text);
            this.AddSingleChoiceLegend.Controls.Add(this.option1Text);
            this.AddSingleChoiceLegend.Controls.Add(this.option2Text);
            this.AddSingleChoiceLegend.Location = new System.Drawing.Point(49, 25);
            this.AddSingleChoiceLegend.Name = "AddSingleChoiceLegend";
            this.AddSingleChoiceLegend.Size = new System.Drawing.Size(511, 513);
            this.AddSingleChoiceLegend.TabIndex = 72;
            this.AddSingleChoiceLegend.TabStop = false;
            this.AddSingleChoiceLegend.Enter += new System.EventHandler(this.AddSingleChoiceLegend_Enter);
            // 
            // AddSingleChoiceQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.AddSingleChoiceLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSingleChoiceQuestion";
            this.Text = "AddSingleChoiceQuestion";
            this.Load += new System.EventHandler(this.AddSingleChoiceQuestion_Load);
            this.AddSingleChoiceLegend.ResumeLayout(false);
            this.AddSingleChoiceLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox examTypeCombo;
        private System.Windows.Forms.ComboBox marksCombo;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox option4Text;
        private System.Windows.Forms.TextBox option3Text;
        private System.Windows.Forms.TextBox option2Text;
        private System.Windows.Forms.TextBox option1Text;
        private System.Windows.Forms.TextBox questionText;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Label marksLabel;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.Label solutionLabel;
        private System.Windows.Forms.Label option4Label;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label examTypeLabel;
        private System.Windows.Forms.Label addQuestionLabel;
        private System.Windows.Forms.TextBox formatText;
        private System.Windows.Forms.RadioButton option1Radio;
        private System.Windows.Forms.RadioButton option2Radio;
        private System.Windows.Forms.RadioButton option3Radio;
        private System.Windows.Forms.RadioButton option4Radio;
        private System.Windows.Forms.ComboBox sectioncomboBox;
        private System.Windows.Forms.GroupBox AddSingleChoiceLegend;
    }
}