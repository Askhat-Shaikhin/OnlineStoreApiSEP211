using Dapper;
using OnlineStore.Model;
using OnlineStore.Repo.Interfaces;
using System.Data.SqlClient;

namespace OnlineStore.Repo.Impl
{
    public class UserRepository : IUserRepository
    {
        private const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=OnlineStoreDb;TrustServerCertificate=True;Trusted_Connection=True";

        public async Task<ApplicationUser> GetUserByUserName(string userName)
        {
            var query = @"select top 1 * from ApplicationUsers where UserName = @userName";

            using var db = new SqlConnection(connectionString);

            var result = await db.QueryFirstOrDefaultAsync<ApplicationUser>(query, new { userName });

            return result;
        }

        public async Task<ApplicationUser> GetUserByAppUserId(int id)
        {
            var query = @"select top 1 * from ApplicationUsers where Id = @id";

            using var db = new SqlConnection(connectionString);

            var result = await db.QueryFirstOrDefaultAsync<ApplicationUser>(query, new { id });

            return result;
        }

        public async Task<int> InsertUser(ApplicationUser user)
        {
            var query = @"
                INSERT INTO [dbo].[ApplicationUsers]
                           ([UserName]
                           ,[Email]
                           ,[PhoneNumber]
                           ,[Password])
                     OUTPUT INSERTED.Id
                     VALUES
                           (@UserName
                           ,@Email
                           ,@PhoneNumber
                           ,@Password";
            
            var param = new DynamicParameters();
            param.Add("@UserName", user.UserName);
            param.Add("@Email", user.Email);
            param.Add("@PhoneNumber", user.PhoneNumber);
            param.Add("@Password", user.Password);

            using var db = new SqlConnection(connectionString);
            var userId = await db.ExecuteAsync(query, param);
            return userId;
        }

        public async Task UpdateUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
