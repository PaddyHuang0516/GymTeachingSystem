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
	public partial class FormEditMenu : Form
	{
		private readonly int _Menu_EquipmentId; 
		public FormEditMenu(int menu_EquipmentId)
		{
			InitializeComponent();
			_Menu_EquipmentId = menu_EquipmentId;
		}

		private void FormEditMenu_Load(object sender, EventArgs e)
		{
			IMenu_EquipmentRepository repo = new SqlMenu_EquipmentRepository();
			Menu_EquipmentService service = new Menu_EquipmentService(repo);

			Menu_EquipmentEditDto dto = service.Get(_Menu_EquipmentId);

			Menu_EquipmentEditVM vm = dto.ToVM();
			txtReps.Text = vm.Reps.ToString();
			txtSets.Text = vm.Sets.ToString();
		}

		private void btnEditItemInMenu_Click(object sender, EventArgs e)
		{
			int reps;
			int sets;
			bool isInt = int.TryParse(txtReps.Text, out int a);
			if (isInt) reps = a;
			else
			{
				MessageBox.Show("請輸入整數");
				return;
			};
			bool isInt2 = int.TryParse(txtSets.Text, out int a2);
			if (isInt2) sets = a2;
			else
			{
				MessageBox.Show("請輸入整數");
				return;
			};
			Menu_EquipmentEditVM vm = new Menu_EquipmentEditVM()
			{
				Id = _Menu_EquipmentId,
				Reps = reps,
				Sets = sets,
			};
			Menu_EquipmentEditDto dto =vm.ToDto();
			IMenu_EquipmentRepository repo = new SqlMenu_EquipmentRepository();
			Menu_EquipmentService service = new Menu_EquipmentService(repo);
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

		private void btnDelete_Click(object sender, EventArgs e)
		{
			IMenu_EquipmentRepository repo = new SqlMenu_EquipmentRepository();
			Menu_EquipmentService service = new Menu_EquipmentService(repo);

			var diolog = MessageBox.Show("確認是否要刪除", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (diolog != DialogResult.Yes) { return; }
			else
			{
				try
				{
					service.Delete(_Menu_EquipmentId);
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
