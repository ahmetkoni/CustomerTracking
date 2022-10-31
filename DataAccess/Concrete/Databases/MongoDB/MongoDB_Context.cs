using Core.DataAccess.Databases.MongoDB;
using Core.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Databases.MongoDB
{
    public class MongoDB_Context<TEntity, PredefinedCollection> : IDisposable, IMongoDB_Context<TEntity>
        where PredefinedCollection : class, ICollection, new()
        where TEntity : class, IEntity, new()
    {
        public MongoClient client { get; set; }
        public IMongoDatabase database { get; set; }
        public IMongoCollection<TEntity> collection { get; set; }
        private PredefinedCollection predefinedCollection = new PredefinedCollection();

        public MongoDB_Context()
        {
            GetMongoDBCollection();
        }
        public IMongoCollection<TEntity> GetMongoDBCollection()
        {
        tryAgain:
            try
            {
                client = new MongoClient("mongodb://localhost:27017");
                database = client.GetDatabase("CustomerTracking");
                collection = database.GetCollection<TEntity>(predefinedCollection.CollectionName);
                return collection;
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                goto tryAgain;
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }


}
