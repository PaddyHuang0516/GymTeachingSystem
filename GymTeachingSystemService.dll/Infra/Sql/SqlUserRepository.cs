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
	public class SqlUserRepository : IUserRepository
	{
		public User GetByAccount(string account)
		{
			string sql = "select * from Users where Account=@Account";

			SqlParameter parameter = new SqlParameter("@Account", System.Data.SqlDbType.NVarChar, 50) { Value = account };

			Func<SqlDataReader, User> funcAssembler = reader =>
			{

				int id = reader.GetInt32("Id", 0);
				string acc = reader.GetString("Account");
				string password = reader.GetString("Password");
				return new User() { Id = id, Account = acc, Password = password };

			};


			return SqlDb.Get<User>(SqlDb.GetConnection, funcAssembler, sql, parameter);
		}

		public UserEntity Get(int userId)
		{
			string sql = "select * from users where id=" + userId;

			Func<SqlDataReader, UserEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id", 0);
				string name = reader.GetString("Name");
				string account = reader.GetString("Account");
				string password = reader.GetString("Password");
				int height = reader.GetInt32("Height", 0);
				int weight = reader.GetInt32("Weight", 0);
				return new UserEntity(name,account,password,height,weight,id);
			};

			return SqlDb.Get<UserEntity>(SqlDb.GetConnection, funcAssembler, sql, null);
		}

		public void Create(UserEntity entity)
		{
			string sql = "INSERT INTO users(Name,Account,Password,Height,Weight)VALUES(@Name,@Account,@Password,@Height,@Weight)";

			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@Name", 50, entity.Name)
				.AddNvarchar("@Account", 50, entity.Account)
				.AddNvarchar("@Password", 50, entity.Password)
				.AddNullableInt("@Height", entity.Height)
				.AddNullableInt("@Weight", entity.Weight)
				.Build();

			SqlDb.Create(SqlDb.GetConnection, sql, parameters);
		}

		public void Update(UserEntity entity)
		{
			string sql = "update users set name = @name, Account = @Account,Password=@Password,Height=@Height,Weight=@Weight where Id=@Id";

			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@Name", 50, entity.Name)
				.AddNvarchar("@Account", 50, entity.Account)
				.AddNvarchar("@Password", 50, entity.Password)
				.AddNullableInt("@Height", entity.Height)
				.AddNullableInt("@Weight", entity.Weight)
				.AddInt("@Id",entity.Id)
				.Build();

			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
		}

        public void UpdatePassword(UserEntity entity)
        {
            string sql = "update users set Password=@Password where Id=@Id";

            var parameters = SqlParameterBuilder.Create()
                
                .AddNvarchar("@Password", 50, entity.Password)
				.AddInt("@Id", entity.Id)
				.Build();

            SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
        }

        public List<UserEntity> Search(string userAccount)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();
			string sql = "select * from users where Account =@Account";
			parameters.Add(new SqlParameter("@Account", System.Data.SqlDbType.NVarChar, 50) { Value = userAccount });
			

			Func<SqlDataReader, UserEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id", 0);
				string name = reader.GetString("Name");
				string account = reader.GetString("Account");
				string password = reader.GetString("Password");
				int height = reader.GetInt32("Height", 0);
				int weight = reader.GetInt32("Weight", 0);
				return new UserEntity(name, account, password, height, weight, id);
			};

			return SqlDb.Search(SqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
		}
	}
}
