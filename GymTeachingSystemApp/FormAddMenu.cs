using GymTeachingSystemApp.ViewModels;
using GymTeachingSystemService.dll;
using GymTeachingSystemService.dll.Core;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymTeachingSystemApp
{
	public partial class FormAddMenu : Form, IGrid
	{
		private readonly int _menuId;
		private List<Menu_EquipmentVM> vm2;
		private List<TrainingEquipmentVM> vm;
		public FormAddMenu(int menuId)
		{
			InitializeComponent();
			_menuId = menuId;
		}
		private void FormAddMenu_Load(object sender, EventArgs e)
		{
			
			IMenuRepository repo = new SqlMenuRepository();
			MenuService service = new MenuService(repo);

			MenuEditDto dto = service.Get(this._menuId);
			MenuEditVM vm = dto.ToVM();
			txtMenuName.Text = vm.MenuName;

			comboBox1.Items.Add(new ComboBoxItem(null, ""));
			comboBox1.Items.Add(new ComboBoxItem("1", "手部"));
			comboBox1.Items.Add(new ComboBoxItem("2", "胸部"));
			comboBox1.Items.Add(new ComboBoxItem("3", "腿部"));
			comboBox1.Items.Add(new ComboBoxItem("4", "背部"));
			comboBox1.Items.Add(new ComboBoxItem("5", "肩部"));
			comboBox1.Items.Add(new ComboBoxItem("6", "腹部"));
			Display();
		}
		public void Display()
		{
			string equipmentName = txtEquipment.Text;
			int? partId;
			bool result = int.TryParse(ComboUtil.GetItem(comboBox1).Value, out int a);
			if (result && !string.IsNullOrEmpty(ComboUtil.GetItem(comboBox1).Value)) partId = a;
			else partId = null;
			
			ITrainingEquipmentRepository repo = new SqlTrainingEquipmentRepository();
			TrainingEquipmentService service = new TrainingEquipmentService(repo);

			vm = service.Search(equipmentName, partId)
			   .Select(x => x.ToVM())
			   .ToList();

			dataGridView1.DataSource = vm;

			
			IMenu_EquipmentRepository repo2 = new SqlMenu_EquipmentRepository();
			Menu_EquipmentService service2 = new Menu_EquipmentService(repo2);

			vm2 = service2.Search(_menuId)
			   .Select(x => x.ToVM())
			   .ToList();

			dataGridView2.DataSource = vm2;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			int equipmentId = vm[e.RowIndex].Id;
			Menu_EquipmentAddVM vm2 = new Menu_EquipmentAddVM()
			{
				Fk_EquipmentId = equipmentId,
				Fk_MenuId = _menuId
			};
			Menu_EquipmentAddDto dto =vm2.ToDto();
			IMenu_EquipmentRepository repo = new SqlMenu_EquipmentRepository();
			Menu_EquipmentService service = new Menu_EquipmentService(repo);
			service.Create(dto);
			Display();
		}

		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			int menu_EquipmentId = vm2[e.RowIndex].Id;
			var frm = new FormEditMenu(menu_EquipmentId);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
			
		}

		private void btnComplete_Click(object sender, EventArgs e)
		{
			string MenuName = txtMenuName.Text;
			MenuEditVM vm = new MenuEditVM()
			{
				MenuName = MenuName,
				MenuId = _menuId
			};
			MenuEditDto dto =vm.ToDto();
			IMenuRepository repo = new SqlMenuRepository();
			MenuService service = new MenuService(repo);
			service.Update(dto);
			MessageBox.Show("紀錄更新成功");
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

		private void btnDeleteMenu_Click(object sender, EventArgs e)
		{
			IMenuRepository repo = new SqlMenuRepository();
			MenuService service = new MenuService(repo);
			var diolog = MessageBox.Show("確認是否要刪除", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (diolog != DialogResult.Yes) { return; }
			else
			{
				try
				{
					service.Delete(_menuId);
				}
				catch
				{
					MessageBox.Show("有關聯的資料，無法刪除");
					return;
				}
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
}
