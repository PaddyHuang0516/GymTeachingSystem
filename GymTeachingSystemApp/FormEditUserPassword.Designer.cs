namespace GymTeachingSystemApp
{
    partial class FormEditUserPassword
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
			this.txtOriginPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNewPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNewPasswordAgain = new System.Windows.Forms.TextBox();
			this.btnEditPassword = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtShowOriginPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.Color.Orange;
			this.label1.Location = new System.Drawing.Point(13, 70);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "輸入原密碼:";
			// 
			// txtOriginPassword
			// 
			this.txtOriginPassword.Location = new System.Drawing.Point(120, 68);
			this.txtOriginPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtOriginPassword.Name = "txtOriginPassword";
			this.txtOriginPassword.PasswordChar = '*';
			this.txtOriginPassword.Size = new System.Drawing.Size(116, 23);
			this.txtOriginPassword.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.ForeColor = System.Drawing.Color.Orange;
			this.label2.Location = new System.Drawing.Point(13, 119);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "輸入新密碼:";
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.Location = new System.Drawing.Point(120, 117);
			this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.PasswordChar = '*';
			this.txtNewPassword.Size = new System.Drawing.Size(116, 23);
			this.txtNewPassword.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.ForeColor = System.Drawing.Color.Orange;
			this.label3.Location = new System.Drawing.Point(13, 172);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "再次確認密碼:";
			// 
			// txtNewPasswordAgain
			// 
			this.txtNewPasswordAgain.Location = new System.Drawing.Point(120, 170);
			this.txtNewPasswordAgain.Margin = new System.Windows.Forms.Padding(4);
			this.txtNewPasswordAgain.Name = "txtNewPasswordAgain";
			this.txtNewPasswordAgain.PasswordChar = '*';
			this.txtNewPasswordAgain.Size = new System.Drawing.Size(116, 23);
			this.txtNewPasswordAgain.TabIndex = 3;
			// 
			// btnEditPassword
			// 
			this.btnEditPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnEditPassword.ForeColor = System.Drawing.Color.Orange;
			this.btnEditPassword.Location = new System.Drawing.Point(85, 212);
			this.btnEditPassword.Margin = new System.Windows.Forms.Padding(4);
			this.btnEditPassword.Name = "btnEditPassword";
			this.btnEditPassword.Size = new System.Drawing.Size(88, 31);
			this.btnEditPassword.TabIndex = 4;
			this.btnEditPassword.Text = "修改";
			this.btnEditPassword.UseVisualStyleBackColor = false;
			this.btnEditPassword.Click += new System.EventHandler(this.btnEditPassword_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.ForeColor = System.Drawing.Color.Orange;
			this.label4.Location = new System.Drawing.Point(16, 24);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "原密碼:";
			// 
			// txtShowOriginPassword
			// 
			this.txtShowOriginPassword.Location = new System.Drawing.Point(120, 22);
			this.txtShowOriginPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtShowOriginPassword.Name = "txtShowOriginPassword";
			this.txtShowOriginPassword.PasswordChar = '*';
			this.txtShowOriginPassword.Size = new System.Drawing.Size(116, 23);
			this.txtShowOriginPassword.TabIndex = 0;
			// 
			// FormEditUserPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(259, 260);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnEditPassword);
			this.Controls.Add(this.txtNewPasswordAgain);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNewPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtShowOriginPassword);
			this.Controls.Add(this.txtOriginPassword);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormEditUserPassword";
			this.Text = "修改密碼";
			this.Load += new System.EventHandler(this.FormEditUserPassword_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPasswordAgain;
        private System.Windows.Forms.Button btnEditPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtShowOriginPassword;
	}
}