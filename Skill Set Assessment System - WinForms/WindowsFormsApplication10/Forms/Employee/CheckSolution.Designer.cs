namespace WindowsFormsApplication10
{
    partial class CheckSolution
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
            this.solutionGridView = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Right_Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer_Marked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proceed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.solutionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // solutionGridView
            // 
            this.solutionGridView.AllowUserToOrderColumns = true;
            this.solutionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.solutionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Question,
            this.Right_Answer,
            this.Answer_Marked});
            this.solutionGridView.Enabled = false;
            this.solutionGridView.Location = new System.Drawing.Point(537, 147);
            this.solutionGridView.Name = "solutionGridView";
            this.solutionGridView.Size = new System.Drawing.Size(568, 261);
            this.solutionGridView.TabIndex = 2;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 25;
            // 
            // Question
            // 
            this.Question.HeaderText = "Question";
            this.Question.Name = "Question";
            this.Question.Width = 300;
            // 
            // Right_Answer
            // 
            this.Right_Answer.HeaderText = "Right Answer";
            this.Right_Answer.Name = "Right_Answer";
            // 
            // Answer_Marked
            // 
            this.Answer_Marked.HeaderText = "Answer Marked";
            this.Answer_Marked.Name = "Answer_Marked";
            // 
            // Proceed
            // 
            this.Proceed.BackColor = System.Drawing.Color.White;
            this.Proceed.Location = new System.Drawing.Point(808, 507);
            this.Proceed.Name = "Proceed";
            this.Proceed.Size = new System.Drawing.Size(70, 30);
            this.Proceed.TabIndex = 3;
            this.Proceed.Text = "Proceed";
            this.Proceed.UseVisualStyleBackColor = false;
            this.Proceed.Click += new System.EventHandler(this.Proceed_Click);
            // 
            // CheckSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1552, 677);
            this.ControlBox = false;
            this.Controls.Add(this.solutionGridView);
            this.Controls.Add(this.Proceed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CheckSolution";
            this.Text = "CheckSolution";
            this.Load += new System.EventHandler(this.CheckSolution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.solutionGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView solutionGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Right_Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer_Marked;
        private System.Windows.Forms.Button Proceed;
    }
}