namespace WindowsFormsApplication10
{
    partial class MultipleAnswerTest
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
            this.removeBookmark = new System.Windows.Forms.Button();
            this.bookmarkGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.submit = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.examIDLabel = new System.Windows.Forms.Label();
            this.bookmark = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionNoLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.option1CheckBox = new System.Windows.Forms.CheckBox();
            this.option2CheckBox = new System.Windows.Forms.CheckBox();
            this.option3CheckBox = new System.Windows.Forms.CheckBox();
            this.option4CheckBox = new System.Windows.Forms.CheckBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // removeBookmark
            // 
            this.removeBookmark.BackColor = System.Drawing.Color.White;
            this.removeBookmark.Location = new System.Drawing.Point(957, 341);
            this.removeBookmark.Name = "removeBookmark";
            this.removeBookmark.Size = new System.Drawing.Size(125, 30);
            this.removeBookmark.TabIndex = 35;
            this.removeBookmark.Text = "Remove Bookmark";
            this.removeBookmark.UseVisualStyleBackColor = false;
            this.removeBookmark.Click += new System.EventHandler(this.removeBookmark_Click);
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
            this.bookmarkGrid.TabIndex = 34;
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
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(957, 507);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(70, 30);
            this.submit.TabIndex = 33;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabel.Location = new System.Drawing.Point(1172, 50);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 17);
            this.timerLabel.TabIndex = 32;
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(56, 36);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(74, 17);
            this.examIDLabel.TabIndex = 31;
            this.examIDLabel.Text = "Exam ID:";
            // 
            // bookmark
            // 
            this.bookmark.BackColor = System.Drawing.Color.White;
            this.bookmark.Location = new System.Drawing.Point(957, 292);
            this.bookmark.Name = "bookmark";
            this.bookmark.Size = new System.Drawing.Size(125, 30);
            this.bookmark.TabIndex = 30;
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
            this.next.TabIndex = 29;
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
            this.previous.TabIndex = 28;
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
            this.questionLabel.TabIndex = 23;
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
            this.questionNoLabel.TabIndex = 22;
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
            this.employeeNameLabel.TabIndex = 21;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // option1CheckBox
            // 
            this.option1CheckBox.AutoSize = true;
            this.option1CheckBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1CheckBox.ForeColor = System.Drawing.Color.White;
            this.option1CheckBox.Location = new System.Drawing.Point(386, 187);
            this.option1CheckBox.Name = "option1CheckBox";
            this.option1CheckBox.Size = new System.Drawing.Size(37, 21);
            this.option1CheckBox.TabIndex = 37;
            this.option1CheckBox.Text = "A";
            this.option1CheckBox.UseVisualStyleBackColor = true;
            // 
            // option2CheckBox
            // 
            this.option2CheckBox.AutoSize = true;
            this.option2CheckBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2CheckBox.ForeColor = System.Drawing.Color.White;
            this.option2CheckBox.Location = new System.Drawing.Point(386, 226);
            this.option2CheckBox.Name = "option2CheckBox";
            this.option2CheckBox.Size = new System.Drawing.Size(37, 21);
            this.option2CheckBox.TabIndex = 38;
            this.option2CheckBox.Text = "B";
            this.option2CheckBox.UseVisualStyleBackColor = true;
            // 
            // option3CheckBox
            // 
            this.option3CheckBox.AutoSize = true;
            this.option3CheckBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3CheckBox.ForeColor = System.Drawing.Color.White;
            this.option3CheckBox.Location = new System.Drawing.Point(386, 269);
            this.option3CheckBox.Name = "option3CheckBox";
            this.option3CheckBox.Size = new System.Drawing.Size(37, 21);
            this.option3CheckBox.TabIndex = 39;
            this.option3CheckBox.Text = "C";
            this.option3CheckBox.UseVisualStyleBackColor = true;
            // 
            // option4CheckBox
            // 
            this.option4CheckBox.AutoSize = true;
            this.option4CheckBox.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4CheckBox.ForeColor = System.Drawing.Color.White;
            this.option4CheckBox.Location = new System.Drawing.Point(386, 315);
            this.option4CheckBox.Name = "option4CheckBox";
            this.option4CheckBox.Size = new System.Drawing.Size(38, 21);
            this.option4CheckBox.TabIndex = 40;
            this.option4CheckBox.Text = "D";
            this.option4CheckBox.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MultipleAnswerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1533, 661);
            this.ControlBox = false;
            this.Controls.Add(this.option4CheckBox);
            this.Controls.Add(this.option3CheckBox);
            this.Controls.Add(this.option2CheckBox);
            this.Controls.Add(this.option1CheckBox);
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
            this.Name = "MultipleAnswerTest";
            this.Text = "Skill Set Assessment System";
            this.Load += new System.EventHandler(this.MultipleAnswerTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeBookmark;
        private System.Windows.Forms.DataGridView bookmarkGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.Button bookmark;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label questionNoLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.CheckBox option1CheckBox;
        private System.Windows.Forms.CheckBox option2CheckBox;
        private System.Windows.Forms.CheckBox option3CheckBox;
        private System.Windows.Forms.CheckBox option4CheckBox;
        private System.Windows.Forms.Timer Timer;
    }
}