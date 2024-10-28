using GamingWebProject.Core.Contracts;
using GamingWebProject.Core.Models;
using MongoDB.Driver;

namespace GamingWebProject.Core.Repositories
{
    public class MongoDbRepository : IMongoDbRepository
    {
        private IMongoCollection<User> _users;
        public MongoDbRepository(IMongoClient mongoClient)
        {
            _users = mongoClient.GetDatabase("users").GetCollection<User>("users");
        }

        //User
        public async Task<List<User>> GetAllUsers()
        {
            return await _users.Find<User>(x => true).ToListAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            try
            {
                return (await _users.FindAsync<User>(x => x.Id == id)).First();
            }
            catch
            {
                return null;
            }
        }

        public async Task InsertUserList(List<User> user)
        {
            await _users.InsertManyAsync(user);
        }

        public async Task InsertUser(User user)
        {
            await _users.InsertOneAsync(user);
        }

        public async Task<long> GetUserCount()
        {
            return await _users.CountDocumentsAsync(x => true);
        }

        public async Task ClearUserCache()
        {
            await _users.Database.DropCollectionAsync("users");
        }
    }
}
