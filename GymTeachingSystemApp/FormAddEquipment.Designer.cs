namespace GymTeachingSystemApp
{
	partial class FormAddEquipment
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
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnAddEquipment = new System.Windows.Forms.Button();
			this.txtUrls = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDescription.Location = new System.Drawing.Point(93, 155);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(328, 286);
			this.txtDescription.TabIndex = 3;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtName.Location = new System.Drawing.Point(93, 33);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 23);
			this.txtName.TabIndex = 0;
			// 
			// btnAddEquipment
			// 
			this.btnAddEquipment.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnAddEquipment.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnAddEquipment.ForeColor = System.Drawing.Color.Orange;
			this.btnAddEquipment.Location = new System.Drawing.Point(346, 452);
			this.btnAddEquipment.Name = "btnAddEquipment";
			this.btnAddEquipment.Size = new System.Drawing.Size(75, 23);
			this.btnAddEquipment.TabIndex = 4;
			this.btnAddEquipment.Text = "新增";
			this.btnAddEquipment.UseVisualStyleBackColor = false;
			this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
			// 
			// txtUrls
			// 
			this.txtUrls.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtUrls.Location = new System.Drawing.Point(93, 112);
			this.txtUrls.Name = "txtUrls";
			this.txtUrls.Size = new System.Drawing.Size(328, 23);
			this.txtUrls.TabIndex = 2;
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(93, 71);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.ForeColor = System.Drawing.Color.Orange;
			this.label5.Location = new System.Drawing.Point(12, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 21);
			this.label5.TabIndex = 16;
			this.label5.Text = "操作說明:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.ForeColor = System.Drawing.Color.Orange;
			this.label6.Location = new System.Drawing.Point(12, 109);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 21);
			this.label6.TabIndex = 17;
			this.label6.Text = "網址:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.ForeColor = System.Drawing.Color.Orange;
			this.label7.Location = new System.Drawing.Point(9, 71);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 21);
			this.label7.TabIndex = 18;
			this.label7.Text = "訓練部位:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.ForeColor = System.Drawing.Color.Orange;
			this.label8.Location = new System.Drawing.Point(12, 34);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 21);
			this.label8.TabIndex = 19;
			this.label8.Text = "名稱:";
			// 
			// FormAddEquipment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(453, 500);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.txtUrls);
			this.Controls.Add(this.btnAddEquipment);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtName);
			this.Name = "FormAddEquipment";
			this.Text = "新增器材";
			this.Load += new System.EventHandler(this.FormAddEquipment_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnAddEquipment;
		private System.Windows.Forms.TextBox txtUrls;
		private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}