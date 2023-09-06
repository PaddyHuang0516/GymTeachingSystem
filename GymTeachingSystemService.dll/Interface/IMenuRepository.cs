using GymTeachingSystemService.dll.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTeachingSystemService.dll.Interface
{
    public  interface IMenuRepository
    {
        MenuEntity Get(int menuId);
		
		 void Create(MenuEntity entity);
        
        void Delete(int menuId);
		
		void Update(MenuEntity entity);
		
		List<MenuEntity> Search(string menuName,int userId);
       
    }
}
