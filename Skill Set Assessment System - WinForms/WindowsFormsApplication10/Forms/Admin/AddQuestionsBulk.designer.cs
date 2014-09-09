namespace WindowsFormsApplication10
{
    partial class AddQuestionsBulk
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
            this.select = new System.Windows.Forms.Button();
            this.bulkLabel = new System.Windows.Forms.Label();
            this.selectLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.AddQuestionBulkLegend = new System.Windows.Forms.GroupBox();
            this.AddQuestionBulkLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // select
            // 
            this.select.ForeColor = System.Drawing.Color.Black;
            this.select.Location = new System.Drawing.Point(204, 137);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(70, 25);
            this.select.TabIndex = 0;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // bulkLabel
            // 
            this.bulkLabel.AutoSize = true;
            this.bulkLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulkLabel.Location = new System.Drawing.Point(149, 0);
            this.bulkLabel.Name = "bulkLabel";
            this.bulkLabel.Size = new System.Drawing.Size(218, 24);
            this.bulkLabel.TabIndex = 1;
            this.bulkLabel.Text = "Bulk Upload Questions";
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.Location = new System.Drawing.Point(164, 96);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(165, 17);
            this.selectLabel.TabIndex = 2;
            this.selectLabel.Text = "Select The Path Of File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 3;
            // 
            // add
            // 
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Location = new System.Drawing.Point(272, 248);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(70, 30);
            this.add.TabIndex = 4;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // back
            // 
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(138, 248);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AddQuestionBulkLegend
            // 
            this.AddQuestionBulkLegend.Controls.Add(this.bulkLabel);
            this.AddQuestionBulkLegend.Controls.Add(this.back);
            this.AddQuestionBulkLegend.Controls.Add(this.select);
            this.AddQuestionBulkLegend.Controls.Add(this.add);
            this.AddQuestionBulkLegend.Controls.Add(this.selectLabel);
            this.AddQuestionBulkLegend.Controls.Add(this.textBox1);
            this.AddQuestionBulkLegend.Location = new System.Drawing.Point(101, 92);
            this.AddQuestionBulkLegend.Name = "AddQuestionBulkLegend";
            this.AddQuestionBulkLegend.Size = new System.Drawing.Size(470, 316);
            this.AddQuestionBulkLegend.TabIndex = 6;
            this.AddQuestionBulkLegend.TabStop = false;
            // 
            // AddQuestionsBulk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.AddQuestionBulkLegend);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddQuestionsBulk";
            this.Text = "AddQuestionsBulk";
            this.Load += new System.EventHandler(this.AddQuestionsBulk_Load);
            this.AddQuestionBulkLegend.ResumeLayout(false);
            this.AddQuestionBulkLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Label bulkLabel;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox AddQuestionBulkLegend;
    }
}