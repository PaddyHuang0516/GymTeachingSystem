using GymTeachingSystemService.dll;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymTeachingSystemApp.ViewModels
{
    public class TrainingEquipmentVM
    {
        public int Id { get; set; }
		[Display(Name = "名稱")]
        
        public string Name { get; set; }
        [Display(Name = "使用說明")]
        
        public string Description { get; set; }
        [Display(Name = "圖片")]
        public string Image { get; set; }
        [Display(Name = "訓練部位")]
        public string TrainingPartName { get; set;}
    }

    public static class TrainingEquipmentDtoExts
    {
        public static TrainingEquipmentVM ToVM (this TrainingEquipmentDto dto)
        {
            return new TrainingEquipmentVM
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                Image = dto.Image,
                TrainingPartName = dto.TrainingPartName,
            };
        }
    }


    public class TrainingEquipmentAddVM
    {
        public int? PartId { get; set; }
        [Display(Name = "名稱")]
        [Required(ErrorMessage = "{0}為必填")]
        public string Name { get; set; }
        [Display(Name = "使用說明")]
        [Required(ErrorMessage = "{0}為必填")]
        public string Description { get; set; }
        [Display(Name = "圖片")]
        public string Image { get; set;}
    }

    public static class TrainingEquipmentAddVMExts
    {
        public static TrainingEquipmentAddDto ToDto(this TrainingEquipmentAddVM dto)
        {
            return new TrainingEquipmentAddDto
            {
                PartId = dto.PartId,
                Name = dto.Name,
                Description = dto.Description,
                Image = dto.Image,
             
            };
        }
    }


    public class TrainingEquipmentEditVM
    {
        public int Id { get; set; }
        public int? PartId { get; set; }
        [Display(Name = "名稱")]
        [Required(ErrorMessage = "{0}為必填")]
        public string Name { get; set; }
        [Display(Name = "使用說明")]
        [Required(ErrorMessage = "{0}為必填")]
        public string Description { get; set; }
        [Display(Name = "圖片")]
        public string Image { get; set; }
    }

    public static class TrainingEquipmentEditVMExts
    {
        public static TrainingEquipmentEditVM ToVM(this TrainingEquipmentEditDto dto)
        {
            return new TrainingEquipmentEditVM
			{
                Id = dto.Id,
                PartId = dto.PartId,
                Name = dto.Name,
                Description = dto.Description,
                Image = dto.Image,

            };
        }

        public static TrainingEquipmentEditDto ToDto(this TrainingEquipmentEditVM dto)
        {
            return new TrainingEquipmentEditDto
            {
                Id = dto.Id,
                PartId = dto.PartId,
                Name = dto.Name,
                Description = dto.Description,
                Image = dto.Image,

            };
        }
    }
}
