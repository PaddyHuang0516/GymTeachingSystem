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
    public class MenuVM
    {
        public int MenuId { get; set; }
        [Display(Name = "菜單")]
        public string MenuName { get; set; }
        public int? Fk_UserId { get; set; }
    }
    public static class MenuDtoExts
    {
        public static MenuVM ToVM(this MenuDto dto)
        {
            return new MenuVM()
            {
				MenuId = dto.MenuId,
				MenuName = dto.MenuName,
				Fk_UserId = dto.Fk_UserId,
            };
        }
    }

    public class MenuAddVM
    {
		public int UserId { get; set; }
    }
    public static class MenuAddVMExts
    {
        public static MenuAddDto ToDto(this MenuAddVM vm)
        {
            return new MenuAddDto()
            {
                Fk_UserId = vm.UserId,
            };
        }
	}



	public class MenuEditVM
    {
        public int MenuId { get; set; }
		[Display(Name = "菜單")]
		public string MenuName { get; set; }
		
	}

    public static class MenuEditVMExts
    {
        public static MenuEditVM ToVM(this MenuEditDto dto)
        {
            return new MenuEditVM()
            {
                MenuId = dto.MenuId,
                MenuName = dto.MenuName,
                
            };
        }
        public static MenuEditDto ToDto(this MenuEditVM vm)
        {
            return new MenuEditDto()
            {
                MenuId = vm.MenuId,
                MenuName = vm.MenuName,
               
            };
        }
	}
}
