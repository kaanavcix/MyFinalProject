using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepositoryDal<T> where T : class,IEntity // Type 
    {
        List<T> getAll(Expression<Func<T,bool>> expression);
        void update(T entity);
        void delete(T entity);
        void add(T entity);
        T Get(Expression<Func<T,bool>> expression );
       

    }
}



