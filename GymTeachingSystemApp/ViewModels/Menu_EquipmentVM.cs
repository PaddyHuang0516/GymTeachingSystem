using GymTeachingSystemService.dll.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymTeachingSystemApp.ViewModels
{
	public class Menu_EquipmentVM
	{
		public int Id { get; set; }
		public int? Fk_MenuId { get; set; }
		public int? Fk_EquipmentId { get; set;}
		[Display(Name = "每組次數")]
		public int Reps { get; set; }
		[Display(Name = "組數")]
		public int Sets { get; set; }
		[Display(Name = "訓練器材")]
		public string EquipmentName { get; set; }
		[Display(Name = "訓練部位")]
		public string PartName { get; set; }

	}
	public static class MenuMenu_EquipmentDtoExts
	{
		public static Menu_EquipmentVM ToVM(this Menu_EquipmentDto dto)
		{
			return new Menu_EquipmentVM()
			{
				Id = dto.Id,
				Fk_EquipmentId = dto.Fk_EquipmentId,
				Fk_MenuId = dto.Fk_MenuId,
				Reps = dto.Reps,
				Sets = dto.Sets,
				EquipmentName = dto.EquipmentName,
				PartName = dto.PartName,
			};
		}
	}

	public class Menu_EquipmentAddVM
	{
		public int? Fk_MenuId { get; set; }
		public int? Fk_EquipmentId { get; set; }
	}
	public static class Menu_EquipmentAddVMExts
	{
		public static Menu_EquipmentAddDto ToDto(this Menu_EquipmentAddVM vm)
		{
			return new Menu_EquipmentAddDto()
			{
				Fk_MenuId = vm.Fk_MenuId,
				Fk_EquipmentId = vm.Fk_EquipmentId,
			};
		}
	}



	public class Menu_EquipmentEditVM
	{
		public int Id { get; set; }
		[Display(Name = "每組次數")]
		public int Reps { get; set; }
		[Display(Name = "組數")]
		public int Sets { get; set; }
		
	}

	public static class Menu_EquipmentEditVMExts
	{
		public static Menu_EquipmentEditVM ToVM(this Menu_EquipmentEditDto dto)
		{
			return new Menu_EquipmentEditVM()
			{
				Id = dto.Id,
				Reps = dto.Reps,
				Sets = dto.Sets,
			};
		}
		public static Menu_EquipmentEditDto ToDto(this Menu_EquipmentEditVM vm)
		{
			return new Menu_EquipmentEditDto()
			{
				Id = vm.Id,
				Reps = vm.Reps,
				Sets = vm.Sets,
			};
		}
	}
}
