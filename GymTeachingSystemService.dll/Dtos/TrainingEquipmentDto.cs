using GymTeachingSystemService.dll.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymTeachingSystemService.dll
{
    public class TrainingEquipmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TrainingPartName { get; set; }
    }

    public static class TrainingEquipmentJoinEntityExts
    {
        public static TrainingEquipmentDto ToDto(this TrainingEquipmentEntity entity)
        {
            return new TrainingEquipmentDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Image = entity.Image,
                TrainingPartName = entity.TrainingPartName,
            };
        }  
    }
    public class TrainingEquipmentAddDto
    {
        public int? PartId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }

    public static class TrainingEquipmentAddDtoExts
    {
        public static TrainingEquipmentEntity ToEntity(this TrainingEquipmentAddDto dto)
        {
            return new TrainingEquipmentEntity(dto.Name, dto.Description, dto.Image,null ,dto.PartId);
         
        }
    }

    public class TrainingEquipmentEditDto
    {
        public int Id { get; set; }
        public int? PartId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }

    public static class TrainingEquipmentEditDtoExts
    {
        public static TrainingEquipmentEditDto ToEditDto(this TrainingEquipmentEntity entity)
        {
            return new TrainingEquipmentEditDto
            {
                Id = entity.Id,
                PartId = entity.PartId,
                Name = entity.Name,
                Description = entity.Description,
                Image = entity.Image,
                
            };
        }
        public static TrainingEquipmentEntity ToEntity(this TrainingEquipmentEditDto dto)
        {
            return new TrainingEquipmentEntity(dto.Name, dto.Description, dto.Image,null ,dto.PartId,dto.Id);
        }
    }
}
