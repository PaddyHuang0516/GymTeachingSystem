using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTeachingSystemService.dll.Core
{
    public class TrainingEquipmentEntity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public string TrainingPartName { get; private set; }
		public int? PartId { get; private set; }

		public TrainingEquipmentEntity(string name ,string description,string image,string trainingPartName,int?partId ,int id = 0 )
        {
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.TrainingPartName = trainingPartName;
            this.PartId = partId;
            this.Id = id;
        }
    }

   
}
