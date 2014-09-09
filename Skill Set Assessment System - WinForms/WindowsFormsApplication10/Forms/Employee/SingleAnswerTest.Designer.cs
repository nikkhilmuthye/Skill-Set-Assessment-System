namespace WindowsFormsApplication10
{
    partial class SingleAnswerTest
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
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.questionNoLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.option1RadioButton = new System.Windows.Forms.RadioButton();
            this.option2RadioButton = new System.Windows.Forms.RadioButton();
            this.option3RadioButton = new System.Windows.Forms.RadioButton();
            this.option4RadioButon = new System.Windows.Forms.RadioButton();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.bookmark = new System.Windows.Forms.Button();
            this.examIDLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.bookmarkGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.removeBookmark = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.optionPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkGrid)).BeginInit();
            this.optionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.ForeColor = System.Drawing.Color.White;
            this.employeeNameLabel.Location = new System.Drawing.Point(56, 9);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(119, 17);
            this.employeeNameLabel.TabIndex = 0;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // questionNoLabel
            // 
            this.questionNoLabel.AutoSize = true;
            this.questionNoLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNoLabel.ForeColor = System.Drawing.Color.White;
            this.questionNoLabel.Location = new System.Drawing.Point(371, 85);
            this.questionNoLabel.Name = "questionNoLabel";
            this.questionNoLabel.Size = new System.Drawing.Size(19, 17);
            this.questionNoLabel.TabIndex = 1;
            this.questionNoLabel.Text = "Q";
            this.questionNoLabel.Click += new System.EventHandler(this.questionNoLabel_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(371, 115);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(71, 17);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "Question";
            // 
            // option1RadioButton
            // 
            this.option1RadioButton.AutoSize = true;
            this.option1RadioButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1RadioButton.ForeColor = System.Drawing.Color.White;
            this.option1RadioButton.Location = new System.Drawing.Point(12, 3);
            this.option1RadioButton.Name = "option1RadioButton";
            this.option1RadioButton.Size = new System.Drawing.Size(36, 21);
            this.option1RadioButton.TabIndex = 7;
            this.option1RadioButton.TabStop = true;
            this.option1RadioButton.Text = "A";
            this.option1RadioButton.UseVisualStyleBackColor = true;
            // 
            // option2RadioButton
            // 
            this.option2RadioButton.AutoSize = true;
            this.option2RadioButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2RadioButton.ForeColor = System.Drawing.Color.White;
            this.option2RadioButton.Location = new System.Drawing.Point(12, 42);
            this.option2RadioButton.Name = "option2RadioButton";
            this.option2RadioButton.Size = new System.Drawing.Size(36, 21);
            this.option2RadioButton.TabIndex = 8;
            this.option2RadioButton.TabStop = true;
            this.option2RadioButton.Text = "B";
            this.option2RadioButton.UseVisualStyleBackColor = true;
            // 
            // option3RadioButton
            // 
            this.option3RadioButton.AutoSize = true;
            this.option3RadioButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3RadioButton.ForeColor = System.Drawing.Color.White;
            this.option3RadioButton.Location = new System.Drawing.Point(12, 85);
            this.option3RadioButton.Name = "option3RadioButton";
            this.option3RadioButton.Size = new System.Drawing.Size(36, 21);
            this.option3RadioButton.TabIndex = 9;
            this.option3RadioButton.TabStop = true;
            this.option3RadioButton.Text = "C";
            this.option3RadioButton.UseVisualStyleBackColor = true;
            // 
            // option4RadioButon
            // 
            this.option4RadioButon.AutoSize = true;
            this.option4RadioButon.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4RadioButon.ForeColor = System.Drawing.Color.White;
            this.option4RadioButon.Location = new System.Drawing.Point(12, 131);
            this.option4RadioButon.Name = "option4RadioButon";
            this.option4RadioButon.Size = new System.Drawing.Size(37, 21);
            this.option4RadioButon.TabIndex = 10;
            this.option4RadioButon.TabStop = true;
            this.option4RadioButon.Text = "D";
            this.option4RadioButon.UseVisualStyleBackColor = true;
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.Color.White;
            this.previous.Location = new System.Drawing.Point(374, 443);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(70, 30);
            this.previous.TabIndex = 11;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.White;
            this.next.Location = new System.Drawing.Point(568, 443);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(70, 30);
            this.next.TabIndex = 12;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // bookmark
            // 
            this.bookmark.BackColor = System.Drawing.Color.White;
            this.bookmark.Location = new System.Drawing.Point(957, 292);
            this.bookmark.Name = "bookmark";
            this.bookmark.Size = new System.Drawing.Size(125, 30);
            this.bookmark.TabIndex = 14;
            this.bookmark.Text = "Bookmark";
            this.bookmark.UseVisualStyleBackColor = false;
            this.bookmark.Click += new System.EventHandler(this.bookmark_Click);
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(56, 36);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(74, 17);
            this.examIDLabel.TabIndex = 15;
            this.examIDLabel.Text = "Exam ID:";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabel.Location = new System.Drawing.Point(1172, 50);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 17);
            this.timerLabel.TabIndex = 16;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(957, 507);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(70, 30);
            this.submit.TabIndex = 17;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
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
            this.bookmarkGrid.TabIndex = 18;
            this.bookmarkGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookmarkGrid_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Question_No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bookmark";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // removeBookmark
            // 
            this.removeBookmark.BackColor = System.Drawing.Color.White;
            this.removeBookmark.Location = new System.Drawing.Point(957, 341);
            this.removeBookmark.Name = "removeBookmark";
            this.removeBookmark.Size = new System.Drawing.Size(125, 30);
            this.removeBookmark.TabIndex = 19;
            this.removeBookmark.Text = "Remove Bookmark";
            this.removeBookmark.UseVisualStyleBackColor = false;
            this.removeBookmark.Click += new System.EventHandler(this.removeBookmark_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // optionPanel
            // 
            this.optionPanel.Controls.Add(this.option1RadioButton);
            this.optionPanel.Controls.Add(this.option2RadioButton);
            this.optionPanel.Controls.Add(this.option3RadioButton);
            this.optionPanel.Controls.Add(this.option4RadioButon);
            this.optionPanel.Location = new System.Drawing.Point(374, 184);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(264, 187);
            this.optionPanel.TabIndex = 21;
            // 
            // SingleAnswerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1519, 678);
            this.ControlBox = false;
            this.Controls.Add(this.optionPanel);
            this.Controls.Add(this.removeBookmark);
            this.Controls.Add(this.bookmarkGrid);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.examIDLabel);
            this.Controls.Add(this.bookmark);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.questionNoLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SingleAnswerTest";
            this.Text = "Skill Set Assessment System";
            this.Load += new System.EventHandler(this.SingleAnswerTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkGrid)).EndInit();
            this.optionPanel.ResumeLayout(false);
            this.optionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label questionNoLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton option1RadioButton;
        private System.Windows.Forms.RadioButton option2RadioButton;
        private System.Windows.Forms.RadioButton option3RadioButton;
        private System.Windows.Forms.RadioButton option4RadioButon;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button bookmark;
        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.DataGridView bookmarkGrid;
        private System.Windows.Forms.Button removeBookmark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel optionPanel;
    }
}