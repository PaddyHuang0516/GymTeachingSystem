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
	public class SqlMenu_EquipmentRepository : IMenu_EquipmentRepository 
	{
		
		public void Create(Menu_EquipmentEntity entity)
		{
			string sql = "insert into menu_equipment(fk_menuId,fk_EquipmentId)values(@fk_menuId,@fk_EquipmentId)";
			var parameters = SqlParameterBuilder.Create()
				.AddNullableInt("@fk_menuId", entity.Fk_MenuId)
				.AddNullableInt("@fk_EquipmentId", entity.Fk_EquipmentId)
				.Build();

			SqlDb.Create(SqlDb.GetConnection, sql, parameters);
		}

		

		public void Delete(int menu_equipmentId)
		{
			string sql = "delete from menu_equipment where menu_equipmentid =" + menu_equipmentId;

			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, null);
		}

		
		public Menu_EquipmentEntity Get(int menu_equipmentId)
		{
			string sql = "select * from menu_equipment where Menu_EquipmentId=" + menu_equipmentId;

			Func<SqlDataReader, Menu_EquipmentEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Menu_EquipmentId", 0);
				int fk_MenuId = reader.GetInt32("Fk_MenuId", 0);
				int fk_EquipmentId = reader.GetInt32("Fk_EquipmentId", 0);
				int reps = reader.GetInt32("Reps", 0);
				int sets = reader.GetInt32("Sets", 0);
				
				
				

				return new Menu_EquipmentEntity(null, null, fk_EquipmentId, fk_MenuId, reps, sets, id);
			};

			return SqlDb.Get<Menu_EquipmentEntity>(SqlDb.GetConnection, funcAssembler, sql, null);
		}

		
		public List<Menu_EquipmentEntity> Search(int menuId)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();
			string sql = "select * from menu_equipment " +
				" join Menus on fk_MenuId = MenuId\r\njoin Equipments on fk_EquipmentId = EquipmentId\r\njoin Parts on PartId = fk_PartId";

			//組合出where條件
			string where = string.Empty;

			where += " Fk_MenuId = " + menuId.ToString();


			where = string.IsNullOrEmpty(where) ? string.Empty : " where " + where;
			sql += where;

			sql += " order by menu_equipmentId";

			Func<SqlDataReader, Menu_EquipmentEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("menu_equipmentId", 0);
				int fk_MenuId = reader.GetInt32("Fk_MenuId", 0);
				int fk_EquipmentId = reader.GetInt32("Fk_EquipmentId", 0);
				int reps = reader.GetInt32("Reps", 0);
				int sets = reader.GetInt32("Sets", 0);
				string equipmentName = reader.GetString("EquipmentName");
				string partName = reader.GetString("PartName");

				return new Menu_EquipmentEntity(equipmentName, partName, fk_EquipmentId, fk_MenuId, reps, sets, id);
			};

			return SqlDb.Search(SqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
		}

		public void Update(Menu_EquipmentEntity entity)
		{
			string sql = "update menu_equipment set Reps = @Reps, Sets = @Sets where Menu_EquipmentId=@Menu_EquipmentId";

			var parameters = SqlParameterBuilder.Create()
				.AddInt("@Reps", entity.Reps)
				.AddInt("@Sets", entity.Sets)
				.AddInt("@Menu_EquipmentId", entity.Id)
				.Build();

			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
		}
		
	}
}
