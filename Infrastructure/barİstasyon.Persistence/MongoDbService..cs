using barİstasyon.Domain.Entities;
using MongoDB.Driver;

namespace barİstasyon.Persistence.Services
{
    public class MongoDbService
    {
        private readonly IMongoDatabase _database;

        public MongoDbService(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        // MongoDB ile işlem yapabilmek için veri tabanını almak için bir yöntem ekleyelim
        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
    }

}
        