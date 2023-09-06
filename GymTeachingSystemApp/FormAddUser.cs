using GymTeachingSystemApp.ViewModels;
using GymTeachingSystemService.dll.Dtos;
using GymTeachingSystemService.dll.Infra.Sql;
using GymTeachingSystemService.dll.Interface;
using GymTeachingSystemService.dll.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymTeachingSystemApp
{
	public partial class FormAddUser : Form
	{
		public FormAddUser()
		{
			InitializeComponent();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			//檢查欄位
			string name = txtName.Text;
			bool isPasswordEqual=(txtPassword.Text==txtPasswordAgain.Text)? true: false;
			
			if (isPasswordEqual==false)
			{
				MessageBox.Show("兩次輸入的密碼必須相同");
				return;
			}
			string account = txtAccount.Text;
			bool isIntHeight = int.TryParse(txtHeight.Text, out int height);
			if (isIntHeight==false)
			{
				MessageBox.Show("身高必須填入整數");
				return;
			}
            bool isIntWeight = int.TryParse(txtHeight.Text, out int weight);
            if (isIntWeight == false)
            {
                MessageBox.Show("體重必須填入整數");
				return;
            }

			UserAddVM vm = new UserAddVM()
			{
				Name = name,
				Account = account,
				Password = txtPassword.Text,
				Height = height,
				Weight = weight
			};
			// todo驗證欄位是否正確

			//轉成dto
			UserAddDto dto= vm.ToDto();

			IUserRepository repo = new SqlUserRepository();
			UserService service = new UserService(repo);
			try {
				service.Create(dto);
				MessageBox.Show("帳號新增完成");
			}catch (Exception ex) { 
				MessageBox.Show(ex.Message);
				return;
			}
			
			this.DialogResult = DialogResult.OK;

        }

        private void txtPasswordAgain_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
