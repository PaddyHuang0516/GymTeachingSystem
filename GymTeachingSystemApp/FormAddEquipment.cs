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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymTeachingSystemApp
{
	public partial class FormAddEquipment : Form
	{
		public FormAddEquipment()
		{
			InitializeComponent();
		}

        private void FormAddEquipment_Load(object sender, EventArgs e)
        {
			comboBox1.Items.Add(new ComboBoxItem(null, ""));
			comboBox1.Items.Add(new ComboBoxItem("1", "手部"));
			comboBox1.Items.Add(new ComboBoxItem("2", "胸部"));
			comboBox1.Items.Add(new ComboBoxItem("3", "腿部"));
			comboBox1.Items.Add(new ComboBoxItem("4", "背部"));
			comboBox1.Items.Add(new ComboBoxItem("5", "肩部"));
			comboBox1.Items.Add(new ComboBoxItem("6", "腹部"));
		}

		private void btnAddEquipment_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			int? PartId;
			bool result = int.TryParse(ComboUtil.GetItem(comboBox1).Value, out int a);
			if (result && !string.IsNullOrEmpty(ComboUtil.GetItem(comboBox1).Value)) PartId = a;
			else PartId = null;
			string image = txtUrls.Text;
			string description =txtDescription.Text;
			TrainingEquipmentAddVM vm = new TrainingEquipmentAddVM()
			{
				Name = name,
				PartId = PartId,
				Image = image,
				Description = description,
			};

			//驗證個欄位是否正確

			//vm轉成dto
			TrainingEquipmentAddDto dto = vm.ToDto();

			ITrainingEquipmentRepository repo = new SqlTrainingEquipmentRepository();
			TrainingEquipmentService service = new TrainingEquipmentService(repo);

			service.Create(dto);

			//新增完成，關閉自己，並通知owner更新內容
			IGrid owner = (IGrid)this.Owner;
			owner.Display();

			this.DialogResult = DialogResult.OK;//自動關閉本表單
		}
	}
}
