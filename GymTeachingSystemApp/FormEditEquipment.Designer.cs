namespace GymTeachingSystemApp
{
	partial class FormEditEquipment
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
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.btnEditEquipment = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.txtUrls = new System.Windows.Forms.TextBox();
			this.btndelete = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtName.Location = new System.Drawing.Point(87, 38);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 23);
			this.txtName.TabIndex = 0;
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDescription.Location = new System.Drawing.Point(87, 155);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(328, 261);
			this.txtDescription.TabIndex = 3;
			// 
			// btnEditEquipment
			// 
			this.btnEditEquipment.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnEditEquipment.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnEditEquipment.ForeColor = System.Drawing.Color.Orange;
			this.btnEditEquipment.Location = new System.Drawing.Point(340, 451);
			this.btnEditEquipment.Name = "btnEditEquipment";
			this.btnEditEquipment.Size = new System.Drawing.Size(75, 23);
			this.btnEditEquipment.TabIndex = 4;
			this.btnEditEquipment.Text = "修改";
			this.btnEditEquipment.UseVisualStyleBackColor = false;
			this.btnEditEquipment.Click += new System.EventHandler(this.btnEditEquipment_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(87, 76);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 1;
			// 
			// txtUrls
			// 
			this.txtUrls.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtUrls.Location = new System.Drawing.Point(87, 114);
			this.txtUrls.Name = "txtUrls";
			this.txtUrls.Size = new System.Drawing.Size(328, 23);
			this.txtUrls.TabIndex = 2;
			// 
			// btndelete
			// 
			this.btndelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btndelete.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btndelete.ForeColor = System.Drawing.Color.Orange;
			this.btndelete.Location = new System.Drawing.Point(247, 451);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(75, 23);
			this.btndelete.TabIndex = 5;
			this.btndelete.Text = "刪除";
			this.btndelete.UseVisualStyleBackColor = false;
			this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.ForeColor = System.Drawing.Color.Orange;
			this.label8.Location = new System.Drawing.Point(6, 38);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 21);
			this.label8.TabIndex = 23;
			this.label8.Text = "名稱:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.ForeColor = System.Drawing.Color.Orange;
			this.label7.Location = new System.Drawing.Point(5, 75);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 21);
			this.label7.TabIndex = 22;
			this.label7.Text = "訓練部位:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.ForeColor = System.Drawing.Color.Orange;
			this.label6.Location = new System.Drawing.Point(6, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 21);
			this.label6.TabIndex = 21;
			this.label6.Text = "網址:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.ForeColor = System.Drawing.Color.Orange;
			this.label5.Location = new System.Drawing.Point(6, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 21);
			this.label5.TabIndex = 20;
			this.label5.Text = "操作說明:";
			// 
			// FormEditEquipment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(453, 500);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btnEditEquipment);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtUrls);
			this.Controls.Add(this.txtName);
			this.Name = "FormEditEquipment";
			this.Text = "編輯器材";
			this.Load += new System.EventHandler(this.FormEditEquipment_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button btnEditEquipment;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox txtUrls;
		private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}