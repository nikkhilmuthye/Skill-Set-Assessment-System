namespace WindowsFormsApplication10
{
    partial class SetAdmin
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
            this.chooseEmpLabel = new System.Windows.Forms.Label();
            this.setAdminLabel = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.Set = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.setAdminLegend = new System.Windows.Forms.GroupBox();
            this.setAdminLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseEmpLabel
            // 
            this.chooseEmpLabel.AutoSize = true;
            this.chooseEmpLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseEmpLabel.Location = new System.Drawing.Point(139, 80);
            this.chooseEmpLabel.Name = "chooseEmpLabel";
            this.chooseEmpLabel.Size = new System.Drawing.Size(139, 17);
            this.chooseEmpLabel.TabIndex = 0;
            this.chooseEmpLabel.Text = "Choose Employee:";
            // 
            // setAdminLabel
            // 
            this.setAdminLabel.AutoSize = true;
            this.setAdminLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAdminLabel.Location = new System.Drawing.Point(161, 0);
            this.setAdminLabel.Name = "setAdminLabel";
            this.setAdminLabel.Size = new System.Drawing.Size(107, 24);
            this.setAdminLabel.TabIndex = 1;
            this.setAdminLabel.Text = "Set Admin";
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(122, 114);
            this.listBox.MultiColumn = true;
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(170, 251);
            this.listBox.TabIndex = 2;
            // 
            // Set
            // 
            this.Set.ForeColor = System.Drawing.Color.Black;
            this.Set.Location = new System.Drawing.Point(292, 424);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(70, 30);
            this.Set.TabIndex = 3;
            this.Set.Text = "Set";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // back
            // 
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(65, 424);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // setAdminLegend
            // 
            this.setAdminLegend.Controls.Add(this.setAdminLabel);
            this.setAdminLegend.Controls.Add(this.back);
            this.setAdminLegend.Controls.Add(this.chooseEmpLabel);
            this.setAdminLegend.Controls.Add(this.Set);
            this.setAdminLegend.Controls.Add(this.listBox);
            this.setAdminLegend.Location = new System.Drawing.Point(73, 50);
            this.setAdminLegend.Name = "setAdminLegend";
            this.setAdminLegend.Size = new System.Drawing.Size(419, 464);
            this.setAdminLegend.TabIndex = 5;
            this.setAdminLegend.TabStop = false;
            // 
            // SetAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.setAdminLegend);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetAdmin";
            this.Text = "SetAdmin";
            this.Load += new System.EventHandler(this.SetAdmin_Load);
            this.setAdminLegend.ResumeLayout(false);
            this.setAdminLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label chooseEmpLabel;
        private System.Windows.Forms.Label setAdminLabel;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox setAdminLegend;
    }
}