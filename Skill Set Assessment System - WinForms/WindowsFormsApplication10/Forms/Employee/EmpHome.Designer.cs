namespace WindowsFormsApplication10
{
    partial class EmpHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpHome));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.examIDLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.examTypeLabel = new System.Windows.Forms.Label();
            this.skipTutorial = new System.Windows.Forms.Button();
            this.takeTutorial = new System.Windows.Forms.Button();
            this.tutorialDescLabel = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.todaysScheduleLabel = new System.Windows.Forms.Label();
            this.tutorialGroupBox = new System.Windows.Forms.GroupBox();
            this.tutorialLabel = new System.Windows.Forms.Label();
            this.todayScheduleGroupBox = new System.Windows.Forms.GroupBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.schedulePanel.SuspendLayout();
            this.tutorialGroupBox.SuspendLayout();
            this.todayScheduleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(54, 35);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(71, 17);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(16, 16);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(70, 13);
            this.examIDLabel.TabIndex = 3;
            this.examIDLabel.Text = "Exam ID:  ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(16, 69);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(47, 13);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Date:  ";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel.ForeColor = System.Drawing.Color.White;
            this.durationLabel.Location = new System.Drawing.Point(16, 93);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(69, 13);
            this.durationLabel.TabIndex = 5;
            this.durationLabel.Text = "Duration:  ";
            // 
            // schedulePanel
            // 
            this.schedulePanel.Controls.Add(this.examTypeLabel);
            this.schedulePanel.Controls.Add(this.examIDLabel);
            this.schedulePanel.Controls.Add(this.durationLabel);
            this.schedulePanel.Controls.Add(this.dateLabel);
            this.schedulePanel.Location = new System.Drawing.Point(32, 64);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Size = new System.Drawing.Size(246, 130);
            this.schedulePanel.TabIndex = 6;
            // 
            // examTypeLabel
            // 
            this.examTypeLabel.AutoSize = true;
            this.examTypeLabel.ForeColor = System.Drawing.Color.White;
            this.examTypeLabel.Location = new System.Drawing.Point(16, 43);
            this.examTypeLabel.Name = "examTypeLabel";
            this.examTypeLabel.Size = new System.Drawing.Size(63, 13);
            this.examTypeLabel.TabIndex = 6;
            this.examTypeLabel.Text = "Exam Type:";
            // 
            // skipTutorial
            // 
            this.skipTutorial.BackColor = System.Drawing.Color.White;
            this.skipTutorial.Location = new System.Drawing.Point(296, 228);
            this.skipTutorial.Name = "skipTutorial";
            this.skipTutorial.Size = new System.Drawing.Size(100, 30);
            this.skipTutorial.TabIndex = 7;
            this.skipTutorial.Text = "Skip Tutorials";
            this.skipTutorial.UseVisualStyleBackColor = false;
            this.skipTutorial.Click += new System.EventHandler(this.skipTutorial_Click);
            // 
            // takeTutorial
            // 
            this.takeTutorial.BackColor = System.Drawing.Color.White;
            this.takeTutorial.Location = new System.Drawing.Point(32, 219);
            this.takeTutorial.Name = "takeTutorial";
            this.takeTutorial.Size = new System.Drawing.Size(100, 30);
            this.takeTutorial.TabIndex = 8;
            this.takeTutorial.Text = "Take Tutorial";
            this.takeTutorial.UseVisualStyleBackColor = false;
            this.takeTutorial.Click += new System.EventHandler(this.takeTutorial_Click);
            // 
            // tutorialDescLabel
            // 
            this.tutorialDescLabel.AutoSize = true;
            this.tutorialDescLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialDescLabel.ForeColor = System.Drawing.Color.White;
            this.tutorialDescLabel.Location = new System.Drawing.Point(95, 78);
            this.tutorialDescLabel.Name = "tutorialDescLabel";
            this.tutorialDescLabel.Size = new System.Drawing.Size(301, 102);
            this.tutorialDescLabel.TabIndex = 9;
            this.tutorialDescLabel.Text = resources.GetString("tutorialDescLabel.Text");
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(1381, 28);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(70, 30);
            this.logout.TabIndex = 10;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // changePassword
            // 
            this.changePassword.BackColor = System.Drawing.Color.White;
            this.changePassword.Location = new System.Drawing.Point(1229, 28);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(125, 30);
            this.changePassword.TabIndex = 11;
            this.changePassword.Text = "Change Password";
            this.changePassword.UseVisualStyleBackColor = false;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // todaysScheduleLabel
            // 
            this.todaysScheduleLabel.AutoSize = true;
            this.todaysScheduleLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaysScheduleLabel.ForeColor = System.Drawing.Color.White;
            this.todaysScheduleLabel.Location = new System.Drawing.Point(73, 22);
            this.todaysScheduleLabel.Name = "todaysScheduleLabel";
            this.todaysScheduleLabel.Size = new System.Drawing.Size(175, 17);
            this.todaysScheduleLabel.TabIndex = 2;
            this.todaysScheduleLabel.Text = "Today\'s Exam Schedule";
            // 
            // tutorialGroupBox
            // 
            this.tutorialGroupBox.Controls.Add(this.tutorialLabel);
            this.tutorialGroupBox.Controls.Add(this.tutorialDescLabel);
            this.tutorialGroupBox.Controls.Add(this.takeTutorial);
            this.tutorialGroupBox.Controls.Add(this.skipTutorial);
            this.tutorialGroupBox.Location = new System.Drawing.Point(169, 174);
            this.tutorialGroupBox.Name = "tutorialGroupBox";
            this.tutorialGroupBox.Size = new System.Drawing.Size(470, 328);
            this.tutorialGroupBox.TabIndex = 12;
            this.tutorialGroupBox.TabStop = false;
            // 
            // tutorialLabel
            // 
            this.tutorialLabel.AutoSize = true;
            this.tutorialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tutorialLabel.Location = new System.Drawing.Point(110, 17);
            this.tutorialLabel.Name = "tutorialLabel";
            this.tutorialLabel.Size = new System.Drawing.Size(72, 24);
            this.tutorialLabel.TabIndex = 10;
            this.tutorialLabel.Text = "Tutorial";
            // 
            // todayScheduleGroupBox
            // 
            this.todayScheduleGroupBox.Controls.Add(this.noteLabel);
            this.todayScheduleGroupBox.Controls.Add(this.todaysScheduleLabel);
            this.todayScheduleGroupBox.Controls.Add(this.schedulePanel);
            this.todayScheduleGroupBox.Location = new System.Drawing.Point(873, 174);
            this.todayScheduleGroupBox.Name = "todayScheduleGroupBox";
            this.todayScheduleGroupBox.Size = new System.Drawing.Size(369, 328);
            this.todayScheduleGroupBox.TabIndex = 13;
            this.todayScheduleGroupBox.TabStop = false;
            this.todayScheduleGroupBox.Enter += new System.EventHandler(this.todayScheduleGroupBox_Enter);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.ForeColor = System.Drawing.Color.White;
            this.noteLabel.Location = new System.Drawing.Point(48, 228);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(33, 13);
            this.noteLabel.TabIndex = 7;
            this.noteLabel.Text = "Note:";
            // 
            // EmpHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1551, 675);
            this.ControlBox = false;
            this.Controls.Add(this.todayScheduleGroupBox);
            this.Controls.Add(this.tutorialGroupBox);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmpHome";
            this.Text = "Skill Set Assessment System";
            this.Load += new System.EventHandler(this.EmpHome_Load);
            this.schedulePanel.ResumeLayout(false);
            this.schedulePanel.PerformLayout();
            this.tutorialGroupBox.ResumeLayout(false);
            this.tutorialGroupBox.PerformLayout();
            this.todayScheduleGroupBox.ResumeLayout(false);
            this.todayScheduleGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Panel schedulePanel;
        private System.Windows.Forms.Button skipTutorial;
        private System.Windows.Forms.Button takeTutorial;
        private System.Windows.Forms.Label tutorialDescLabel;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.Label todaysScheduleLabel;
        private System.Windows.Forms.GroupBox tutorialGroupBox;
        private System.Windows.Forms.Label tutorialLabel;
        private System.Windows.Forms.GroupBox todayScheduleGroupBox;
        private System.Windows.Forms.Label examTypeLabel;
        private System.Windows.Forms.Label noteLabel;
    }
}