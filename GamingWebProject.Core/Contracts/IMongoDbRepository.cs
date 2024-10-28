using GamingWebProject.Core.Models;

namespace GamingWebProject.Core.Contracts
{
    public interface IMongoDbRepository
    {
        //User
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task InsertUserList(List<User> user);
        Task InsertUser(User user);
        Task<long> GetUserCount();
        Task ClearUserCache();
    }
}
