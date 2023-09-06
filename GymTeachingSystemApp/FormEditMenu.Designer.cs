namespace GymTeachingSystemApp
{
	partial class FormEditMenu
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
			this.txtReps = new System.Windows.Forms.TextBox();
			this.txtSets = new System.Windows.Forms.TextBox();
			this.btnEditItemInMenu = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtReps
			// 
			this.txtReps.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtReps.Location = new System.Drawing.Point(117, 33);
			this.txtReps.Name = "txtReps";
			this.txtReps.Size = new System.Drawing.Size(100, 23);
			this.txtReps.TabIndex = 0;
			// 
			// txtSets
			// 
			this.txtSets.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtSets.Location = new System.Drawing.Point(117, 71);
			this.txtSets.Name = "txtSets";
			this.txtSets.Size = new System.Drawing.Size(100, 23);
			this.txtSets.TabIndex = 1;
			// 
			// btnEditItemInMenu
			// 
			this.btnEditItemInMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnEditItemInMenu.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnEditItemInMenu.ForeColor = System.Drawing.Color.Orange;
			this.btnEditItemInMenu.Location = new System.Drawing.Point(129, 119);
			this.btnEditItemInMenu.Name = "btnEditItemInMenu";
			this.btnEditItemInMenu.Size = new System.Drawing.Size(75, 23);
			this.btnEditItemInMenu.TabIndex = 2;
			this.btnEditItemInMenu.Text = "編輯";
			this.btnEditItemInMenu.UseVisualStyleBackColor = false;
			this.btnEditItemInMenu.Click += new System.EventHandler(this.btnEditItemInMenu_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDelete.ForeColor = System.Drawing.Color.Orange;
			this.btnDelete.Location = new System.Drawing.Point(44, 119);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "刪除";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.ForeColor = System.Drawing.Color.Orange;
			this.label6.Location = new System.Drawing.Point(33, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 21);
			this.label6.TabIndex = 23;
			this.label6.Text = "每組次數:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.ForeColor = System.Drawing.Color.Orange;
			this.label5.Location = new System.Drawing.Point(33, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 21);
			this.label5.TabIndex = 22;
			this.label5.Text = "組數:";
			// 
			// FormEditMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(253, 179);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEditItemInMenu);
			this.Controls.Add(this.txtSets);
			this.Controls.Add(this.txtReps);
			this.Name = "FormEditMenu";
			this.Text = "FormEditMenu";
			this.Load += new System.EventHandler(this.FormEditMenu_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtReps;
		private System.Windows.Forms.TextBox txtSets;
		private System.Windows.Forms.Button btnEditItemInMenu;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
	}
}