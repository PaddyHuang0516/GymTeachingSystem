using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTeachingSystemService.dll.Core
{
	public class MenuEntity
	{
		public int MenuId { get; private set; }
		public string MenuName { get; private set; }
		public int? Fk_UserId { get; private set; }
		

        public MenuEntity(string menuName,int? fk_UserId ,int menuId = 0)
        {
            this.MenuName = menuName;
			this.Fk_UserId = fk_UserId;
			this.MenuId = menuId;

        }
    }
}
