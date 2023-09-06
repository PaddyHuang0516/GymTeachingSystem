using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTeachingSystemService.dll.Core
{
	public class UserEntity
	{
		public int Id { get; private set; }
		public string Name { get; private set; }
		public string Account { get; private set; }
		public string Password { get; private set; }
		public int? Height { get; private set; }
		public int? Weight { get; private set; }

        public UserEntity(string name,string account,string password,int? height,int? weight,int Id=0)
        {
            this.Name = name;
			this.Account = account;
			this.Password = password;
			this.Height = height;
			this.Weight = weight;
			this.Id = Id;
        }
    }
}
