namespace WindowsFormsApplication10
{
    partial class ChangePassword
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
            this.initalLabel = new System.Windows.Forms.Label();
            this.newLabel = new System.Windows.Forms.Label();
            this.verifyLabel = new System.Windows.Forms.Label();
            this.initialText = new System.Windows.Forms.TextBox();
            this.newText = new System.Windows.Forms.TextBox();
            this.verifyText = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.changePasswordText = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initalLabel
            // 
            this.initalLabel.AutoSize = true;
            this.initalLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initalLabel.ForeColor = System.Drawing.Color.White;
            this.initalLabel.Location = new System.Drawing.Point(308, 143);
            this.initalLabel.Name = "initalLabel";
            this.initalLabel.Size = new System.Drawing.Size(117, 17);
            this.initalLabel.TabIndex = 0;
            this.initalLabel.Text = "Initial Password";
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLabel.ForeColor = System.Drawing.Color.White;
            this.newLabel.Location = new System.Drawing.Point(308, 184);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(109, 17);
            this.newLabel.TabIndex = 1;
            this.newLabel.Text = "New Password";
            // 
            // verifyLabel
            // 
            this.verifyLabel.AutoSize = true;
            this.verifyLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyLabel.ForeColor = System.Drawing.Color.White;
            this.verifyLabel.Location = new System.Drawing.Point(308, 224);
            this.verifyLabel.Name = "verifyLabel";
            this.verifyLabel.Size = new System.Drawing.Size(120, 17);
            this.verifyLabel.TabIndex = 2;
            this.verifyLabel.Text = "Verify Password";
            // 
            // initialText
            // 
            this.initialText.Location = new System.Drawing.Point(531, 143);
            this.initialText.Name = "initialText";
            this.initialText.Size = new System.Drawing.Size(100, 20);
            this.initialText.TabIndex = 3;
            this.initialText.UseSystemPasswordChar = true;
            // 
            // newText
            // 
            this.newText.Location = new System.Drawing.Point(531, 184);
            this.newText.Name = "newText";
            this.newText.Size = new System.Drawing.Size(100, 20);
            this.newText.TabIndex = 4;
            this.newText.UseSystemPasswordChar = true;
            // 
            // verifyText
            // 
            this.verifyText.Location = new System.Drawing.Point(531, 224);
            this.verifyText.Name = "verifyText";
            this.verifyText.Size = new System.Drawing.Size(100, 20);
            this.verifyText.TabIndex = 5;
            this.verifyText.UseSystemPasswordChar = true;
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.White;
            this.change.Location = new System.Drawing.Point(547, 332);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(70, 30);
            this.change.TabIndex = 6;
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // changePasswordText
            // 
            this.changePasswordText.AutoSize = true;
            this.changePasswordText.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordText.ForeColor = System.Drawing.Color.White;
            this.changePasswordText.Location = new System.Drawing.Point(400, 50);
            this.changePasswordText.Name = "changePasswordText";
            this.changePasswordText.Size = new System.Drawing.Size(170, 24);
            this.changePasswordText.TabIndex = 7;
            this.changePasswordText.Text = "Change Password";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(322, 332);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 30);
            this.back.TabIndex = 8;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.ControlBox = false;
            this.Controls.Add(this.back);
            this.Controls.Add(this.changePasswordText);
            this.Controls.Add(this.change);
            this.Controls.Add(this.verifyText);
            this.Controls.Add(this.newText);
            this.Controls.Add(this.initialText);
            this.Controls.Add(this.verifyLabel);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.initalLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.Text = "Skill Set Assessment System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label initalLabel;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.Label verifyLabel;
        private System.Windows.Forms.TextBox initialText;
        private System.Windows.Forms.TextBox newText;
        private System.Windows.Forms.TextBox verifyText;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label changePasswordText;
        private System.Windows.Forms.Button back;
    }
}