namespace WindowsFormsApplication10
{
    partial class SeeResult
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
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.averagelabel = new System.Windows.Forms.Label();
            this.lowestlabel = new System.Windows.Forms.Label();
            this.highestlabel = new System.Windows.Forms.Label();
            this.seeResultLegend = new System.Windows.Forms.GroupBox();
            this.seeResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.seeResultLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(305, 67);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(74, 17);
            this.examIDLabel.TabIndex = 0;
            this.examIDLabel.Text = "Exam ID:";
            // 
            // examIDText
            // 
            this.examIDText.Location = new System.Drawing.Point(421, 66);
            this.examIDText.Name = "examIDText";
            this.examIDText.ReadOnly = true;
            this.examIDText.Size = new System.Drawing.Size(100, 20);
            this.examIDText.TabIndex = 1;
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Location = new System.Drawing.Point(113, 163);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.Size = new System.Drawing.Size(571, 226);
            this.resultDataGrid.TabIndex = 2;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(355, 413);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // averagelabel
            // 
            this.averagelabel.AutoSize = true;
            this.averagelabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averagelabel.ForeColor = System.Drawing.Color.White;
            this.averagelabel.Location = new System.Drawing.Point(556, 106);
            this.averagelabel.Name = "averagelabel";
            this.averagelabel.Size = new System.Drawing.Size(71, 17);
            this.averagelabel.TabIndex = 9;
            this.averagelabel.Text = "Average:";
            // 
            // lowestlabel
            // 
            this.lowestlabel.AutoSize = true;
            this.lowestlabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowestlabel.ForeColor = System.Drawing.Color.White;
            this.lowestlabel.Location = new System.Drawing.Point(352, 106);
            this.lowestlabel.Name = "lowestlabel";
            this.lowestlabel.Size = new System.Drawing.Size(64, 17);
            this.lowestlabel.TabIndex = 8;
            this.lowestlabel.Text = "Lowest:";
            // 
            // highestlabel
            // 
            this.highestlabel.AutoSize = true;
            this.highestlabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestlabel.ForeColor = System.Drawing.Color.White;
            this.highestlabel.Location = new System.Drawing.Point(124, 106);
            this.highestlabel.Name = "highestlabel";
            this.highestlabel.Size = new System.Drawing.Size(67, 17);
            this.highestlabel.TabIndex = 7;
            this.highestlabel.Text = "Highest:";
            // 
            // seeResultLegend
            // 
            this.seeResultLegend.Controls.Add(this.seeResultLabel);
            this.seeResultLegend.Controls.Add(this.examIDLabel);
            this.seeResultLegend.Controls.Add(this.averagelabel);
            this.seeResultLegend.Controls.Add(this.examIDText);
            this.seeResultLegend.Controls.Add(this.lowestlabel);
            this.seeResultLegend.Controls.Add(this.resultDataGrid);
            this.seeResultLegend.Controls.Add(this.highestlabel);
            this.seeResultLegend.Controls.Add(this.back);
            this.seeResultLegend.Location = new System.Drawing.Point(61, 56);
            this.seeResultLegend.Name = "seeResultLegend";
            this.seeResultLegend.Size = new System.Drawing.Size(819, 449);
            this.seeResultLegend.TabIndex = 10;
            this.seeResultLegend.TabStop = false;
            // 
            // seeResultLabel
            // 
            this.seeResultLabel.AutoSize = true;
            this.seeResultLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeResultLabel.ForeColor = System.Drawing.Color.White;
            this.seeResultLabel.Location = new System.Drawing.Point(305, 0);
            this.seeResultLabel.Name = "seeResultLabel";
            this.seeResultLabel.Size = new System.Drawing.Size(173, 24);
            this.seeResultLabel.TabIndex = 10;
            this.seeResultLabel.Text = "View Exam Result";
            // 
            // SeeResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.seeResultLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeeResult";
            this.Text = " ";
            this.Load += new System.EventHandler(this.SeeResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            this.seeResultLegend.ResumeLayout(false);
            this.seeResultLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.TextBox examIDText;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label averagelabel;
        private System.Windows.Forms.Label lowestlabel;
        private System.Windows.Forms.Label highestlabel;
        private System.Windows.Forms.GroupBox seeResultLegend;
        private System.Windows.Forms.Label seeResultLabel;
    }
}