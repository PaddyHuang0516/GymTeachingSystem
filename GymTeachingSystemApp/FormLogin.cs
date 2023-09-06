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
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

        private void btnLogin_Click(object sender, EventArgs e)
        {
			IUserRepository userRepository = new SqlUserRepository();
			UserService service = new UserService(userRepository);

			try
			{
				bool validatation = service.IsValid(txtAccount.Text,txtPassword.Text);
				if (validatation == false)
				{
					MessageBox.Show("帳號或密碼有誤，請再試一次");
					return;
				}
				int UserId = userRepository.GetByAccount(txtAccount.Text).Id;
				var frm = new FormMain(UserId);
				this.Hide();
				frm.Owner = this;
				frm.ShowDialog();
				
				txtAccount.Text = string.Empty;
				txtPassword.Text = string.Empty;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
        }

		private void lblCreatAccount_Click(object sender, EventArgs e)
		{
			var frm = new FormAddUser();
			frm.ShowDialog(); 
			
			txtAccount.Text = string.Empty;
			txtPassword.Text = string.Empty;
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			txtAccount.Text = "87";
			txtPassword.Text = "87";
		}
	}
}
