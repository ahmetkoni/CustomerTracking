using Core.DataAccess.Databases.MongoDB;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB.Collections;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Databases.MongoDB
{
    public class MongoDB_UserDal : MongoDB_RepositoryBase<User, MongoDB_Context<User, MongoDB_UserCollection>>, IUserDal
    {

        public List<OperationClaim> GetClaims(string userId)
        {

            User _user = new User();
            List<UserOperationClaim> _userOperationClaims = new List<UserOperationClaim>();
            List<OperationClaim> _claims = new List<OperationClaim>();

            using (var context = new MongoDB_Context<User, MongoDB_UserCollection>())
            {
                _user = context.collection.Find(r => r.Id == userId).First();
            }
            using (var context = new MongoDB_Context<UserOperationClaim, MongoDB_UserOperationClaimsCollection>())
            {
                _userOperationClaims = context.collection.Find(r => r.UserId == userId).ToList();
            }
            using (var context = new MongoDB_Context<OperationClaim, MongoDB_OperationClaimsCollection>())
            {
                foreach (var userOperationClaim in _userOperationClaims)
                {
                    _claims.Add(context.collection.Find(r => r.Id == userOperationClaim.OperationClaimId).First());
                }
            }
            return _claims;



        }

        public IList<User> GetList(Expression<Func<User, bool>> filter = null)
        {
            List<User> _users = new List<User>();

            using (var context = new MongoDB_Context<User, MongoDB_UserCollection>())
            {
                _users = context.collection.Find<User>(u => true).Sort("{id}").ToList();
                return _users;
            }

        }

        //void IEntityRepositoryBase<User>.Update(User entity)
        //{
        //    User _user = new User();
        //    using (var context = new MongoDB_Context<User, MongoDB_UserCollection>())
        //    {

        //        _user.Equals(context.collection.ReplaceOne(u => u.Id == entity.Id, entity));
        //    }
        //}
    }
}
