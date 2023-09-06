using GymTeachingSystemService.dll.Core;
using GymTeachingSystemService.dll.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTeachingSystemService.dll.Infra.Sql
{
    public class SqlTrainingEquipmentRepository : ITrainingEquipmentRepository
    {
        public void Create(TrainingEquipmentEntity entity)
        {
            string sql = "INSERT INTO Equipments(EquipmentName,Fk_PartId,Description,Image)VALUES(@EquipmentName,@Fk_PartId,@Description,@Image)";

            var parameters = SqlParameterBuilder.Create()
                .AddNvarchar("@EquipmentName", 20, entity.Name)
                .AddNullableInt("@Fk_PartId", entity.PartId)
                .AddNvarchar("@Description",1000,entity.Description)
                .AddNvarchar("@Image",100,entity.Image)
                .Build();

            SqlDb.Create(SqlDb.GetConnection, sql, parameters);
        }

        public void Delete(int trainingEquipmentId)
        {
            string sql = "delete from Equipments where Equipmentid =" + trainingEquipmentId;

            SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, null);
        }

        public TrainingEquipmentEntity Get(int trainingEquipmentId)
        {
            string sql = "select * from Equipments where Equipmentid=" + trainingEquipmentId;

            Func<SqlDataReader, TrainingEquipmentEntity> funcAssembler = reader =>
            {
                int id = reader.GetInt32("EquipmentId", 0);
                string name = reader.GetString("EquipmentName");
                string description = reader.GetString("Description");
                string image = reader.GetString("image");
                int trainingPartId = reader.GetInt32("Fk_PartId", 0);
                return new TrainingEquipmentEntity(name, description,image, null,trainingPartId,id);
            };

            return SqlDb.Get<TrainingEquipmentEntity>(SqlDb.GetConnection, funcAssembler, sql, null);
        }

        public List<TrainingEquipmentEntity> Search(string trainingEquipmentName, int? trainingPartId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string sql = "select *" +
                " from Equipments e" +
                " join Parts p on p.PartId = e.fk_PartId";
                     
            //組合出where條件
            string where = string.Empty;
            if (string.IsNullOrEmpty(trainingEquipmentName) == false)
            {
                where += " and e.Equipmentname like '%'+ @name + '%'";
                parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.NVarChar, 20) { Value = trainingEquipmentName });
            }

            if (trainingPartId.HasValue)
            {
                where += " and p.Partid=" + trainingPartId.Value;
            }

            where = string.IsNullOrEmpty(where) ? string.Empty : " where " + where.Substring(5);
            sql += where;

            sql += " order by e.EquipmentId";

            Func<SqlDataReader, TrainingEquipmentEntity> funcAssembler = reader =>
            {
                int id = reader.GetInt32("EquipmentId", 0);
                string name = reader.GetString("EquipmentName");
                string description = reader.GetString("Description");
                string image = reader.GetString("Image");
                int PartId = reader.GetInt32("Fk_PartId", 0);
				string trainingPartName = reader.GetString("PartName");

                return new TrainingEquipmentEntity(name, description, image, trainingPartName, PartId, id);
            };

            return SqlDb.Search(SqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
        }

        public void Update(TrainingEquipmentEntity entity)
        {
            string sql = "update equipments set Equipmentname = @Equipmentname, Description = @Description,Image = @Image,Fk_PartId = @Fk_PartId where EquipmentId=@EquipmentId";

            var parameters = SqlParameterBuilder.Create()
                .AddInt("@EquipmentId", entity.Id)
                .AddNvarchar("@EquipmentName", 20, entity.Name)
                .AddNullableInt("@Fk_PartId", entity.PartId)
                .AddNvarchar("@Description", 1000, entity.Description)
                .AddNvarchar("Image", 100, entity.Image)
                .Build();

            SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
        }

		
	}
}
