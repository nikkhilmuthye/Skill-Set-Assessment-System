namespace WindowsFormsApplication10
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.questionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchTheColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleAnswerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleAnswersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkUploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnExamTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAnExamTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAnExamTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnExamDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAnExamDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAnExamDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addApplicantsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicantsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPaperToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePaperToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePaperToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPaperToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewResultsOfEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewResultsOfExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailedResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questionToolStripMenuItem,
            this.examDetailsToolStripMenuItem,
            this.examDetailsToolStripMenuItem1,
            this.logoutToolStripMenuItem,
            this.applicantsToolStripMenuItem,
            this.paperToolStripMenuItem,
            this.resultsToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.setAdminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(784, 29);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // questionToolStripMenuItem
            // 
            this.questionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAQuestionToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteAQuestionToolStripMenuItem});
            this.questionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.questionToolStripMenuItem.Name = "questionToolStripMenuItem";
            this.questionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.questionToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.questionToolStripMenuItem.Text = "Question";
            // 
            // addAQuestionToolStripMenuItem
            // 
            this.addAQuestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleOptionToolStripMenuItem,
            this.multipleOptionToolStripMenuItem,
            this.matchTheColumnToolStripMenuItem,
            this.pictureQuestionToolStripMenuItem,
            this.bulkUploadToolStripMenuItem});
            this.addAQuestionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addAQuestionToolStripMenuItem.Name = "addAQuestionToolStripMenuItem";
            this.addAQuestionToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.addAQuestionToolStripMenuItem.Text = "Add a Question";
            // 
            // singleOptionToolStripMenuItem
            // 
            this.singleOptionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.singleOptionToolStripMenuItem.Name = "singleOptionToolStripMenuItem";
            this.singleOptionToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.singleOptionToolStripMenuItem.Text = "MCQ (Single Answer)";
            this.singleOptionToolStripMenuItem.Click += new System.EventHandler(this.singleOptionToolStripMenuItem_Click);
            // 
            // multipleOptionToolStripMenuItem
            // 
            this.multipleOptionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.multipleOptionToolStripMenuItem.Name = "multipleOptionToolStripMenuItem";
            this.multipleOptionToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.multipleOptionToolStripMenuItem.Text = "MCQ (Multiple Answers)";
            this.multipleOptionToolStripMenuItem.Click += new System.EventHandler(this.multipleOptionToolStripMenuItem_Click);
            // 
            // matchTheColumnToolStripMenuItem
            // 
            this.matchTheColumnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.matchTheColumnToolStripMenuItem.Name = "matchTheColumnToolStripMenuItem";
            this.matchTheColumnToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.matchTheColumnToolStripMenuItem.Text = "Match The Column";
            this.matchTheColumnToolStripMenuItem.Click += new System.EventHandler(this.matchTheColumnToolStripMenuItem_Click);
            // 
            // pictureQuestionToolStripMenuItem
            // 
            this.pictureQuestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleAnswerToolStripMenuItem,
            this.multipleAnswersToolStripMenuItem});
            this.pictureQuestionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pictureQuestionToolStripMenuItem.Name = "pictureQuestionToolStripMenuItem";
            this.pictureQuestionToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.pictureQuestionToolStripMenuItem.Text = "Picture Question";
            // 
            // singleAnswerToolStripMenuItem
            // 
            this.singleAnswerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.singleAnswerToolStripMenuItem.Name = "singleAnswerToolStripMenuItem";
            this.singleAnswerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.singleAnswerToolStripMenuItem.Text = "Single Answer";
            this.singleAnswerToolStripMenuItem.Click += new System.EventHandler(this.singleAnswerToolStripMenuItem_Click);
            // 
            // multipleAnswersToolStripMenuItem
            // 
            this.multipleAnswersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.multipleAnswersToolStripMenuItem.Name = "multipleAnswersToolStripMenuItem";
            this.multipleAnswersToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.multipleAnswersToolStripMenuItem.Text = "Multiple Answers";
            this.multipleAnswersToolStripMenuItem.Click += new System.EventHandler(this.multipleAnswersToolStripMenuItem_Click);
            // 
            // bulkUploadToolStripMenuItem
            // 
            this.bulkUploadToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bulkUploadToolStripMenuItem.Name = "bulkUploadToolStripMenuItem";
            this.bulkUploadToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.bulkUploadToolStripMenuItem.Text = "Bulk Upload";
            this.bulkUploadToolStripMenuItem.Click += new System.EventHandler(this.bulkUploadToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deleteToolStripMenuItem.Text = "Delete a Question";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteAQuestionToolStripMenuItem_Click);
            // 
            // deleteAQuestionToolStripMenuItem
            // 
            this.deleteAQuestionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteAQuestionToolStripMenuItem.Name = "deleteAQuestionToolStripMenuItem";
            this.deleteAQuestionToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deleteAQuestionToolStripMenuItem.Text = "Update a Question";
            this.deleteAQuestionToolStripMenuItem.Click += new System.EventHandler(this.updateAQuestionToolStripMenuItem_Click);
            // 
            // examDetailsToolStripMenuItem
            // 
            this.examDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAnExamTypeToolStripMenuItem,
            this.updateAnExamTypeToolStripMenuItem,
            this.deleteAnExamTypeToolStripMenuItem});
            this.examDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.examDetailsToolStripMenuItem.Name = "examDetailsToolStripMenuItem";
            this.examDetailsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.examDetailsToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.examDetailsToolStripMenuItem.Text = "Exam Type";
            // 
            // addAnExamTypeToolStripMenuItem
            // 
            this.addAnExamTypeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addAnExamTypeToolStripMenuItem.Name = "addAnExamTypeToolStripMenuItem";
            this.addAnExamTypeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addAnExamTypeToolStripMenuItem.Text = "Add an Exam Type";
            this.addAnExamTypeToolStripMenuItem.Click += new System.EventHandler(this.addAnExamTypeToolStripMenuItem_Click);
            // 
            // updateAnExamTypeToolStripMenuItem
            // 
            this.updateAnExamTypeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.updateAnExamTypeToolStripMenuItem.Name = "updateAnExamTypeToolStripMenuItem";
            this.updateAnExamTypeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.updateAnExamTypeToolStripMenuItem.Text = "Delete an Exam Type";
            this.updateAnExamTypeToolStripMenuItem.Click += new System.EventHandler(this.deleteAnExamTypeToolStripMenuItem_Click);
            // 
            // deleteAnExamTypeToolStripMenuItem
            // 
            this.deleteAnExamTypeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteAnExamTypeToolStripMenuItem.Name = "deleteAnExamTypeToolStripMenuItem";
            this.deleteAnExamTypeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deleteAnExamTypeToolStripMenuItem.Text = "Update an Exam Type";
            this.deleteAnExamTypeToolStripMenuItem.Click += new System.EventHandler(this.updateAnExamTypeToolStripMenuItem_Click);
            // 
            // examDetailsToolStripMenuItem1
            // 
            this.examDetailsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAnExamDetailsToolStripMenuItem,
            this.deleteAnExamDetailsToolStripMenuItem,
            this.updateAnExamDetailsToolStripMenuItem});
            this.examDetailsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.examDetailsToolStripMenuItem1.Name = "examDetailsToolStripMenuItem1";
            this.examDetailsToolStripMenuItem1.ShortcutKeyDisplayString = "Alt+D";
            this.examDetailsToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.examDetailsToolStripMenuItem1.Size = new System.Drawing.Size(80, 25);
            this.examDetailsToolStripMenuItem1.Text = "Exam Details";
            // 
            // addAnExamDetailsToolStripMenuItem
            // 
            this.addAnExamDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addAnExamDetailsToolStripMenuItem.Name = "addAnExamDetailsToolStripMenuItem";
            this.addAnExamDetailsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addAnExamDetailsToolStripMenuItem.Text = "Add an Exam Details";
            this.addAnExamDetailsToolStripMenuItem.Click += new System.EventHandler(this.addAnExamDetailsToolStripMenuItem_Click);
            // 
            // deleteAnExamDetailsToolStripMenuItem
            // 
            this.deleteAnExamDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteAnExamDetailsToolStripMenuItem.Name = "deleteAnExamDetailsToolStripMenuItem";
            this.deleteAnExamDetailsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.deleteAnExamDetailsToolStripMenuItem.Text = "Delete an Exam Details";
            this.deleteAnExamDetailsToolStripMenuItem.Click += new System.EventHandler(this.deleteAnExamDetailsToolStripMenuItem_Click);
            // 
            // updateAnExamDetailsToolStripMenuItem
            // 
            this.updateAnExamDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.updateAnExamDetailsToolStripMenuItem.Name = "updateAnExamDetailsToolStripMenuItem";
            this.updateAnExamDetailsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.updateAnExamDetailsToolStripMenuItem.Text = "Update an Exam Details";
            this.updateAnExamDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateAnExamDetailsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // applicantsToolStripMenuItem
            // 
            this.applicantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addApplicantsToolStripMenuItem1,
            this.deleteApplicantsToolStripMenuItem1});
            this.applicantsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.applicantsToolStripMenuItem.Name = "applicantsToolStripMenuItem";
            this.applicantsToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.applicantsToolStripMenuItem.Text = "Applicants";
            // 
            // addApplicantsToolStripMenuItem1
            // 
            this.addApplicantsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addApplicantsToolStripMenuItem1.Name = "addApplicantsToolStripMenuItem1";
            this.addApplicantsToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.addApplicantsToolStripMenuItem1.Text = "Add Applicants";
            this.addApplicantsToolStripMenuItem1.Click += new System.EventHandler(this.addApplicantsToolStripMenuItem_Click);
            // 
            // deleteApplicantsToolStripMenuItem1
            // 
            this.deleteApplicantsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteApplicantsToolStripMenuItem1.Name = "deleteApplicantsToolStripMenuItem1";
            this.deleteApplicantsToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.deleteApplicantsToolStripMenuItem1.Text = "Delete Applicants";
            this.deleteApplicantsToolStripMenuItem1.Click += new System.EventHandler(this.deleteApplicantsToolStripMenuItem_Click);
            // 
            // paperToolStripMenuItem
            // 
            this.paperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPaperToolStripMenuItem2,
            this.updatePaperToolStripMenuItem1,
            this.deletePaperToolStripMenuItem1,
            this.viewPaperToolStripMenuItem1});
            this.paperToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paperToolStripMenuItem.Name = "paperToolStripMenuItem";
            this.paperToolStripMenuItem.Size = new System.Drawing.Size(47, 25);
            this.paperToolStripMenuItem.Text = "Paper";
            // 
            // setPaperToolStripMenuItem2
            // 
            this.setPaperToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.setPaperToolStripMenuItem2.Name = "setPaperToolStripMenuItem2";
            this.setPaperToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.setPaperToolStripMenuItem2.Text = "Set Paper";
            this.setPaperToolStripMenuItem2.Click += new System.EventHandler(this.setPaperToolStripMenuItem1_Click);
            // 
            // updatePaperToolStripMenuItem1
            // 
            this.updatePaperToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.updatePaperToolStripMenuItem1.Name = "updatePaperToolStripMenuItem1";
            this.updatePaperToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.updatePaperToolStripMenuItem1.Text = "Update Paper";
            this.updatePaperToolStripMenuItem1.Click += new System.EventHandler(this.updatePaperToolStripMenuItem_Click);
            // 
            // deletePaperToolStripMenuItem1
            // 
            this.deletePaperToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deletePaperToolStripMenuItem1.Name = "deletePaperToolStripMenuItem1";
            this.deletePaperToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deletePaperToolStripMenuItem1.Text = "Delete Paper";
            this.deletePaperToolStripMenuItem1.Click += new System.EventHandler(this.deletePaperToolStripMenuItem_Click);
            // 
            // viewPaperToolStripMenuItem1
            // 
            this.viewPaperToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.viewPaperToolStripMenuItem1.Name = "viewPaperToolStripMenuItem1";
            this.viewPaperToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.viewPaperToolStripMenuItem1.Text = "View Paper";
            this.viewPaperToolStripMenuItem1.Click += new System.EventHandler(this.viewPaperToolStripMenuItem_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewResultsOfEmployeeToolStripMenuItem,
            this.viewResultsOfExamToolStripMenuItem,
            this.detailedResultToolStripMenuItem});
            this.resultsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.resultsToolStripMenuItem.Text = "View Results";
            // 
            // viewResultsOfEmployeeToolStripMenuItem
            // 
            this.viewResultsOfEmployeeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.viewResultsOfEmployeeToolStripMenuItem.Name = "viewResultsOfEmployeeToolStripMenuItem";
            this.viewResultsOfEmployeeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.viewResultsOfEmployeeToolStripMenuItem.Text = "View Results of Employee";
            this.viewResultsOfEmployeeToolStripMenuItem.Click += new System.EventHandler(this.viewResultsOfEmployeeToolStripMenuItem_Click);
            // 
            // viewResultsOfExamToolStripMenuItem
            // 
            this.viewResultsOfExamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.viewResultsOfExamToolStripMenuItem.Name = "viewResultsOfExamToolStripMenuItem";
            this.viewResultsOfExamToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.viewResultsOfExamToolStripMenuItem.Text = "View Results of Exam";
            this.viewResultsOfExamToolStripMenuItem.Click += new System.EventHandler(this.viewResultsOfExamToolStripMenuItem_Click);
            // 
            // detailedResultToolStripMenuItem
            // 
            this.detailedResultToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.detailedResultToolStripMenuItem.Name = "detailedResultToolStripMenuItem";
            this.detailedResultToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.detailedResultToolStripMenuItem.Text = "Reports";
            this.detailedResultToolStripMenuItem.Click += new System.EventHandler(this.detailedResultToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(105, 25);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // setAdminToolStripMenuItem
            // 
            this.setAdminToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.setAdminToolStripMenuItem.Name = "setAdminToolStripMenuItem";
            this.setAdminToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.setAdminToolStripMenuItem.Text = "Set Admin";
            this.setAdminToolStripMenuItem.Click += new System.EventHandler(this.setAdminToolStripMenuItem_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminHome";
            this.Text = "Skill Set Assessment System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem questionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addAQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnExamTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAnExamTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAnExamTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnExamDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAnExamDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAnExamDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchTheColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addApplicantsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicantsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem paperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPaperToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem updatePaperToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletePaperToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewPaperToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleAnswerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleAnswersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulkUploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewResultsOfEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewResultsOfExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailedResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAdminToolStripMenuItem;
    }
}