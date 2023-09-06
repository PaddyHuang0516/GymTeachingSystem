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
	public class UserService
	{
		private readonly IUserRepository _repo;
		public UserService(IUserRepository repo)
		{
			_repo = repo;
		}
		public bool IsValid(string account, string password)
		{
			if (string.IsNullOrEmpty(account)) { throw new ArgumentNullException(nameof(account)); }
			if (string.IsNullOrEmpty(password)) { throw new ArgumentNullException(nameof(password)); }

			User user = _repo.GetByAccount(account);
			if (user == null) { return false; }

			string passwordInDb = user.Password;

			return passwordInDb == password;
		}

		public void Create(UserAddDto dto)
		{
			//檢查account是否已存在
			var data = _repo.Search(dto.Account);
			if (data != null && data.Count > 0) throw new Exception("該帳號已存在");
			//若名稱是唯一的，允許新建紀錄
			UserEntity entity = dto.ToEntity();
			_repo.Create(entity);
		}

		public void Update(UserEditDto dto)
		{
			UserEntity entity = dto.ToEntity();
			_repo.Update(entity);
		}
        public void UpdatePassword(UserEditPasswordDto dto)
        {
            UserEntity entity = dto.ToEntity();
            _repo.Update(entity);
        }

        public UserEditDto Get(int userId)
		{
			return _repo.Get(userId).ToEDto();
		}

		public UserEditPasswordDto GetPassword(int userId)
		{
			return _repo.Get(userId).ToEPDto();
		}
	}

	
}
