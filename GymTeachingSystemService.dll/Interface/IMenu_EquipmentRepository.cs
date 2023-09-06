using GymTeachingSystemService.dll.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTeachingSystemService.dll.Interface
{
	public interface IMenu_EquipmentRepository
	{

		Menu_EquipmentEntity Get(int menu_equipmentId);

		void Create(Menu_EquipmentEntity entity);

		void Delete(int menu_equipmentId);

		void Update(Menu_EquipmentEntity entity);

		List<Menu_EquipmentEntity> Search(int menuId);
	}
}
