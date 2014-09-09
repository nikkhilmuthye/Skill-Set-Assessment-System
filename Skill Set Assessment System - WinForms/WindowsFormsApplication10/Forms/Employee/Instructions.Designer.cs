namespace WindowsFormsApplication10
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.instructionLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.examIDLabel = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.Color.White;
            this.instructionLabel.Location = new System.Drawing.Point(119, 38);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(293, 24);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Instuctions for the Examination";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.ForeColor = System.Drawing.Color.White;
            this.pointsLabel.Location = new System.Drawing.Point(121, 84);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(293, 294);
            this.pointsLabel.TabIndex = 1;
            this.pointsLabel.Text = resources.GetString("pointsLabel.Text");
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(430, 419);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(70, 30);
            this.start.TabIndex = 2;
            this.start.Text = "Start Test";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.startTest_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(498, 53);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(498, 18);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(79, 17);
            this.examIDLabel.TabIndex = 4;
            this.examIDLabel.Text = "Exam ID: ";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(237, 419);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(125, 30);
            this.back.TabIndex = 5;
            this.back.Text = "Back To Tutorial";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(98, 419);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(70, 30);
            this.home.TabIndex = 6;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(761, 475);
            this.ControlBox = false;
            this.Controls.Add(this.home);
            this.Controls.Add(this.back);
            this.Controls.Add(this.examIDLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.instructionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Instructions";
            this.Text = "Skill Set Assessment System";
            this.Load += new System.EventHandler(this.Instructions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button home;
    }
}