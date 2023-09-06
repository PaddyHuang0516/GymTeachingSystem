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
    public class SqlMenuRepository : IMenuRepository
    {
        public void Create(MenuEntity entity)
        {
            string sql = "INSERT INTO MENUS(fk_UserId)VALUES(@fk_userId)";
            //"INSERT INTO MENUS(Name,EquipmentName,PartName,PartId,EquipmentId,UserId,Reps,Sets,DisplayOrder,Image)VALUES(@Name,@EquipmentName,@PartName,@PartId,@EquipmentId,@UserId,@Reps,@Sets,@DisplayOrder)"
            var parameters = SqlParameterBuilder.Create()
                .AddNullableInt("@fk_UserId", entity.Fk_UserId)
                .Build();

            SqlDb.Create(SqlDb.GetConnection, sql, parameters);
        }
       

        public void Delete(int menuId)
        {
			string sql = "delete from menu_equipment where fk_MenuId =" + menuId;
            string sql2 = "delete from menus where MenuId = " + menuId;
            sql += sql2;
			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, null);
		}
		

		public MenuEntity Get(int menuId)
        {
			string sql = "select * from menus where Menuid=" + menuId;

			Func<SqlDataReader, MenuEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("MenuId", 0);
				string MenuName = reader.GetString("MenuName");
				int fk_userId = reader.GetInt32("fk_UserId", 0);

				return new MenuEntity(MenuName, fk_userId, id);
			};

			return SqlDb.Get<MenuEntity>(SqlDb.GetConnection, funcAssembler, sql, null);
		}
		

		public List<MenuEntity> Search(string menuName,int userId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string sql = "select * from menus " ;
                
            //組合出where條件
            string where = string.Empty;
            if (string.IsNullOrEmpty(menuName) == false)
            {
                where += " MenuName like '%'+ @MenuName + '%'  and (fk_UserId = 0 or fk_UserId = " + userId +")";

				parameters.Add(new SqlParameter("@MenuName", System.Data.SqlDbType.NVarChar, 20) {Value = menuName});
            }

            where = string.IsNullOrEmpty(where) ? string.Empty : " where " + where;
            sql += where;

            sql += " order by fk_UserId";

            Func<SqlDataReader, MenuEntity> funcAssembler = reader =>
            {
				int id = reader.GetInt32("MenuId", 0);
				string MenuName = reader.GetString("MenuName");
				int fk_userId = reader.GetInt32("fk_UserId", 0);

				return new MenuEntity(MenuName, fk_userId, id);
			};

            return SqlDb.Search(SqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
        }
       

		public void Update(MenuEntity entity)
		{
			string sql = "update menus set MenuName = @MenuName where MenuId=@MenuId";

			var parameters = SqlParameterBuilder.Create()
				
				.AddNvarchar("@MenuName", 20 ,entity.MenuName)
				.AddInt("@MenuId", entity.MenuId)
				.Build();

			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
		}
	}
}
