using GymTeachingSystemService.dll.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymTeachingSystemService.dll.Dtos
{
	public class Menu_EquipmentDto
	{
		public int Id { get; set; }
		public int? Fk_MenuId { get; set; }
		public int? Fk_EquipmentId { get; set; }
		
		public int Reps { get; set; }
		
		public int Sets { get; set; }
		
		public string EquipmentName { get; set; }
		
		public string PartName { get; set; }
	}
	public static class Menu_EquipmentEntityExts
	{
		public static Menu_EquipmentDto ToDto(this Menu_EquipmentEntity entity)
		{
			return new Menu_EquipmentDto()
			{
				Id = entity.Id,
				Fk_MenuId = entity.Fk_MenuId,
				Fk_EquipmentId = entity.Fk_EquipmentId,
				Reps = entity.Reps,
				Sets = entity.Sets,
				EquipmentName = entity.EquipmentName,
				PartName = entity.PartName
			};
		}
	}
	public class Menu_EquipmentAddDto
	{


		
		public int? Fk_MenuId { get; set; }
		public int? Fk_EquipmentId { get; set; }
		

	}
	public static class Menu_EquipmentAddDtoExts
	{
		public static Menu_EquipmentEntity ToEntity(this Menu_EquipmentAddDto dto)
		{
			return new Menu_EquipmentEntity(null,null,dto.Fk_EquipmentId,dto.Fk_MenuId);
		}
	}


	public class Menu_EquipmentEditDto
	{
		public int Id { get; set; }
		public int Reps { get; set; }
		public int Sets { get; set; }
	
	}
	public static class Menu_EquipmentEditDtoExts
	{
		public static Menu_EquipmentEntity ToEntity(this Menu_EquipmentEditDto dto)
		{
			return new Menu_EquipmentEntity(null,null,null,null,dto.Reps,dto.Sets,dto.Id);
		}
		public static Menu_EquipmentEditDto ToEditDto(this Menu_EquipmentEntity entity)
		{
			return new Menu_EquipmentEditDto()
			{
				Id = entity.Id,
				Reps = entity.Reps,
				Sets = entity.Sets,
			};
		}
	}
}
