namespace WindowsFormsApplication10
{
    partial class CheckEmployeeResult
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
            this.employeeIDText = new System.Windows.Forms.TextBox();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.checkEmpResultLegend = new System.Windows.Forms.GroupBox();
            this.checkEmployeeResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.checkEmpResultLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(344, 393);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 36);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Location = new System.Drawing.Point(108, 107);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.Size = new System.Drawing.Size(571, 232);
            this.resultDataGrid.TabIndex = 6;
            this.resultDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultDataGrid_CellContentClick);
            // 
            // employeeIDText
            // 
            this.employeeIDText.Location = new System.Drawing.Point(382, 59);
            this.employeeIDText.Name = "employeeIDText";
            this.employeeIDText.ReadOnly = true;
            this.employeeIDText.Size = new System.Drawing.Size(100, 20);
            this.employeeIDText.TabIndex = 5;
            this.employeeIDText.TextChanged += new System.EventHandler(this.employeeIDText_TextChanged);
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.ForeColor = System.Drawing.Color.White;
            this.employeeIDLabel.Location = new System.Drawing.Point(237, 59);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(102, 17);
            this.employeeIDLabel.TabIndex = 4;
            this.employeeIDLabel.Text = "Employee ID:";
            this.employeeIDLabel.Click += new System.EventHandler(this.employeeIDLabel_Click);
            // 
            // checkEmpResultLegend
            // 
            this.checkEmpResultLegend.Controls.Add(this.checkEmployeeResultLabel);
            this.checkEmpResultLegend.Controls.Add(this.employeeIDLabel);
            this.checkEmpResultLegend.Controls.Add(this.back);
            this.checkEmpResultLegend.Controls.Add(this.employeeIDText);
            this.checkEmpResultLegend.Controls.Add(this.resultDataGrid);
            this.checkEmpResultLegend.Location = new System.Drawing.Point(94, 33);
            this.checkEmpResultLegend.Name = "checkEmpResultLegend";
            this.checkEmpResultLegend.Size = new System.Drawing.Size(780, 450);
            this.checkEmpResultLegend.TabIndex = 8;
            this.checkEmpResultLegend.TabStop = false;
            this.checkEmpResultLegend.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkEmployeeResultLabel
            // 
            this.checkEmployeeResultLabel.AutoSize = true;
            this.checkEmployeeResultLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEmployeeResultLabel.ForeColor = System.Drawing.Color.White;
            this.checkEmployeeResultLabel.Location = new System.Drawing.Point(258, 0);
            this.checkEmployeeResultLabel.Name = "checkEmployeeResultLabel";
            this.checkEmployeeResultLabel.Size = new System.Drawing.Size(222, 24);
            this.checkEmployeeResultLabel.TabIndex = 8;
            this.checkEmployeeResultLabel.Text = "Check Employee Result";
            // 
            // CheckEmployeeResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.checkEmpResultLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckEmployeeResult";
            this.Text = "CheckEmployeeResult";
            this.Load += new System.EventHandler(this.CheckEmployeeResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            this.checkEmpResultLegend.ResumeLayout(false);
            this.checkEmpResultLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.TextBox employeeIDText;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.GroupBox checkEmpResultLegend;
        private System.Windows.Forms.Label checkEmployeeResultLabel;
    }
}