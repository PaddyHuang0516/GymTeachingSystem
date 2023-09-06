using GymTeachingSystemService.dll.Core;
using GymTeachingSystemService.dll.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTeachingSystemService.dll.Service
{
	public class TrainingEquipmentService
	{
		private readonly ITrainingEquipmentRepository _repo;
		public TrainingEquipmentService(ITrainingEquipmentRepository repo)
		{
			_repo = repo;
		}

		public void Create(TrainingEquipmentAddDto dto)
		{
			//檢查name是否已存在
			var data = _repo.Search(dto.Name, null);
			if (data != null && data.Count > 0) throw new Exception("器材名稱已存在");
			//若名稱是唯一的，允許新建紀錄
			TrainingEquipmentEntity entity = dto.ToEntity();
			_repo.Create(entity);
		}
		public void Update(TrainingEquipmentEditDto dto)
		{
			//檢查Name是否已存在
			List<TrainingEquipmentEntity> data = _repo.Search(dto.Name, null);
			if (data != null && data.Count > 0)
			{
				if (data[0].Id != dto.Id)
				{
					throw new Exception("器材名稱已存在，不允許更新");
				}
			}
			TrainingEquipmentEntity entity = dto.ToEntity();
			_repo.Update(entity);

		}
		public void Delete(int equipmentId)
		{
			_repo.Delete(equipmentId);
		}
		public List<TrainingEquipmentDto> GetAll()
		{
			List<TrainingEquipmentEntity> data = _repo.Search(null, null);
			return data.Select(x => x.ToDto()).ToList();
		}
		public List<TrainingEquipmentDto> Search(string name, int? id)
		{
			List<TrainingEquipmentEntity> data = _repo.Search(name, id);
			return data.Select(x => x.ToDto()).ToList();
		}
		public TrainingEquipmentEditDto Get(int equipmentId)
		{
			return _repo.Get(equipmentId).ToEditDto();
		}
	}
}
