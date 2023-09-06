using GymTeachingSystemService.dll.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymTeachingSystemService.dll.Dtos
{
	public class MenuDto
	{
		public int MenuId { get; set; }
		public string MenuName { get; set; }
		public int? Fk_UserId { get; set; }

	}
	public static class MenuEntityExts
	{
		public static MenuDto ToDto(this MenuEntity entity)
		{
			return new MenuDto()
			{
				MenuId = entity.MenuId,
				MenuName = entity.MenuName,
				Fk_UserId = entity.Fk_UserId
			};
		}
	}
	public class MenuAddDto
	{


		public int Fk_UserId { get; set; }

	}
	public static class MenuAddDtoExts
	{
		public static MenuEntity ToEntity(this MenuAddDto dto)
		{
			return new MenuEntity(null,dto.Fk_UserId); 
		}
	}


	public class MenuEditDto
	{
		public int MenuId { get; set; }
		public string MenuName { get; set; }
	}
	public static class MenuEditDtoExts
	{
		public static MenuEntity ToEntity(this MenuEditDto dto)
		{
			return new MenuEntity(dto.MenuName,null,dto.MenuId);
		}
		public static MenuEditDto ToEditDto(this MenuEntity entity)
		{
			return new MenuEditDto()
			{
				MenuId= entity.MenuId,
				MenuName= entity.MenuName,

			};
		}
	}
}
