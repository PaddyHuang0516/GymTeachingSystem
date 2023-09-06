using GymTeachingSystemService.dll.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTeachingSystemService.dll.Interface
{
	public interface IUserRepository
	{
		User GetByAccount(string account); //供登入使用
		UserEntity Get(int userId); //供編輯紀錄時使用
		void Create(UserEntity entity);
		void Update(UserEntity entity);
        void UpdatePassword(UserEntity entity);//供修改密碼
        List<UserEntity> Search(string categoryName);
	}


	public class User
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
	}

	//todo改架構
}
