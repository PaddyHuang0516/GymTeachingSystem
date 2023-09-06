namespace GymTeachingSystemApp
{
	partial class FormAddUser
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtAccount = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtPasswordAgain = new System.Windows.Forms.TextBox();
			this.txtHeight = new System.Windows.Forms.TextBox();
			this.txtWeight = new System.Windows.Forms.TextBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(107, 10);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 22);
			this.txtName.TabIndex = 0;
			// 
			// txtAccount
			// 
			this.txtAccount.Location = new System.Drawing.Point(107, 41);
			this.txtAccount.Name = "txtAccount";
			this.txtAccount.Size = new System.Drawing.Size(100, 22);
			this.txtAccount.TabIndex = 1;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(107, 72);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(100, 22);
			this.txtPassword.TabIndex = 2;
			// 
			// txtPasswordAgain
			// 
			this.txtPasswordAgain.Location = new System.Drawing.Point(158, 103);
			this.txtPasswordAgain.Name = "txtPasswordAgain";
			this.txtPasswordAgain.PasswordChar = '*';
			this.txtPasswordAgain.Size = new System.Drawing.Size(100, 22);
			this.txtPasswordAgain.TabIndex = 3;
			this.txtPasswordAgain.TextChanged += new System.EventHandler(this.txtPasswordAgain_TextChanged);
			// 
			// txtHeight
			// 
			this.txtHeight.Location = new System.Drawing.Point(322, 9);
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Size = new System.Drawing.Size(100, 22);
			this.txtHeight.TabIndex = 4;
			// 
			// txtWeight
			// 
			this.txtWeight.Location = new System.Drawing.Point(322, 42);
			this.txtWeight.Name = "txtWeight";
			this.txtWeight.Size = new System.Drawing.Size(100, 22);
			this.txtWeight.TabIndex = 5;
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnCreate.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCreate.ForeColor = System.Drawing.Color.Orange;
			this.btnCreate.Location = new System.Drawing.Point(337, 101);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(85, 24);
			this.btnCreate.TabIndex = 6;
			this.btnCreate.Text = "創建";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.ForeColor = System.Drawing.Color.Orange;
			this.label8.Location = new System.Drawing.Point(270, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 21);
			this.label8.TabIndex = 23;
			this.label8.Text = "身高:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.ForeColor = System.Drawing.Color.Orange;
			this.label7.Location = new System.Drawing.Point(270, 44);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 21);
			this.label7.TabIndex = 22;
			this.label7.Text = "體重:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label11.ForeColor = System.Drawing.Color.Orange;
			this.label11.Location = new System.Drawing.Point(23, 10);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(78, 21);
			this.label11.TabIndex = 27;
			this.label11.Text = "你的名字:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label12.ForeColor = System.Drawing.Color.Orange;
			this.label12.Location = new System.Drawing.Point(26, 41);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(46, 21);
			this.label12.TabIndex = 26;
			this.label12.Text = "帳號:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label13.ForeColor = System.Drawing.Color.Orange;
			this.label13.Location = new System.Drawing.Point(26, 73);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(46, 21);
			this.label13.TabIndex = 25;
			this.label13.Text = "密碼:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label14.ForeColor = System.Drawing.Color.Orange;
			this.label14.Location = new System.Drawing.Point(26, 104);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(110, 21);
			this.label14.TabIndex = 24;
			this.label14.Text = "再次輸入密碼:";
			// 
			// FormAddUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(459, 153);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtWeight);
			this.Controls.Add(this.txtHeight);
			this.Controls.Add(this.txtPasswordAgain);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtAccount);
			this.Controls.Add(this.txtName);
			this.Name = "FormAddUser";
			this.Text = "新增使用者";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtAccount;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtPasswordAgain;
		private System.Windows.Forms.TextBox txtHeight;
		private System.Windows.Forms.TextBox txtWeight;
		private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}