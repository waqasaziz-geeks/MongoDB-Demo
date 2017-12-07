using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Shayan
{
    public class Database
    {
        internal static IEnumerable<T> GetList<T>(string collectionName = null)
        {
            collectionName = collectionName ?? (typeof(T).Name + "s");

            var client = new MongoClient("mongodb://localhost:27017");

            var tdb = client.GetDatabase("Shayan");
            var collection = tdb.GetCollection<T>(collectionName);

            return collection.Find(Builders<T>.Filter.Empty).ToList();
        }

    }
}
