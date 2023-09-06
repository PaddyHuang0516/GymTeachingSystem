using GymTeachingSystemService.dll.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymTeachingSystemService.dll.Dtos
{
	public class UserAddDto
	{
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public int? Height { get; set; }
		public int? Weight { get; set; }
	}
	public static class UserEntityExts
	{
		public static UserEntity ToEntity(this UserAddDto dto)
		{
			return new UserEntity(dto.Name, dto.Account, dto.Password, dto.Height, dto.Weight);
		}
	}


	public class UserEditDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public int? Height { get; set; }
		public int? Weight { get; set; }
	}
	public static class UserEditDtoExts
	{
		public static UserEntity ToEntity(this UserEditDto dto)
		{
			return new UserEntity(dto.Name, dto.Account, dto.Password, dto.Height, dto.Weight, dto.Id);
		}

		public static UserEditDto ToEDto(this UserEntity entity)
		{
			return new UserEditDto
			{
				Id = entity.Id,
				Name = entity.Name,
				Account = entity.Account,
				Password = entity.Password,
				Height = entity.Height,
				Weight = entity.Weight
			};
		}
	}

    public class UserEditPasswordDto
    {
		public string Name { get; set; }
		public string Account { get; set; }
		public int Id { get; set; }
        public string Password { get; set; }
    }

    public static class UserEditPasswordDtoExts
    {
        public static UserEntity ToEntity(this UserEditPasswordDto dto)
        {
            return new UserEntity(dto.Name, dto.Account, dto.Password, null, null, dto.Id);
        }

        public static UserEditPasswordDto ToEPDto(this UserEntity entity)
        {
            return new UserEditPasswordDto
            {
				Name = entity.Name,
				Account = entity.Account,
                Id = entity.Id,
                Password = entity.Password
            };
        }
    }
}
