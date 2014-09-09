namespace WindowsFormsApplication10
{
    partial class MatchTheColumnTest
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
            this.bookMarkGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.submit = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.examIDLabel = new System.Windows.Forms.Label();
            this.bookmark = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.questionNoLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.aOption1Label = new System.Windows.Forms.Label();
            this.aOption2Label = new System.Windows.Forms.Label();
            this.aOption3Label = new System.Windows.Forms.Label();
            this.aOption4Label = new System.Windows.Forms.Label();
            this.bOption1Label = new System.Windows.Forms.Label();
            this.bOption2Label = new System.Windows.Forms.Label();
            this.bOption3Label = new System.Windows.Forms.Label();
            this.bOption4Label = new System.Windows.Forms.Label();
            this.columnALabel = new System.Windows.Forms.Label();
            this.columnBLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.oneLabel = new System.Windows.Forms.Label();
            this.twoLabel = new System.Windows.Forms.Label();
            this.threeLabel = new System.Windows.Forms.Label();
            this.fourLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookMarkGrid)).BeginInit();
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
            // bookMarkGrid
            // 
            this.bookMarkGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookMarkGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bookMarkGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookMarkGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.bookMarkGrid.Location = new System.Drawing.Point(1175, 85);
            this.bookMarkGrid.Name = "bookMarkGrid";
            this.bookMarkGrid.ReadOnly = true;
            this.bookMarkGrid.Size = new System.Drawing.Size(242, 286);
            this.bookMarkGrid.TabIndex = 34;
            this.bookMarkGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookmarkGrid_CellClick);
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
            // questionNoLabel
            // 
            this.questionNoLabel.AutoSize = true;
            this.questionNoLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNoLabel.ForeColor = System.Drawing.Color.White;
            this.questionNoLabel.Location = new System.Drawing.Point(318, 165);
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
            // aOption1Label
            // 
            this.aOption1Label.AutoSize = true;
            this.aOption1Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aOption1Label.ForeColor = System.Drawing.Color.White;
            this.aOption1Label.Location = new System.Drawing.Point(388, 203);
            this.aOption1Label.Name = "aOption1Label";
            this.aOption1Label.Size = new System.Drawing.Size(69, 17);
            this.aOption1Label.TabIndex = 37;
            this.aOption1Label.Text = "Option 1";
            // 
            // aOption2Label
            // 
            this.aOption2Label.AutoSize = true;
            this.aOption2Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aOption2Label.ForeColor = System.Drawing.Color.White;
            this.aOption2Label.Location = new System.Drawing.Point(387, 240);
            this.aOption2Label.Name = "aOption2Label";
            this.aOption2Label.Size = new System.Drawing.Size(69, 17);
            this.aOption2Label.TabIndex = 38;
            this.aOption2Label.Text = "Option 2";
            // 
            // aOption3Label
            // 
            this.aOption3Label.AutoSize = true;
            this.aOption3Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aOption3Label.ForeColor = System.Drawing.Color.White;
            this.aOption3Label.Location = new System.Drawing.Point(388, 280);
            this.aOption3Label.Name = "aOption3Label";
            this.aOption3Label.Size = new System.Drawing.Size(69, 17);
            this.aOption3Label.TabIndex = 39;
            this.aOption3Label.Text = "Option 3";
            // 
            // aOption4Label
            // 
            this.aOption4Label.AutoSize = true;
            this.aOption4Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aOption4Label.ForeColor = System.Drawing.Color.White;
            this.aOption4Label.Location = new System.Drawing.Point(387, 319);
            this.aOption4Label.Name = "aOption4Label";
            this.aOption4Label.Size = new System.Drawing.Size(69, 17);
            this.aOption4Label.TabIndex = 40;
            this.aOption4Label.Text = "Option 4";
            // 
            // bOption1Label
            // 
            this.bOption1Label.AutoSize = true;
            this.bOption1Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOption1Label.ForeColor = System.Drawing.Color.White;
            this.bOption1Label.Location = new System.Drawing.Point(578, 203);
            this.bOption1Label.Name = "bOption1Label";
            this.bOption1Label.Size = new System.Drawing.Size(69, 17);
            this.bOption1Label.TabIndex = 41;
            this.bOption1Label.Text = "Option 1";
            // 
            // bOption2Label
            // 
            this.bOption2Label.AutoSize = true;
            this.bOption2Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOption2Label.ForeColor = System.Drawing.Color.White;
            this.bOption2Label.Location = new System.Drawing.Point(578, 240);
            this.bOption2Label.Name = "bOption2Label";
            this.bOption2Label.Size = new System.Drawing.Size(69, 17);
            this.bOption2Label.TabIndex = 42;
            this.bOption2Label.Text = "Option 2";
            // 
            // bOption3Label
            // 
            this.bOption3Label.AutoSize = true;
            this.bOption3Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOption3Label.ForeColor = System.Drawing.Color.White;
            this.bOption3Label.Location = new System.Drawing.Point(578, 280);
            this.bOption3Label.Name = "bOption3Label";
            this.bOption3Label.Size = new System.Drawing.Size(69, 17);
            this.bOption3Label.TabIndex = 43;
            this.bOption3Label.Text = "Option 3";
            // 
            // bOption4Label
            // 
            this.bOption4Label.AutoSize = true;
            this.bOption4Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOption4Label.ForeColor = System.Drawing.Color.White;
            this.bOption4Label.Location = new System.Drawing.Point(578, 319);
            this.bOption4Label.Name = "bOption4Label";
            this.bOption4Label.Size = new System.Drawing.Size(69, 17);
            this.bOption4Label.TabIndex = 44;
            this.bOption4Label.Text = "Option 4";
            // 
            // columnALabel
            // 
            this.columnALabel.AutoSize = true;
            this.columnALabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnALabel.ForeColor = System.Drawing.Color.White;
            this.columnALabel.Location = new System.Drawing.Point(371, 165);
            this.columnALabel.Name = "columnALabel";
            this.columnALabel.Size = new System.Drawing.Size(83, 17);
            this.columnALabel.TabIndex = 45;
            this.columnALabel.Text = "COLUMN A";
            // 
            // columnBLabel
            // 
            this.columnBLabel.AutoSize = true;
            this.columnBLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnBLabel.ForeColor = System.Drawing.Color.White;
            this.columnBLabel.Location = new System.Drawing.Point(562, 165);
            this.columnBLabel.Name = "columnBLabel";
            this.columnBLabel.Size = new System.Drawing.Size(83, 17);
            this.columnBLabel.TabIndex = 46;
            this.columnBLabel.Text = "COLUMN B";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabel.ForeColor = System.Drawing.Color.White;
            this.aLabel.Location = new System.Drawing.Point(347, 203);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(23, 17);
            this.aLabel.TabIndex = 47;
            this.aLabel.Text = "A.";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel.ForeColor = System.Drawing.Color.White;
            this.bLabel.Location = new System.Drawing.Point(347, 240);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(23, 17);
            this.bLabel.TabIndex = 48;
            this.bLabel.Text = "B.";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel.ForeColor = System.Drawing.Color.White;
            this.cLabel.Location = new System.Drawing.Point(347, 280);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(23, 17);
            this.cLabel.TabIndex = 49;
            this.cLabel.Text = "C.";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.ForeColor = System.Drawing.Color.White;
            this.dLabel.Location = new System.Drawing.Point(348, 319);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(24, 17);
            this.dLabel.TabIndex = 50;
            this.dLabel.Text = "D.";
            // 
            // oneLabel
            // 
            this.oneLabel.AutoSize = true;
            this.oneLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneLabel.ForeColor = System.Drawing.Color.White;
            this.oneLabel.Location = new System.Drawing.Point(548, 203);
            this.oneLabel.Name = "oneLabel";
            this.oneLabel.Size = new System.Drawing.Size(22, 17);
            this.oneLabel.TabIndex = 51;
            this.oneLabel.Text = "1.";
            // 
            // twoLabel
            // 
            this.twoLabel.AutoSize = true;
            this.twoLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoLabel.ForeColor = System.Drawing.Color.White;
            this.twoLabel.Location = new System.Drawing.Point(548, 240);
            this.twoLabel.Name = "twoLabel";
            this.twoLabel.Size = new System.Drawing.Size(22, 17);
            this.twoLabel.TabIndex = 52;
            this.twoLabel.Text = "2.";
            // 
            // threeLabel
            // 
            this.threeLabel.AutoSize = true;
            this.threeLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeLabel.ForeColor = System.Drawing.Color.White;
            this.threeLabel.Location = new System.Drawing.Point(548, 280);
            this.threeLabel.Name = "threeLabel";
            this.threeLabel.Size = new System.Drawing.Size(22, 17);
            this.threeLabel.TabIndex = 53;
            this.threeLabel.Text = "3.";
            // 
            // fourLabel
            // 
            this.fourLabel.AutoSize = true;
            this.fourLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourLabel.ForeColor = System.Drawing.Color.White;
            this.fourLabel.Location = new System.Drawing.Point(548, 319);
            this.fourLabel.Name = "fourLabel";
            this.fourLabel.Size = new System.Drawing.Size(22, 17);
            this.fourLabel.TabIndex = 54;
            this.fourLabel.Text = "4.";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.ForeColor = System.Drawing.Color.White;
            this.orderLabel.Location = new System.Drawing.Point(434, 378);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(54, 17);
            this.orderLabel.TabIndex = 55;
            this.orderLabel.Text = "Order:";
            // 
            // orderTextBox
            // 
            this.orderTextBox.Location = new System.Drawing.Point(489, 375);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderTextBox.TabIndex = 56;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MatchTheColumnTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1522, 665);
            this.ControlBox = false;
            this.Controls.Add(this.orderTextBox);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.fourLabel);
            this.Controls.Add(this.threeLabel);
            this.Controls.Add(this.twoLabel);
            this.Controls.Add(this.oneLabel);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.columnBLabel);
            this.Controls.Add(this.columnALabel);
            this.Controls.Add(this.bOption4Label);
            this.Controls.Add(this.bOption3Label);
            this.Controls.Add(this.bOption2Label);
            this.Controls.Add(this.bOption1Label);
            this.Controls.Add(this.aOption4Label);
            this.Controls.Add(this.aOption3Label);
            this.Controls.Add(this.aOption2Label);
            this.Controls.Add(this.aOption1Label);
            this.Controls.Add(this.removeBookmark);
            this.Controls.Add(this.bookMarkGrid);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.examIDLabel);
            this.Controls.Add(this.bookmark);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.questionNoLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MatchTheColumnTest";
            this.Text = "Skill Set Assessment System";
            this.Load += new System.EventHandler(this.MatchTheColumnTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookMarkGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeBookmark;
        private System.Windows.Forms.DataGridView bookMarkGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.Button bookmark;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Label questionNoLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label aOption1Label;
        private System.Windows.Forms.Label aOption2Label;
        private System.Windows.Forms.Label aOption3Label;
        private System.Windows.Forms.Label aOption4Label;
        private System.Windows.Forms.Label bOption1Label;
        private System.Windows.Forms.Label bOption2Label;
        private System.Windows.Forms.Label bOption3Label;
        private System.Windows.Forms.Label bOption4Label;
        private System.Windows.Forms.Label columnALabel;
        private System.Windows.Forms.Label columnBLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label oneLabel;
        private System.Windows.Forms.Label twoLabel;
        private System.Windows.Forms.Label threeLabel;
        private System.Windows.Forms.Label fourLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.Timer Timer;
    }
}