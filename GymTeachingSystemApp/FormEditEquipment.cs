using GymTeachingSystemApp.ViewModels;
using GymTeachingSystemService.dll;
using GymTeachingSystemService.dll.Infra.Sql;
using GymTeachingSystemService.dll.Interface;
using GymTeachingSystemService.dll.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymTeachingSystemApp
{
	public partial class FormEditEquipment : Form
	{
		private readonly int _equipmentId;
		private readonly int _userId;
		
		public FormEditEquipment(int equipmentId, int userId)
		{
			InitializeComponent();
			_equipmentId = equipmentId;
			_userId = userId;
			
		}

		private void FormEditEquipment_Load(object sender, EventArgs e)

		{
			if (_userId > 0)
			{
				btndelete.Visible = false;
				btnEditEquipment.Visible = false;
			}
			comboBox1.Items.Add(new ComboBoxItem(null, ""));
			comboBox1.Items.Add(new ComboBoxItem("1", "手部"));
			comboBox1.Items.Add(new ComboBoxItem("2", "胸部"));
			comboBox1.Items.Add(new ComboBoxItem("3", "腿部"));
			comboBox1.Items.Add(new ComboBoxItem("4", "背部"));
			comboBox1.Items.Add(new ComboBoxItem("5", "肩部"));
			comboBox1.Items.Add(new ComboBoxItem("6", "腹部"));
			
			ITrainingEquipmentRepository repo = new SqlTrainingEquipmentRepository();
			TrainingEquipmentService service = new TrainingEquipmentService(repo);

			TrainingEquipmentEditDto dto = service.Get(this._equipmentId);
			TrainingEquipmentEditVM vm = dto.ToVM();
			txtName.Text = vm.Name;
			//todo設定combox讀取vm
			txtDescription.Text = vm.Description;
			txtUrls.Text = vm.Image;
			comboBox1.SelectedIndex = vm.PartId.Value;

		}

		private void btnEditEquipment_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			int? partId;
			bool result = int.TryParse(ComboUtil.GetItem(comboBox1).Value, out int a);
			if (result && !string.IsNullOrEmpty(ComboUtil.GetItem(comboBox1).Value)) partId = a;
			else partId = null;
			string image = txtUrls.Text;
			string description = txtDescription.Text;

			TrainingEquipmentEditVM vm = new TrainingEquipmentEditVM()
			{
				Id = _equipmentId,
				Name = name,
				PartId = partId,
				Description = description,
				Image = image,
			};

			//todo 驗證個欄位是否正確


			//vm轉成dto
			TrainingEquipmentEditDto dto = vm.ToDto();

			ITrainingEquipmentRepository repo = new SqlTrainingEquipmentRepository();
			TrainingEquipmentService service = new TrainingEquipmentService(repo);
			try
			{
				service.Update(dto);
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

		private void btndelete_Click(object sender, EventArgs e)
		{
			ITrainingEquipmentRepository repo = new SqlTrainingEquipmentRepository();
			TrainingEquipmentService service = new TrainingEquipmentService(repo);
			var diolog = MessageBox.Show("確認是否要刪除", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (diolog != DialogResult.Yes) { return; }
			else
			{
				try
				{
					service.Delete(_equipmentId);
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
