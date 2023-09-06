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
	public partial class FormEditUser : Form,IGrid
	{
		private readonly int _userID;
		public FormEditUser(int userID)
		{
			InitializeComponent();
			_userID = userID;
		}

		private void FormEditUser_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void btnEditPassword_Click(object sender, EventArgs e)
		{
			var frm = new FormEditUserPassword(_userID);
			frm.Owner = this;
			frm.ShowDialog();

		}

        private void btnEditUser_Click(object sender, EventArgs e)
        {
			string name = txtName.Text;
            bool isIntHeight = int.TryParse(txtHeight.Text, out int height);
            if (isIntHeight == false)
            {
                MessageBox.Show("身高必須填入整數");
				return;
            }
            bool isIntWeight = int.TryParse(txtWeight.Text, out int weight);
            if (isIntWeight == false)
            {
                MessageBox.Show("身高必須填入整數");
                return;
            }
			UserEditVM vm = new UserEditVM()
			{
				Id = _userID,
				Name = name,
				Account = lblAccount.Text,
				Password = lblPassword.Text,
				Height = height,
				Weight = weight,
			};
			//todo 驗證欄位

			UserEditDto dto = vm.ToDto();

			IUserRepository repo = new SqlUserRepository();
			UserService service = new UserService(repo);

			service.Update(dto);

			MessageBox.Show("資料更新成功");
			Display();

		}

		public void Display()
		{
			IUserRepository repo = new SqlUserRepository();
			UserService service = new UserService(repo);

			UserEditDto dto = service.Get(_userID);
			UserEditVM vm = dto.ToVM();

			lblAccount.Text = vm.Account;
			lblPassword.Text = vm.Password;
			txtName.Text = vm.Name;
			txtHeight.Text = vm.Height.ToString();
			txtWeight.Text = vm.Weight.ToString();

			if (vm.Height.HasValue && vm.Weight.HasValue)
			{
				float? heightInMeters = vm.Height / 100.0f; // 轉換為米，使用浮點數運算以保持精確度
				double? bmi = vm.Weight / (heightInMeters * heightInMeters); // BMI公式：體重（公斤）/ 身高（米）的平方
				double roundBmi = Math.Round((double)bmi, 2);
				labBMI.Text = roundBmi.ToString();
			}
		}
	}
}
