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
    public partial class FormMain : Form
    {
        private readonly int _userId;
        public FormMain(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }


		private Form activeForm = null;
		public void OpenChildForm(Form childForm)
		{
			if (activeForm != null) activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panel1.Controls.Add(childForm);
			panel1.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
            this.Owner.Show();
		}

		private void btnUser_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormEditUser(_userId));
		}

		private void btnEquipment_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormEquipment(_userId));
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormMenu(_userId));
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			IUserRepository repo = new SqlUserRepository();
			UserService service = new UserService(repo);

			UserEditDto dto = service.Get(_userId);
			UserEditVM vm = dto.ToVM();

			lblHi.Text = "Hi~" + vm.Name + "\r\n今天健身了嗎";

		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			var diolog = MessageBox.Show("確定要登出嗎?", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (diolog != DialogResult.Yes) { return; }
			else
			{
                this.DialogResult = DialogResult.OK;//自動關閉本表單 }
            }
		}

        private void btnFormMain_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormToMain());
        }
    }
}
