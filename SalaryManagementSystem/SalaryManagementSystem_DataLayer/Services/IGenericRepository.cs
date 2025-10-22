using SalaryManagementSystem_DataLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagementSystem_DataLayer.Services
{
    public interface IGenericRepository <TEntity> where TEntity : class 
    {
        TEntity GetByID(object ID);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where = null);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(object ID);
    }
}
