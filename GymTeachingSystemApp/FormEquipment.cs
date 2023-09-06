using GymTeachingSystemApp.ViewModels;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymTeachingSystemApp
{
	public partial class FormEquipment : Form,IGrid
	{
		private List<TrainingEquipmentVM> vm;
		private readonly int _userId;
		public FormEquipment(int userId)
		{
			InitializeComponent();
			_userId = userId;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			int equipmentId = vm[e.RowIndex].Id;

			var frm = new FormEditEquipment(equipmentId, _userId);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void btnAddEquipment_Click(object sender, EventArgs e)
		{
			var frm = new FormAddEquipment();
			frm.Owner = this;
			frm.ShowDialog();
		}

		public void Display()
		{
			string name = txtEquipment.Text;
			int? PartId ;
			bool result =int.TryParse(ComboUtil.GetItem(comboBoxPart).Value,out int a);
			if (result && !string.IsNullOrEmpty(ComboUtil.GetItem(comboBoxPart).Value)) PartId = a;
			else PartId = null;


			//int? id = int.TryParse(txtId.Text, out int num) ? num : (int?)null;

			ITrainingEquipmentRepository repo = new SqlTrainingEquipmentRepository();
			TrainingEquipmentService service = new TrainingEquipmentService(repo);

			 vm = service.Search(name, PartId)
				.Select(x => x.ToVM())
				.ToList();

			dataGridView1.DataSource = vm;
		}

		private void FormEquipment_Load(object sender, EventArgs e)
		{
			if (_userId > 0)
			{
				btnAddEquipment.Visible = false;
			}
			comboBoxPart.Items.Add(new ComboBoxItem(null, ""));
			comboBoxPart.Items.Add(new ComboBoxItem("1", "手部"));
			comboBoxPart.Items.Add(new ComboBoxItem("2", "胸部"));
			comboBoxPart.Items.Add(new ComboBoxItem("3", "腿部"));
			comboBoxPart.Items.Add(new ComboBoxItem("4", "背部"));
			comboBoxPart.Items.Add(new ComboBoxItem("5", "肩部"));
			comboBoxPart.Items.Add(new ComboBoxItem("6", "腹部"));
			Display();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Display();
		}
	}
}
