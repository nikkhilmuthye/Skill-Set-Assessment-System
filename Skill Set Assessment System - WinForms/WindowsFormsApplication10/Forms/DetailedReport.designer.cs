namespace WindowsFormsApplication10
{
    partial class DetailedReport
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
            this.back = new System.Windows.Forms.Button();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.examIDTextBox = new System.Windows.Forms.TextBox();
            this.examIDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(437, 411);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 26);
            this.back.TabIndex = 15;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Location = new System.Drawing.Point(284, 162);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.Size = new System.Drawing.Size(419, 192);
            this.resultDataGrid.TabIndex = 14;
            // 
            // examIDTextBox
            // 
            this.examIDTextBox.Location = new System.Drawing.Point(502, 70);
            this.examIDTextBox.Name = "examIDTextBox";
            this.examIDTextBox.ReadOnly = true;
            this.examIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.examIDTextBox.TabIndex = 11;
            // 
            // examIDLabel1
            // 
            this.examIDLabel1.AutoSize = true;
            this.examIDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel1.ForeColor = System.Drawing.Color.White;
            this.examIDLabel1.Location = new System.Drawing.Point(386, 71);
            this.examIDLabel1.Name = "examIDLabel1";
            this.examIDLabel1.Size = new System.Drawing.Size(61, 16);
            this.examIDLabel1.TabIndex = 10;
            this.examIDLabel1.Text = "Exam ID:";
            // 
            // DetailedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.back);
            this.Controls.Add(this.resultDataGrid);
            this.Controls.Add(this.examIDTextBox);
            this.Controls.Add(this.examIDLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailedReport";
            this.Text = "DetailedReport";
            this.Load += new System.EventHandler(this.DetailedReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.TextBox examIDTextBox;
        private System.Windows.Forms.Label examIDLabel1;
    }
}