namespace WindowsFormsApplication10
{
    partial class Result
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
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.congratulationsLabel = new System.Windows.Forms.Label();
            this.proceed = new System.Windows.Forms.Button();
            this.examLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.ForeColor = System.Drawing.Color.White;
            this.employeeNameLabel.Location = new System.Drawing.Point(124, 70);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(119, 17);
            this.employeeNameLabel.TabIndex = 0;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // congratulationsLabel
            // 
            this.congratulationsLabel.AutoSize = true;
            this.congratulationsLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratulationsLabel.ForeColor = System.Drawing.Color.White;
            this.congratulationsLabel.Location = new System.Drawing.Point(726, 318);
            this.congratulationsLabel.Name = "congratulationsLabel";
            this.congratulationsLabel.Size = new System.Drawing.Size(133, 68);
            this.congratulationsLabel.TabIndex = 1;
            this.congratulationsLabel.Text = "Congratulations !\r\nYou have secured\r\n------- marks in\r\n     *Exam ID*.";
            // 
            // proceed
            // 
            this.proceed.BackColor = System.Drawing.Color.White;
            this.proceed.Location = new System.Drawing.Point(763, 453);
            this.proceed.Name = "proceed";
            this.proceed.Size = new System.Drawing.Size(70, 30);
            this.proceed.TabIndex = 2;
            this.proceed.Text = "Proceed";
            this.proceed.UseVisualStyleBackColor = false;
            this.proceed.Click += new System.EventHandler(this.proceed_Click);
            // 
            // examLabel
            // 
            this.examLabel.AutoSize = true;
            this.examLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examLabel.ForeColor = System.Drawing.Color.White;
            this.examLabel.Location = new System.Drawing.Point(124, 122);
            this.examLabel.Name = "examLabel";
            this.examLabel.Size = new System.Drawing.Size(47, 17);
            this.examLabel.TabIndex = 3;
            this.examLabel.Text = "Exam";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1574, 655);
            this.ControlBox = false;
            this.Controls.Add(this.examLabel);
            this.Controls.Add(this.proceed);
            this.Controls.Add(this.congratulationsLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Result";
            this.Text = "Skill Set Assessment System";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label congratulationsLabel;
        private System.Windows.Forms.Button proceed;
        private System.Windows.Forms.Label examLabel;
    }
}