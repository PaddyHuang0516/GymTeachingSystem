using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymTeachingSystemService.dll.Core
{
	public class Menu_EquipmentEntity
	{
		public int Id { get; private set; }
		public int? Fk_MenuId { get; private set; }
		public int? Fk_EquipmentId { get; private set; }
		
		public int Reps { get; private set; }
		
		public int Sets { get; private set; }
		
		public string EquipmentName { get; private set; }
	
		public string PartName { get; private set; }

		public Menu_EquipmentEntity( string equipmentName, string partName,int? fk_EquipmentId, int? fk_MenuId, int reps = 12, int sets = 3,  int id = 0)
		{
			
			this.EquipmentName = equipmentName;
			this.PartName = partName;
			this.Fk_EquipmentId = fk_EquipmentId;
			this.Fk_MenuId = fk_MenuId;
			this.Reps = reps;
			this.Sets = sets;
			this.Id = id;

		}
	}
}
