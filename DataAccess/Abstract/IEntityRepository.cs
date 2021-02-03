using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic repository design pattern
    //generic contraint
    //class : referans tip constraint koyduk
    //IEntity : referans tip ya IEntity ya da IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalıdır. IEntity newlenemediği için artık IEntity'yi I....Dal'larda kullanamayıze
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        //interface metodları default publictir
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
