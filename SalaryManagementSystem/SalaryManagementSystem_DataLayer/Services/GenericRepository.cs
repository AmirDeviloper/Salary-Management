using SalaryManagementSystem_DataLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagementSystem_DataLayer.Services
{

    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class 
    {
        private SalaryManagementDBEntities _db;
        private DbSet<TEntity> _dbSet;
        public GenericRepository(SalaryManagementDBEntities db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }
        public virtual void Delete(object ID)
        {
            var entity = GetByID(ID);
            Delete(entity);
        }
        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Deleted) _dbSet.Attach(entity);
            _dbSet.Remove(entity);
        }

        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (where == null) return query;
            else return query.Where(where);
        }

        public virtual TEntity GetByID(object ID)
        {
            return _dbSet.Find(ID);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }
    }
}
