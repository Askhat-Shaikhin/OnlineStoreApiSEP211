using OnlineStore.Model;

namespace OnlineStore.Repo.Interfaces
{
    public interface IUserRepository
    {
        public Task<ApplicationUser> GetUserByUserName(string userName);
        public Task<ApplicationUser> GetUserByAppUserId(int id);
        public Task<int> InsertUser(ApplicationUser user);
    }
}
