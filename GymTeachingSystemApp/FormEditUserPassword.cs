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
using System.Xml.Linq;

namespace GymTeachingSystemApp
{
    public partial class FormEditUserPassword : Form
    {
        private readonly int _userId;
        public FormEditUserPassword(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

		private void FormEditUserPassword_Load(object sender, EventArgs e)
		{
			IUserRepository repo = new SqlUserRepository();
			UserService service = new UserService(repo);

			UserEditPasswordDto dto = service.GetPassword(_userId);
			UserEditPasswordVM vm = dto.ToVM();

			txtShowOriginPassword.Text = vm.Password;
		}

		private void btnEditPassword_Click(object sender, EventArgs e)
		{
			bool isEqual = txtShowOriginPassword.Text == txtOriginPassword.Text;
			if (isEqual == false) 
			{
				MessageBox.Show("原密碼輸入錯誤");
				return;

			}
			if (txtNewPassword.Text != txtNewPasswordAgain.Text)
			{
				MessageBox.Show("新密碼兩次輸入結果不同");
				return;
			}
			if(txtNewPassword.Text== txtShowOriginPassword.Text)
			{
				MessageBox.Show("新密碼不可與原密碼相同");
				return;
			}
			UserEditPasswordVM vm = new UserEditPasswordVM()
			{
				Id = _userId,
				Password = txtNewPassword.Text,
				
			};
			//todo 驗證欄位

			UserEditPasswordDto dto = vm.ToDto();

			IUserRepository repo = new SqlUserRepository();
			UserService service = new UserService(repo);
			try
			{
				service.UpdatePassword(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗，原因:" + ex.Message);
				return;
			}


			//新增完成，關閉自己，並通知owner更新內容
			IGrid owner = this.Owner as IGrid;
			if (owner == null)
			{
				MessageBox.Show("忘了實作喔");
			}
			else
			{
				owner.Display();
			}

			this.DialogResult = DialogResult.OK;//自動關閉本表單
			
		}
	}
}
