using GymTeachingSystemService.dll.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTeachingSystemService.dll.Interface
{
    public interface ITrainingEquipmentRepository
    {
        void Create(TrainingEquipmentEntity entity);
        void Update(TrainingEquipmentEntity entity);
        void Delete(int trainingEquipmentId);
        TrainingEquipmentEntity Get(int trainingEquipmentId);
        List<TrainingEquipmentEntity> Search(string trainingEquipmentName, int? trainingPartId);
    }
}
