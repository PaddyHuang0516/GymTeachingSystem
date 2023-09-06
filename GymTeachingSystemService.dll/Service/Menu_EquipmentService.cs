using GymTeachingSystemService.dll.Core;
using GymTeachingSystemService.dll.Dtos;
using GymTeachingSystemService.dll.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTeachingSystemService.dll.Service
{
	public class Menu_EquipmentService
	{
		private readonly IMenu_EquipmentRepository _repo;
		public Menu_EquipmentService(IMenu_EquipmentRepository repo)
		{
			_repo = repo;
		}
		
		public void Create(Menu_EquipmentAddDto dto)
		{
			Menu_EquipmentEntity entity = dto.ToEntity();
			_repo.Create(entity);
		}
		
		public void Update(Menu_EquipmentEditDto dto)
		{
			Menu_EquipmentEntity entity = dto.ToEntity();
			_repo.Update(entity);
		}
		

		public void Delete(int menu_equipmentId)
		{
			_repo.Delete(menu_equipmentId);
		}
		
		public List<Menu_EquipmentDto> Search(int menuId)
		{
			List<Menu_EquipmentEntity> data = _repo.Search(menuId);
			return data.Select(x => x.ToDto()).ToList();
		}
		public Menu_EquipmentEditDto Get(int menuId)
		{
			return _repo.Get(menuId).ToEditDto();
		}
	}
}
