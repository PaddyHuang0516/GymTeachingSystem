namespace GymTeachingSystemApp
{
	partial class FormEditPassword
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
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "輸入原密碼:";
			// 
			// txtOriginPassword
			// 
			this.txtOriginPassword.Location = new System.Drawing.Point(115, 26);
			this.txtOriginPassword.Name = "txtOriginPassword";
			this.txtOriginPassword.PasswordChar = '*';
			this.txtOriginPassword.Size = new System.Drawing.Size(100, 22);
			this.txtOriginPassword.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "輸入新密碼:";
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.Location = new System.Drawing.Point(115, 65);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.PasswordChar = '*';
			this.txtNewPassword.Size = new System.Drawing.Size(100, 22);
			this.txtNewPassword.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(41, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "再次輸入新密碼:";
			// 
			// txtNewPasswordAgain
			// 
			this.txtNewPasswordAgain.Location = new System.Drawing.Point(139, 104);
			this.txtNewPasswordAgain.Name = "txtNewPasswordAgain";
			this.txtNewPasswordAgain.PasswordChar = '*';
			this.txtNewPasswordAgain.Size = new System.Drawing.Size(100, 22);
			this.txtNewPasswordAgain.TabIndex = 1;
			// 
			// btnEditPassword
			// 
			this.btnEditPassword.Location = new System.Drawing.Point(164, 153);
			this.btnEditPassword.Name = "btnEditPassword";
			this.btnEditPassword.Size = new System.Drawing.Size(75, 23);
			this.btnEditPassword.TabIndex = 2;
			this.btnEditPassword.Text = "修改";
			this.btnEditPassword.UseVisualStyleBackColor = true;
			// 
			// FormEditPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 208);
			this.Controls.Add(this.btnEditPassword);
			this.Controls.Add(this.txtNewPasswordAgain);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNewPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtOriginPassword);
			this.Controls.Add(this.label1);
			this.Name = "FormEditPassword";
			this.Text = "FormEditPassword";
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
	}
}