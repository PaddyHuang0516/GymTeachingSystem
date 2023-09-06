namespace GymTeachingSystemApp
{
	partial class FormEditUser
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
			this.lblAccount = new System.Windows.Forms.Label();
			this.txtHeight = new System.Windows.Forms.TextBox();
			this.txtWeight = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnEditPassword = new System.Windows.Forms.Button();
			this.btnEditUser = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.labBMI = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtName.Location = new System.Drawing.Point(104, 134);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 23);
			this.txtName.TabIndex = 0;
			// 
			// lblAccount
			// 
			this.lblAccount.AutoSize = true;
			this.lblAccount.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblAccount.Location = new System.Drawing.Point(114, 66);
			this.lblAccount.Name = "lblAccount";
			this.lblAccount.Size = new System.Drawing.Size(71, 16);
			this.lblAccount.TabIndex = 2;
			this.lblAccount.Text = "lblAccount";
			// 
			// txtHeight
			// 
			this.txtHeight.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtHeight.Location = new System.Drawing.Point(104, 175);
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Size = new System.Drawing.Size(100, 23);
			this.txtHeight.TabIndex = 1;
			// 
			// txtWeight
			// 
			this.txtWeight.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtWeight.Location = new System.Drawing.Point(104, 218);
			this.txtWeight.Name = "txtWeight";
			this.txtWeight.Size = new System.Drawing.Size(100, 23);
			this.txtWeight.TabIndex = 2;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPassword.Location = new System.Drawing.Point(67, 96);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(79, 16);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "lblPassword";
			this.lblPassword.Visible = false;
			// 
			// btnEditPassword
			// 
			this.btnEditPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnEditPassword.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnEditPassword.ForeColor = System.Drawing.Color.Orange;
			this.btnEditPassword.Location = new System.Drawing.Point(186, 89);
			this.btnEditPassword.Name = "btnEditPassword";
			this.btnEditPassword.Size = new System.Drawing.Size(75, 23);
			this.btnEditPassword.TabIndex = 3;
			this.btnEditPassword.Text = "修改密碼";
			this.btnEditPassword.UseVisualStyleBackColor = false;
			this.btnEditPassword.Visible = false;
			this.btnEditPassword.Click += new System.EventHandler(this.btnEditPassword_Click);
			// 
			// btnEditUser
			// 
			this.btnEditUser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnEditUser.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnEditUser.ForeColor = System.Drawing.Color.Orange;
			this.btnEditUser.Location = new System.Drawing.Point(472, 295);
			this.btnEditUser.Name = "btnEditUser";
			this.btnEditUser.Size = new System.Drawing.Size(75, 23);
			this.btnEditUser.TabIndex = 3;
			this.btnEditUser.Text = "編輯";
			this.btnEditUser.UseVisualStyleBackColor = false;
			this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.ForeColor = System.Drawing.Color.Orange;
			this.label8.Location = new System.Drawing.Point(20, 62);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 21);
			this.label8.TabIndex = 23;
			this.label8.Text = "使用者帳號:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.ForeColor = System.Drawing.Color.Orange;
			this.label7.Location = new System.Drawing.Point(21, 92);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 21);
			this.label7.TabIndex = 22;
			this.label7.Text = "密碼:";
			this.label7.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.ForeColor = System.Drawing.Color.Orange;
			this.label6.Location = new System.Drawing.Point(21, 175);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 21);
			this.label6.TabIndex = 21;
			this.label6.Text = "身高:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label9.ForeColor = System.Drawing.Color.Orange;
			this.label9.Location = new System.Drawing.Point(21, 219);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(46, 21);
			this.label9.TabIndex = 20;
			this.label9.Text = "體重:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label10.ForeColor = System.Drawing.Color.Orange;
			this.label10.Location = new System.Drawing.Point(20, 135);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(78, 21);
			this.label10.TabIndex = 27;
			this.label10.Text = "你的名字:";
			// 
			// labBMI
			// 
			this.labBMI.AutoSize = true;
			this.labBMI.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labBMI.ForeColor = System.Drawing.Color.Orange;
			this.labBMI.Location = new System.Drawing.Point(309, 134);
			this.labBMI.Name = "labBMI";
			this.labBMI.Size = new System.Drawing.Size(164, 120);
			this.labBMI.TabIndex = 30;
			this.labBMI.Text = "27";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label13.ForeColor = System.Drawing.Color.Orange;
			this.label13.Location = new System.Drawing.Point(220, 213);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(89, 21);
			this.label13.TabIndex = 29;
			this.label13.Text = "你的BMI是";
			// 
			// FormEditUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(586, 349);
			this.Controls.Add(this.labBMI);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnEditUser);
			this.Controls.Add(this.btnEditPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblAccount);
			this.Controls.Add(this.txtWeight);
			this.Controls.Add(this.txtHeight);
			this.Controls.Add(this.txtName);
			this.Name = "FormEditUser";
			this.Text = "602, 388";
			this.Load += new System.EventHandler(this.FormEditUser_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblAccount;
		private System.Windows.Forms.TextBox txtHeight;
		private System.Windows.Forms.TextBox txtWeight;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnEditPassword;
		private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labBMI;
        private System.Windows.Forms.Label label13;
	}
}