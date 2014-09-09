namespace WindowsFormsApplication10
{
    partial class UpdateMultipleChoiceQuestions
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
            this.formatText = new System.Windows.Forms.TextBox();
            this.option4CheckBox = new System.Windows.Forms.CheckBox();
            this.option3CheckBox = new System.Windows.Forms.CheckBox();
            this.option2CheckBox = new System.Windows.Forms.CheckBox();
            this.option1CheckBox = new System.Windows.Forms.CheckBox();
            this.examTypeCombo = new System.Windows.Forms.ComboBox();
            this.marksCombo = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.option4Text = new System.Windows.Forms.TextBox();
            this.option3Text = new System.Windows.Forms.TextBox();
            this.option2Text = new System.Windows.Forms.TextBox();
            this.option1Text = new System.Windows.Forms.TextBox();
            this.questionText = new System.Windows.Forms.TextBox();
            this.questionIDText = new System.Windows.Forms.TextBox();
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
            this.questionIDLabel = new System.Windows.Forms.Label();
            this.updateQuestionLabel = new System.Windows.Forms.Label();
            this.sectioncomboBox = new System.Windows.Forms.ComboBox();
            this.updateQuestionLegend = new System.Windows.Forms.GroupBox();
            this.updateQuestionLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // formatText
            // 
            this.formatText.Location = new System.Drawing.Point(289, 143);
            this.formatText.Name = "formatText";
            this.formatText.ReadOnly = true;
            this.formatText.Size = new System.Drawing.Size(100, 20);
            this.formatText.TabIndex = 90;
            // 
            // option4CheckBox
            // 
            this.option4CheckBox.AutoSize = true;
            this.option4CheckBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4CheckBox.ForeColor = System.Drawing.Color.White;
            this.option4CheckBox.Location = new System.Drawing.Point(319, 355);
            this.option4CheckBox.Name = "option4CheckBox";
            this.option4CheckBox.Size = new System.Drawing.Size(88, 21);
            this.option4CheckBox.TabIndex = 13;
            this.option4CheckBox.Text = "Option 4";
            this.option4CheckBox.UseVisualStyleBackColor = true;
            // 
            // option3CheckBox
            // 
            this.option3CheckBox.AutoSize = true;
            this.option3CheckBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3CheckBox.ForeColor = System.Drawing.Color.White;
            this.option3CheckBox.Location = new System.Drawing.Point(76, 355);
            this.option3CheckBox.Name = "option3CheckBox";
            this.option3CheckBox.Size = new System.Drawing.Size(88, 21);
            this.option3CheckBox.TabIndex = 88;
            this.option3CheckBox.Text = "Option 3";
            this.option3CheckBox.UseVisualStyleBackColor = true;
            // 
            // option2CheckBox
            // 
            this.option2CheckBox.AutoSize = true;
            this.option2CheckBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2CheckBox.ForeColor = System.Drawing.Color.White;
            this.option2CheckBox.Location = new System.Drawing.Point(319, 328);
            this.option2CheckBox.Name = "option2CheckBox";
            this.option2CheckBox.Size = new System.Drawing.Size(88, 21);
            this.option2CheckBox.TabIndex = 87;
            this.option2CheckBox.Text = "Option 2";
            this.option2CheckBox.UseVisualStyleBackColor = true;
            // 
            // option1CheckBox
            // 
            this.option1CheckBox.AutoSize = true;
            this.option1CheckBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1CheckBox.ForeColor = System.Drawing.Color.White;
            this.option1CheckBox.Location = new System.Drawing.Point(76, 328);
            this.option1CheckBox.Name = "option1CheckBox";
            this.option1CheckBox.Size = new System.Drawing.Size(88, 21);
            this.option1CheckBox.TabIndex = 86;
            this.option1CheckBox.Text = "Option 1";
            this.option1CheckBox.UseVisualStyleBackColor = true;
            // 
            // examTypeCombo
            // 
            this.examTypeCombo.FormattingEnabled = true;
            this.examTypeCombo.Location = new System.Drawing.Point(289, 75);
            this.examTypeCombo.Name = "examTypeCombo";
            this.examTypeCombo.Size = new System.Drawing.Size(100, 21);
            this.examTypeCombo.TabIndex = 85;
            // 
            // marksCombo
            // 
            this.marksCombo.FormattingEnabled = true;
            this.marksCombo.Location = new System.Drawing.Point(289, 391);
            this.marksCombo.Name = "marksCombo";
            this.marksCombo.Size = new System.Drawing.Size(100, 21);
            this.marksCombo.TabIndex = 12;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(136, 457);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 83;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(319, 457);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(70, 30);
            this.update.TabIndex = 8;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // option4Text
            // 
            this.option4Text.Location = new System.Drawing.Point(289, 272);
            this.option4Text.Name = "option4Text";
            this.option4Text.Size = new System.Drawing.Size(100, 20);
            this.option4Text.TabIndex = 80;
            // 
            // option3Text
            // 
            this.option3Text.Location = new System.Drawing.Point(289, 242);
            this.option3Text.Name = "option3Text";
            this.option3Text.Size = new System.Drawing.Size(100, 20);
            this.option3Text.TabIndex = 79;
            // 
            // option2Text
            // 
            this.option2Text.Location = new System.Drawing.Point(289, 209);
            this.option2Text.Name = "option2Text";
            this.option2Text.Size = new System.Drawing.Size(100, 20);
            this.option2Text.TabIndex = 78;
            // 
            // option1Text
            // 
            this.option1Text.Location = new System.Drawing.Point(289, 176);
            this.option1Text.Name = "option1Text";
            this.option1Text.Size = new System.Drawing.Size(100, 20);
            this.option1Text.TabIndex = 77;
            // 
            // questionText
            // 
            this.questionText.Location = new System.Drawing.Point(289, 110);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(100, 20);
            this.questionText.TabIndex = 76;
            // 
            // questionIDText
            // 
            this.questionIDText.Location = new System.Drawing.Point(289, 43);
            this.questionIDText.Name = "questionIDText";
            this.questionIDText.ReadOnly = true;
            this.questionIDText.Size = new System.Drawing.Size(100, 20);
            this.questionIDText.TabIndex = 75;
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionLabel.ForeColor = System.Drawing.Color.White;
            this.sectionLabel.Location = new System.Drawing.Point(78, 425);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(60, 17);
            this.sectionLabel.TabIndex = 74;
            this.sectionLabel.Text = "Section";
            // 
            // marksLabel
            // 
            this.marksLabel.AutoSize = true;
            this.marksLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksLabel.ForeColor = System.Drawing.Color.White;
            this.marksLabel.Location = new System.Drawing.Point(78, 391);
            this.marksLabel.Name = "marksLabel";
            this.marksLabel.Size = new System.Drawing.Size(49, 17);
            this.marksLabel.TabIndex = 73;
            this.marksLabel.Text = "Marks";
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatLabel.ForeColor = System.Drawing.Color.White;
            this.formatLabel.Location = new System.Drawing.Point(78, 143);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(58, 17);
            this.formatLabel.TabIndex = 72;
            this.formatLabel.Text = "Format";
            // 
            // solutionLabel
            // 
            this.solutionLabel.AutoSize = true;
            this.solutionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionLabel.ForeColor = System.Drawing.Color.White;
            this.solutionLabel.Location = new System.Drawing.Point(191, 305);
            this.solutionLabel.Name = "solutionLabel";
            this.solutionLabel.Size = new System.Drawing.Size(66, 17);
            this.solutionLabel.TabIndex = 71;
            this.solutionLabel.Text = "Solution";
            // 
            // option4Label
            // 
            this.option4Label.AutoSize = true;
            this.option4Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4Label.ForeColor = System.Drawing.Color.White;
            this.option4Label.Location = new System.Drawing.Point(78, 272);
            this.option4Label.Name = "option4Label";
            this.option4Label.Size = new System.Drawing.Size(69, 17);
            this.option4Label.TabIndex = 70;
            this.option4Label.Text = "Option 4";
            // 
            // option3Label
            // 
            this.option3Label.AutoSize = true;
            this.option3Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.ForeColor = System.Drawing.Color.White;
            this.option3Label.Location = new System.Drawing.Point(78, 242);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(69, 17);
            this.option3Label.TabIndex = 69;
            this.option3Label.Text = "Option 3";
            // 
            // option2Label
            // 
            this.option2Label.AutoSize = true;
            this.option2Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(78, 209);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(69, 17);
            this.option2Label.TabIndex = 68;
            this.option2Label.Text = "Option 2";
            // 
            // option1Label
            // 
            this.option1Label.AutoSize = true;
            this.option1Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(78, 176);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(69, 17);
            this.option1Label.TabIndex = 67;
            this.option1Label.Text = "Option 1";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(78, 110);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(71, 17);
            this.questionLabel.TabIndex = 66;
            this.questionLabel.Text = "Question";
            // 
            // examTypeLabel
            // 
            this.examTypeLabel.AutoSize = true;
            this.examTypeLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examTypeLabel.ForeColor = System.Drawing.Color.White;
            this.examTypeLabel.Location = new System.Drawing.Point(78, 75);
            this.examTypeLabel.Name = "examTypeLabel";
            this.examTypeLabel.Size = new System.Drawing.Size(86, 17);
            this.examTypeLabel.TabIndex = 65;
            this.examTypeLabel.Text = "Exam Type";
            // 
            // questionIDLabel
            // 
            this.questionIDLabel.AutoSize = true;
            this.questionIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionIDLabel.ForeColor = System.Drawing.Color.White;
            this.questionIDLabel.Location = new System.Drawing.Point(78, 43);
            this.questionIDLabel.Name = "questionIDLabel";
            this.questionIDLabel.Size = new System.Drawing.Size(92, 17);
            this.questionIDLabel.TabIndex = 64;
            this.questionIDLabel.Text = "Question ID";
            // 
            // updateQuestionLabel
            // 
            this.updateQuestionLabel.AutoSize = true;
            this.updateQuestionLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.updateQuestionLabel.Location = new System.Drawing.Point(171, 0);
            this.updateQuestionLabel.Name = "updateQuestionLabel";
            this.updateQuestionLabel.Size = new System.Drawing.Size(164, 24);
            this.updateQuestionLabel.TabIndex = 63;
            this.updateQuestionLabel.Text = "Update Question";
            // 
            // sectioncomboBox
            // 
            this.sectioncomboBox.FormattingEnabled = true;
            this.sectioncomboBox.Location = new System.Drawing.Point(286, 421);
            this.sectioncomboBox.Name = "sectioncomboBox";
            this.sectioncomboBox.Size = new System.Drawing.Size(121, 21);
            this.sectioncomboBox.TabIndex = 91;
            // 
            // updateQuestionLegend
            // 
            this.updateQuestionLegend.Controls.Add(this.updateQuestionLabel);
            this.updateQuestionLegend.Controls.Add(this.sectioncomboBox);
            this.updateQuestionLegend.Controls.Add(this.questionIDLabel);
            this.updateQuestionLegend.Controls.Add(this.formatText);
            this.updateQuestionLegend.Controls.Add(this.examTypeLabel);
            this.updateQuestionLegend.Controls.Add(this.option4CheckBox);
            this.updateQuestionLegend.Controls.Add(this.questionLabel);
            this.updateQuestionLegend.Controls.Add(this.option3CheckBox);
            this.updateQuestionLegend.Controls.Add(this.option1Label);
            this.updateQuestionLegend.Controls.Add(this.option2CheckBox);
            this.updateQuestionLegend.Controls.Add(this.option2Label);
            this.updateQuestionLegend.Controls.Add(this.option1CheckBox);
            this.updateQuestionLegend.Controls.Add(this.option3Label);
            this.updateQuestionLegend.Controls.Add(this.examTypeCombo);
            this.updateQuestionLegend.Controls.Add(this.option4Label);
            this.updateQuestionLegend.Controls.Add(this.marksCombo);
            this.updateQuestionLegend.Controls.Add(this.solutionLabel);
            this.updateQuestionLegend.Controls.Add(this.back);
            this.updateQuestionLegend.Controls.Add(this.formatLabel);
            this.updateQuestionLegend.Controls.Add(this.update);
            this.updateQuestionLegend.Controls.Add(this.marksLabel);
            this.updateQuestionLegend.Controls.Add(this.option4Text);
            this.updateQuestionLegend.Controls.Add(this.sectionLabel);
            this.updateQuestionLegend.Controls.Add(this.option3Text);
            this.updateQuestionLegend.Controls.Add(this.questionIDText);
            this.updateQuestionLegend.Controls.Add(this.option2Text);
            this.updateQuestionLegend.Controls.Add(this.questionText);
            this.updateQuestionLegend.Controls.Add(this.option1Text);
            this.updateQuestionLegend.Location = new System.Drawing.Point(78, 13);
            this.updateQuestionLegend.Name = "updateQuestionLegend";
            this.updateQuestionLegend.Size = new System.Drawing.Size(493, 506);
            this.updateQuestionLegend.TabIndex = 92;
            this.updateQuestionLegend.TabStop = false;
            // 
            // UpdateMultipleChoiceQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.updateQuestionLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateMultipleChoiceQuestions";
            this.Text = "Update Questions";
            this.Load += new System.EventHandler(this.UpdateMultipleChoiceQuestions_Load);
            this.updateQuestionLegend.ResumeLayout(false);
            this.updateQuestionLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox formatText;
        private System.Windows.Forms.CheckBox option4CheckBox;
        private System.Windows.Forms.CheckBox option3CheckBox;
        private System.Windows.Forms.CheckBox option2CheckBox;
        private System.Windows.Forms.CheckBox option1CheckBox;
        private System.Windows.Forms.ComboBox examTypeCombo;
        private System.Windows.Forms.ComboBox marksCombo;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox option4Text;
        private System.Windows.Forms.TextBox option3Text;
        private System.Windows.Forms.TextBox option2Text;
        private System.Windows.Forms.TextBox option1Text;
        private System.Windows.Forms.TextBox questionText;
        private System.Windows.Forms.TextBox questionIDText;
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
        private System.Windows.Forms.Label questionIDLabel;
        private System.Windows.Forms.Label updateQuestionLabel;
        private System.Windows.Forms.ComboBox sectioncomboBox;
        private System.Windows.Forms.GroupBox updateQuestionLegend;
    }
}