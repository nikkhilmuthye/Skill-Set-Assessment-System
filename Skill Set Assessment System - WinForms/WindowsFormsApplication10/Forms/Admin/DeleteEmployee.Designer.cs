namespace WindowsFormsApplication10
{
    partial class DeleteEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.employeeIDCombo = new System.Windows.Forms.ComboBox();
            this.deleteEmployeeLegend = new System.Windows.Forms.GroupBox();
            this.deleteEmployeeLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Employee";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.ForeColor = System.Drawing.Color.White;
            this.employeeIDLabel.Location = new System.Drawing.Point(57, 110);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(96, 17);
            this.employeeIDLabel.TabIndex = 1;
            this.employeeIDLabel.Text = "Employee ID";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(284, 219);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(70, 30);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(70, 219);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // employeeIDCombo
            // 
            this.employeeIDCombo.FormattingEnabled = true;
            this.employeeIDCombo.Location = new System.Drawing.Point(233, 110);
            this.employeeIDCombo.Name = "employeeIDCombo";
            this.employeeIDCombo.Size = new System.Drawing.Size(121, 21);
            this.employeeIDCombo.TabIndex = 5;
            // 
            // deleteEmployeeLegend
            // 
            this.deleteEmployeeLegend.Controls.Add(this.label1);
            this.deleteEmployeeLegend.Controls.Add(this.employeeIDCombo);
            this.deleteEmployeeLegend.Controls.Add(this.employeeIDLabel);
            this.deleteEmployeeLegend.Controls.Add(this.back);
            this.deleteEmployeeLegend.Controls.Add(this.delete);
            this.deleteEmployeeLegend.Location = new System.Drawing.Point(139, 83);
            this.deleteEmployeeLegend.Name = "deleteEmployeeLegend";
            this.deleteEmployeeLegend.Size = new System.Drawing.Size(394, 334);
            this.deleteEmployeeLegend.TabIndex = 6;
            this.deleteEmployeeLegend.TabStop = false;
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.deleteEmployeeLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteEmployee";
            this.Text = "Delete Employee";
            this.Load += new System.EventHandler(this.DeleteEmployee_Load);
            this.deleteEmployeeLegend.ResumeLayout(false);
            this.deleteEmployeeLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox employeeIDCombo;
        private System.Windows.Forms.GroupBox deleteEmployeeLegend;
    }
}