namespace WindowsFormsApplication10
{
    partial class PictureQuestionSingleAns
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
            this.components = new System.ComponentModel.Container();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.option1Radio = new System.Windows.Forms.RadioButton();
            this.option2Radio = new System.Windows.Forms.RadioButton();
            this.option3Radio = new System.Windows.Forms.RadioButton();
            this.option4Radio = new System.Windows.Forms.RadioButton();
            this.timeLabel = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeBookmark = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.bookmarkGrid = new System.Windows.Forms.DataGridView();
            this.submit = new System.Windows.Forms.Button();
            this.examIDLabel = new System.Windows.Forms.Label();
            this.bookmark = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionNoLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.option1Radio);
            this.optionsPanel.Controls.Add(this.option2Radio);
            this.optionsPanel.Controls.Add(this.option3Radio);
            this.optionsPanel.Controls.Add(this.option4Radio);
            this.optionsPanel.Location = new System.Drawing.Point(374, 184);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(264, 187);
            this.optionsPanel.TabIndex = 34;
            // 
            // option1Radio
            // 
            this.option1Radio.AutoSize = true;
            this.option1Radio.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Radio.ForeColor = System.Drawing.Color.White;
            this.option1Radio.Location = new System.Drawing.Point(12, 3);
            this.option1Radio.Name = "option1Radio";
            this.option1Radio.Size = new System.Drawing.Size(36, 21);
            this.option1Radio.TabIndex = 7;
            this.option1Radio.TabStop = true;
            this.option1Radio.Text = "A";
            this.option1Radio.UseVisualStyleBackColor = true;
            // 
            // option2Radio
            // 
            this.option2Radio.AutoSize = true;
            this.option2Radio.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Radio.ForeColor = System.Drawing.Color.White;
            this.option2Radio.Location = new System.Drawing.Point(12, 42);
            this.option2Radio.Name = "option2Radio";
            this.option2Radio.Size = new System.Drawing.Size(36, 21);
            this.option2Radio.TabIndex = 8;
            this.option2Radio.TabStop = true;
            this.option2Radio.Text = "B";
            this.option2Radio.UseVisualStyleBackColor = true;
            // 
            // option3Radio
            // 
            this.option3Radio.AutoSize = true;
            this.option3Radio.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Radio.ForeColor = System.Drawing.Color.White;
            this.option3Radio.Location = new System.Drawing.Point(12, 85);
            this.option3Radio.Name = "option3Radio";
            this.option3Radio.Size = new System.Drawing.Size(36, 21);
            this.option3Radio.TabIndex = 9;
            this.option3Radio.TabStop = true;
            this.option3Radio.Text = "C";
            this.option3Radio.UseVisualStyleBackColor = true;
            // 
            // option4Radio
            // 
            this.option4Radio.AutoSize = true;
            this.option4Radio.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4Radio.ForeColor = System.Drawing.Color.White;
            this.option4Radio.Location = new System.Drawing.Point(12, 131);
            this.option4Radio.Name = "option4Radio";
            this.option4Radio.Size = new System.Drawing.Size(37, 21);
            this.option4Radio.TabIndex = 10;
            this.option4Radio.TabStop = true;
            this.option4Radio.Text = "D";
            this.option4Radio.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(1172, 50);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 17);
            this.timeLabel.TabIndex = 33;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bookmark";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Question_No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // removeBookmark
            // 
            this.removeBookmark.BackColor = System.Drawing.Color.White;
            this.removeBookmark.Location = new System.Drawing.Point(957, 341);
            this.removeBookmark.Name = "removeBookmark";
            this.removeBookmark.Size = new System.Drawing.Size(125, 30);
            this.removeBookmark.TabIndex = 32;
            this.removeBookmark.Text = "Remove Bookmark";
            this.removeBookmark.UseVisualStyleBackColor = false;
            this.removeBookmark.Click += new System.EventHandler(this.removeBookmark_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // bookmarkGrid
            // 
            this.bookmarkGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookmarkGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bookmarkGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookmarkGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.bookmarkGrid.Location = new System.Drawing.Point(1175, 85);
            this.bookmarkGrid.Name = "bookmarkGrid";
            this.bookmarkGrid.ReadOnly = true;
            this.bookmarkGrid.Size = new System.Drawing.Size(242, 286);
            this.bookmarkGrid.TabIndex = 31;
            this.bookmarkGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookmarkGrid_CellClick);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(957, 507);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(70, 30);
            this.submit.TabIndex = 30;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(56, 36);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(74, 17);
            this.examIDLabel.TabIndex = 28;
            this.examIDLabel.Text = "Exam ID:";
            // 
            // bookmark
            // 
            this.bookmark.BackColor = System.Drawing.Color.White;
            this.bookmark.Location = new System.Drawing.Point(957, 292);
            this.bookmark.Name = "bookmark";
            this.bookmark.Size = new System.Drawing.Size(125, 30);
            this.bookmark.TabIndex = 27;
            this.bookmark.Text = "Bookmark";
            this.bookmark.UseVisualStyleBackColor = false;
            this.bookmark.Click += new System.EventHandler(this.bookmark_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.White;
            this.next.Location = new System.Drawing.Point(568, 443);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(70, 30);
            this.next.TabIndex = 26;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.Color.White;
            this.previous.Location = new System.Drawing.Point(374, 443);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(70, 30);
            this.previous.TabIndex = 25;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(371, 115);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(71, 17);
            this.questionLabel.TabIndex = 24;
            this.questionLabel.Text = "Question";
            // 
            // questionNoLabel
            // 
            this.questionNoLabel.AutoSize = true;
            this.questionNoLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNoLabel.ForeColor = System.Drawing.Color.White;
            this.questionNoLabel.Location = new System.Drawing.Point(371, 85);
            this.questionNoLabel.Name = "questionNoLabel";
            this.questionNoLabel.Size = new System.Drawing.Size(19, 17);
            this.questionNoLabel.TabIndex = 23;
            this.questionNoLabel.Text = "Q";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.ForeColor = System.Drawing.Color.White;
            this.employeeNameLabel.Location = new System.Drawing.Point(56, 9);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(119, 17);
            this.employeeNameLabel.TabIndex = 22;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(897, 41);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(227, 210);
            this.pictureBox.TabIndex = 35;
            this.pictureBox.TabStop = false;
            // 
            // PictureQuestionSingleAns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1487, 651);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.removeBookmark);
            this.Controls.Add(this.bookmarkGrid);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.examIDLabel);
            this.Controls.Add(this.bookmark);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.questionNoLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PictureQuestionSingleAns";
            this.Text = "Skill Set Assessment System";
            this.Load += new System.EventHandler(this.PictureQuestionSingleAns_Load);
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.RadioButton option1Radio;
        private System.Windows.Forms.RadioButton option2Radio;
        private System.Windows.Forms.RadioButton option3Radio;
        private System.Windows.Forms.RadioButton option4Radio;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button removeBookmark;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.DataGridView bookmarkGrid;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.Button bookmark;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label questionNoLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}