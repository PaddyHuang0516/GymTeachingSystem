using GymTeachingSystemService.dll;
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
	public class UserAddVM
	{
		[Display(Name = "你的名字")]
		[Required(ErrorMessage = "{0}為必填")]
		public string Name { get; set; }
		[Display(Name = "帳號")]
		[Required(ErrorMessage = "{0}為必填")]
		[MaxLength(20, ErrorMessage = "{0}長度不可大於{1}")]
		public string Account { get; set; }
		[Display(Name = "密碼")]
		[Required(ErrorMessage = "{0}為必填")]
		[MaxLength(20, ErrorMessage = "{0}長度不可大於{1}")]
		public string Password { get; set; }
		
		[Display(Name = "身高")]
		[Required(ErrorMessage = "{0}為必填")]
		[Range(0, 250, ErrorMessage ="請輸入正常{0}")]
		public int? Height { get; set; }
		[Display(Name = "體重")]
		[Required(ErrorMessage = "{0}為必填")]
		[Range(0, 500, ErrorMessage = "請輸入正常{0}")]
		public int? Weight { get; set; }

    }
	public static class UserADDDtoExts
	{
		public static UserAddDto ToDto(this UserAddVM vm)
		{
			return new UserAddDto
			{
				Name = vm.Name,
				Account = vm.Account,
				Password = vm.Password,
				Height = vm.Height,
				Weight = vm.Weight
			};
		}
	}


	public class UserEditVM
	{
        public int Id { get; set; }
        [Display(Name = "你的名字")]
		[Required(ErrorMessage = "{0}為必填")]
		public string Name { get; set; }
		[Display(Name = "帳號")]
		[Required(ErrorMessage = "{0}為必填")]
		[MaxLength(20, ErrorMessage = "{0}長度不可大於{1}")]
		public string Account { get; set; }
		[Display(Name = "密碼")]
		[Required(ErrorMessage = "{0}為必填")]
		[MaxLength(20, ErrorMessage = "{0}長度不可大於{1}")]
		
		public string Password { get; set; }
		[Display(Name = "身高")]
		[Required(ErrorMessage = "{0}為必填")]
		[Range(0, 250, ErrorMessage = "請輸入正常{0}")]
		public int? Height { get; set; }
		[Display(Name = "體重")]
		[Required(ErrorMessage = "{0}為必填")]
		[Range(0, 500, ErrorMessage = "請輸入正常{0}")]
		public int? Weight { get; set; }

	}

	public static class UserEditVMExts
	{
		public static UserEditDto ToDto(this UserEditVM vm)
		{
			return new UserEditDto
			{
				Id = vm.Id,
				Name = vm.Name,
				Account = vm.Account,
				Password = vm.Password,
				Height = vm.Height,
				Weight = vm.Weight
			};
		}

		public static UserEditVM ToVM(this UserEditDto dto)
		{
			return new UserEditVM
			{
				Id = dto.Id,
				Name = dto.Name,
				Account = dto.Account,
				Password = dto.Password,
				Height = dto.Height,
				Weight = dto.Weight
			};
		}
	}
    public class UserEditPasswordVM
	{
        public int Id { get; set; }
		public string Name { get; set; }
        public string Account { get; set; }

        [Display(Name = "密碼")]
        [Required(ErrorMessage = "{0}為必填")]
        [MaxLength(20, ErrorMessage = "{0}長度不可大於{1}")]
        public string Password { get; set; }
    }
    public static class UserEditPasswordVMExts
    {
        public static UserEditPasswordDto ToDto(this UserEditPasswordVM vm)
        {
            return new UserEditPasswordDto
            {

                Id = vm.Id,
				Name = vm.Name,
				Account = vm.Account,
                Password = vm.Password
            };
        }

        public static UserEditPasswordVM ToVM(this UserEditPasswordDto dto)
        {
            return new UserEditPasswordVM
            {
                Id = dto.Id,
				Name = dto.Name,
				Account = dto.Account,
                Password = dto.Password
            };
        }
    }
}
