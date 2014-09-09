namespace WindowsFormsApplication10
{
    partial class ViewPaperDetails
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
            this.examIDLabel = new System.Windows.Forms.Label();
            this.examIDText = new System.Windows.Forms.TextBox();
            this.paperDataGrid = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.paperDetailsLegend = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paperDataGrid)).BeginInit();
            this.paperDetailsLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(152, 61);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(74, 17);
            this.examIDLabel.TabIndex = 0;
            this.examIDLabel.Text = "Exam ID:";
            // 
            // examIDText
            // 
            this.examIDText.Location = new System.Drawing.Point(272, 61);
            this.examIDText.Name = "examIDText";
            this.examIDText.ReadOnly = true;
            this.examIDText.Size = new System.Drawing.Size(100, 20);
            this.examIDText.TabIndex = 1;
            // 
            // paperDataGrid
            // 
            this.paperDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paperDataGrid.Location = new System.Drawing.Point(12, 114);
            this.paperDataGrid.Name = "paperDataGrid";
            this.paperDataGrid.Size = new System.Drawing.Size(599, 193);
            this.paperDataGrid.TabIndex = 2;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(247, 393);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // paperDetailsLegend
            // 
            this.paperDetailsLegend.Controls.Add(this.label1);
            this.paperDetailsLegend.Controls.Add(this.examIDLabel);
            this.paperDetailsLegend.Controls.Add(this.back);
            this.paperDetailsLegend.Controls.Add(this.examIDText);
            this.paperDetailsLegend.Controls.Add(this.paperDataGrid);
            this.paperDetailsLegend.Location = new System.Drawing.Point(46, 53);
            this.paperDetailsLegend.Name = "paperDetailsLegend";
            this.paperDetailsLegend.Size = new System.Drawing.Size(667, 457);
            this.paperDetailsLegend.TabIndex = 4;
            this.paperDetailsLegend.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paper Details";
            // 
            // ViewPaperDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.paperDetailsLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPaperDetails";
            this.Text = "ViewPaperDetails";
            this.Load += new System.EventHandler(this.ViewPaperDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paperDataGrid)).EndInit();
            this.paperDetailsLegend.ResumeLayout(false);
            this.paperDetailsLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.TextBox examIDText;
        private System.Windows.Forms.DataGridView paperDataGrid;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox paperDetailsLegend;
        private System.Windows.Forms.Label label1;
    }
}