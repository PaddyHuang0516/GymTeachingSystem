using GymTeachingSystemApp.ViewModels;
using GymTeachingSystemService.dll.Infra.Sql;
using GymTeachingSystemService.dll.Interface;
using GymTeachingSystemService.dll.Service;
using GymTeachingSystemService.dll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using GymTeachingSystemService.dll.Dtos;

namespace GymTeachingSystemApp
{
	public partial class FormMenu : Form,IGrid
	{
		private readonly int _userId;
		private List<MenuVM> vm;
		public FormMenu(int userId)
		{
			InitializeComponent();
			_userId = userId;
		}

		private void btnAddMenu_Click(object sender, EventArgs e)
		{
			MenuAddVM vm = new MenuAddVM();
			//vm轉成dto
			MenuAddDto dto = vm.ToDto();

			IMenuRepository repo = new SqlMenuRepository();
			MenuService service = new MenuService(repo);
			service.Create(dto);
			Display();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			int menuId = vm[e.RowIndex].MenuId;

			var frm = new FormAddMenu(menuId);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		public void Display()
		{
			string name = txtMenuName.Text;

			IMenuRepository repo = new SqlMenuRepository();
			MenuService service = new MenuService(repo);

			vm = service.Search(name, _userId)
			   .Select(x => x.ToVM())
			   .ToList();

			dataGridView1.DataSource = vm;
		}

		private void FormMenu_Load(object sender, EventArgs e)
		{
			Display();
		}
	}
}
