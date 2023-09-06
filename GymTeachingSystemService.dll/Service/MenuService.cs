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
    public class MenuService
    {
		private readonly IMenuRepository _repo;
		public MenuService(IMenuRepository repo)
		{
			_repo = repo;
		}
		public void Create(MenuAddDto dto)
		{
			MenuEntity entity = dto.ToEntity();
			_repo.Create(entity);
		}
		
		public void Update(MenuEditDto dto)
		{
			MenuEntity entity = dto.ToEntity();
			_repo.Update(entity);
		}
		
		public void Delete(int menuId)
		{
			_repo.Delete(menuId);
		}
		public List<MenuDto> Search(string menuName, int userId)
		{
			List<MenuEntity> data = _repo.Search(menuName, userId);
			return data.Select(x => x.ToDto()).ToList();
		}
		public MenuEditDto Get(int menuId)
		{
			return _repo.Get(menuId).ToEditDto();
		}
	}
}
