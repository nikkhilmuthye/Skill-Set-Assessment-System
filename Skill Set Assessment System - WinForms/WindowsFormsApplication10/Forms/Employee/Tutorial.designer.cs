namespace WindowsFormsApplication10
{
    partial class Tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial));
            this.tutorialLabel = new System.Windows.Forms.Label();
            this.tutorialLabel1 = new System.Windows.Forms.Label();
            this.proceed = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.examIDLabel = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.tutorialLabel2 = new System.Windows.Forms.Label();
            this.tutorialLabel3 = new System.Windows.Forms.Label();
            this.tutorialLabel4 = new System.Windows.Forms.Label();
            this.figLabel1 = new System.Windows.Forms.Label();
            this.figLabel2 = new System.Windows.Forms.Label();
            this.figLabel3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorialLabel
            // 
            this.tutorialLabel.AutoSize = true;
            this.tutorialLabel.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialLabel.ForeColor = System.Drawing.Color.White;
            this.tutorialLabel.Location = new System.Drawing.Point(135, 69);
            this.tutorialLabel.Name = "tutorialLabel";
            this.tutorialLabel.Size = new System.Drawing.Size(82, 24);
            this.tutorialLabel.TabIndex = 0;
            this.tutorialLabel.Text = "Tutorial";
            this.tutorialLabel.Click += new System.EventHandler(this.tutorialLabel_Click);
            // 
            // tutorialLabel1
            // 
            this.tutorialLabel1.AutoSize = true;
            this.tutorialLabel1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialLabel1.ForeColor = System.Drawing.Color.White;
            this.tutorialLabel1.Location = new System.Drawing.Point(62, 129);
            this.tutorialLabel1.Name = "tutorialLabel1";
            this.tutorialLabel1.Size = new System.Drawing.Size(433, 51);
            this.tutorialLabel1.TabIndex = 1;
            this.tutorialLabel1.Text = "1. A timer displaying the time left for the completion of test \r\n    will be disp" +
                "layed at the top right corner of the page.\r\n    (Refer to fig 1)";
            this.tutorialLabel1.Click += new System.EventHandler(this.tutorialLabel1_Click);
            // 
            // proceed
            // 
            this.proceed.BackColor = System.Drawing.Color.White;
            this.proceed.Location = new System.Drawing.Point(680, 692);
            this.proceed.Name = "proceed";
            this.proceed.Size = new System.Drawing.Size(70, 30);
            this.proceed.TabIndex = 2;
            this.proceed.Text = "Proceed";
            this.proceed.UseVisualStyleBackColor = false;
            this.proceed.Click += new System.EventHandler(this.proceed_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(677, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // examIDLabel
            // 
            this.examIDLabel.AutoSize = true;
            this.examIDLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examIDLabel.ForeColor = System.Drawing.Color.White;
            this.examIDLabel.Location = new System.Drawing.Point(677, 45);
            this.examIDLabel.Name = "examIDLabel";
            this.examIDLabel.Size = new System.Drawing.Size(79, 17);
            this.examIDLabel.TabIndex = 4;
            this.examIDLabel.Text = "Exam ID: ";
            this.examIDLabel.Click += new System.EventHandler(this.examIDLabel_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(169, 693);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(82, 29);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // tutorialLabel2
            // 
            this.tutorialLabel2.AutoSize = true;
            this.tutorialLabel2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialLabel2.ForeColor = System.Drawing.Color.White;
            this.tutorialLabel2.Location = new System.Drawing.Point(65, 252);
            this.tutorialLabel2.Name = "tutorialLabel2";
            this.tutorialLabel2.Size = new System.Drawing.Size(467, 51);
            this.tutorialLabel2.TabIndex = 6;
            this.tutorialLabel2.Text = "2. While attempting the paper, you can navigate to the previous \r\n    and next qu" +
                "estion using the \'previous\' and \'next\' buttons.\r\n    (Refer to fig 2)";
            this.tutorialLabel2.Click += new System.EventHandler(this.tutorialLabel2_Click);
            // 
            // tutorialLabel3
            // 
            this.tutorialLabel3.AutoSize = true;
            this.tutorialLabel3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialLabel3.ForeColor = System.Drawing.Color.White;
            this.tutorialLabel3.Location = new System.Drawing.Point(62, 408);
            this.tutorialLabel3.Name = "tutorialLabel3";
            this.tutorialLabel3.Size = new System.Drawing.Size(508, 85);
            this.tutorialLabel3.TabIndex = 7;
            this.tutorialLabel3.Text = resources.GetString("tutorialLabel3.Text");
            this.tutorialLabel3.Click += new System.EventHandler(this.tutorialLabel3_Click);
            // 
            // tutorialLabel4
            // 
            this.tutorialLabel4.AutoSize = true;
            this.tutorialLabel4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialLabel4.ForeColor = System.Drawing.Color.White;
            this.tutorialLabel4.Location = new System.Drawing.Point(65, 562);
            this.tutorialLabel4.Name = "tutorialLabel4";
            this.tutorialLabel4.Size = new System.Drawing.Size(476, 85);
            this.tutorialLabel4.TabIndex = 8;
            this.tutorialLabel4.Text = resources.GetString("tutorialLabel4.Text");
            this.tutorialLabel4.Click += new System.EventHandler(this.tutorialLabel4_Click);
            // 
            // figLabel1
            // 
            this.figLabel1.AutoSize = true;
            this.figLabel1.ForeColor = System.Drawing.Color.White;
            this.figLabel1.Location = new System.Drawing.Point(736, 236);
            this.figLabel1.Name = "figLabel1";
            this.figLabel1.Size = new System.Drawing.Size(33, 13);
            this.figLabel1.TabIndex = 12;
            this.figLabel1.Text = "Fig 1.";
            // 
            // figLabel2
            // 
            this.figLabel2.AutoSize = true;
            this.figLabel2.ForeColor = System.Drawing.Color.White;
            this.figLabel2.Location = new System.Drawing.Point(736, 420);
            this.figLabel2.Name = "figLabel2";
            this.figLabel2.Size = new System.Drawing.Size(33, 13);
            this.figLabel2.TabIndex = 13;
            this.figLabel2.Text = "Fig 2.";
            // 
            // figLabel3
            // 
            this.figLabel3.AutoSize = true;
            this.figLabel3.ForeColor = System.Drawing.Color.White;
            this.figLabel3.Location = new System.Drawing.Point(736, 634);
            this.figLabel3.Name = "figLabel3";
            this.figLabel3.Size = new System.Drawing.Size(33, 13);
            this.figLabel3.TabIndex = 14;
            this.figLabel3.Text = "Fig 3.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication10.Properties.Resources.timer2;
            this.pictureBox3.Location = new System.Drawing.Point(578, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(405, 127);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication10.Properties.Resources.navigation;
            this.pictureBox2.Location = new System.Drawing.Point(578, 281);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(405, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication10.Properties.Resources.bookmark2;
            this.pictureBox1.Location = new System.Drawing.Point(578, 464);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1028, 746);
            this.ControlBox = false;
            this.Controls.Add(this.figLabel3);
            this.Controls.Add(this.figLabel2);
            this.Controls.Add(this.figLabel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tutorialLabel4);
            this.Controls.Add(this.tutorialLabel3);
            this.Controls.Add(this.tutorialLabel2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.examIDLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.proceed);
            this.Controls.Add(this.tutorialLabel1);
            this.Controls.Add(this.tutorialLabel);
            this.Name = "Tutorial";
            this.Text = "Skill Set Assessment System";
            this.Load += new System.EventHandler(this.Tutorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tutorialLabel;
        private System.Windows.Forms.Label tutorialLabel1;
        private System.Windows.Forms.Button proceed;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label examIDLabel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label tutorialLabel2;
        private System.Windows.Forms.Label tutorialLabel3;
        private System.Windows.Forms.Label tutorialLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label figLabel1;
        private System.Windows.Forms.Label figLabel2;
        private System.Windows.Forms.Label figLabel3;
    }
}