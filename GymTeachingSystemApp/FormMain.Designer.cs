namespace GymTeachingSystemApp
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			this.btnFormMain = new System.Windows.Forms.Button();
			this.btnEquipment = new System.Windows.Forms.Button();
			this.btnMenu = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnLogout = new System.Windows.Forms.Button();
			this.lblHi = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnUser = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFormMain
			// 
			this.btnFormMain.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.btnFormMain.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnFormMain.ForeColor = System.Drawing.Color.Orange;
			this.btnFormMain.Location = new System.Drawing.Point(-2, 92);
			this.btnFormMain.Name = "btnFormMain";
			this.btnFormMain.Size = new System.Drawing.Size(123, 40);
			this.btnFormMain.TabIndex = 0;
			this.btnFormMain.Text = "首頁";
			this.btnFormMain.UseVisualStyleBackColor = false;
			this.btnFormMain.Click += new System.EventHandler(this.btnFormMain_Click);
			// 
			// btnEquipment
			// 
			this.btnEquipment.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.btnEquipment.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnEquipment.ForeColor = System.Drawing.Color.Orange;
			this.btnEquipment.Location = new System.Drawing.Point(-2, 132);
			this.btnEquipment.Name = "btnEquipment";
			this.btnEquipment.Size = new System.Drawing.Size(123, 40);
			this.btnEquipment.TabIndex = 0;
			this.btnEquipment.Text = "器材";
			this.btnEquipment.UseVisualStyleBackColor = false;
			this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
			// 
			// btnMenu
			// 
			this.btnMenu.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.btnMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnMenu.ForeColor = System.Drawing.Color.Orange;
			this.btnMenu.Location = new System.Drawing.Point(-2, 172);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(123, 40);
			this.btnMenu.TabIndex = 0;
			this.btnMenu.Text = "訓練菜單";
			this.btnMenu.UseVisualStyleBackColor = false;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Location = new System.Drawing.Point(122, 60);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(602, 388);
			this.panel1.TabIndex = 1;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::GymTeachingSystemApp.Properties.Resources._1683797199760;
			this.pictureBox2.Location = new System.Drawing.Point(109, 32);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(385, 328);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLogout.ForeColor = System.Drawing.Color.Orange;
			this.btnLogout.Location = new System.Drawing.Point(-2, 408);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(123, 40);
			this.btnLogout.TabIndex = 0;
			this.btnLogout.Text = "登出";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// lblHi
			// 
			this.lblHi.AutoSize = true;
			this.lblHi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblHi.ForeColor = System.Drawing.Color.Orange;
			this.lblHi.Location = new System.Drawing.Point(0, 48);
			this.lblHi.Name = "lblHi";
			this.lblHi.Size = new System.Drawing.Size(56, 21);
			this.lblHi.TabIndex = 2;
			this.lblHi.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.ForeColor = System.Drawing.Color.Orange;
			this.label2.Location = new System.Drawing.Point(261, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(209, 40);
			this.label2.TabIndex = 3;
			this.label2.Text = "橙汁汗健身房";
			// 
			// btnUser
			// 
			this.btnUser.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.btnUser.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnUser.ForeColor = System.Drawing.Color.Orange;
			this.btnUser.Location = new System.Drawing.Point(-2, 212);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(123, 40);
			this.btnUser.TabIndex = 0;
			this.btnUser.Text = "個人資料";
			this.btnUser.UseVisualStyleBackColor = false;
			this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::GymTeachingSystemApp.Properties.Resources._1683795625776;
			this.pictureBox1.Location = new System.Drawing.Point(219, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 45);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(724, 448);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblHi);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnUser);
			this.Controls.Add(this.btnMenu);
			this.Controls.Add(this.btnEquipment);
			this.Controls.Add(this.btnFormMain);
			this.Name = "FormMain";
			this.Text = "橙汁漢健身房";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnFormMain;
		private System.Windows.Forms.Button btnEquipment;
		private System.Windows.Forms.Button btnMenu;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label lblHi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}

