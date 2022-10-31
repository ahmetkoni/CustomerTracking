using Core.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Databases.MongoDB
{
    public class MongoDB_RepositoryBase<TEntity, MongoDBContext> : IEntityRepository<TEntity>
       where TEntity : class, IEntity, new()
      where MongoDBContext : class, IMongoDB_Context<TEntity>, new()
    {

        private IMongoCollection<TEntity> _collection { get; set; }
        public MongoDB_RepositoryBase()
        {

            MongoDBContext mongoDBContext = new MongoDBContext();
            _collection = mongoDBContext.GetMongoDBCollection();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            try
            {
                return filter == null
                    ? _collection.Find<TEntity>(document => true).Sort("{_id:-1}").ToList()
                    : _collection.Find<TEntity>(filter).Sort("{_id:-1}").ToList();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter=null)
        {
            try
            {
                return filter == null
                    ? _collection.Find<TEntity>(document=>true).SingleOrDefault()
                    : _collection.Find<TEntity>(filter).SingleOrDefault();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Add(TEntity Entity)
        {
            _collection.InsertOne(Entity);
        }

        public void Delete(TEntity Entity)
        {
            _collection.DeleteOne(e => e.Id == Entity.Id);
        }

        public void Update(TEntity Entity)
        {
            _collection.ReplaceOne(e=>e.Id ==Entity.Id, Entity) ;
        }
    }
}
