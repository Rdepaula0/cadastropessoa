using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.FrameWork
{
    public interface IRepository<T>
    {
        int Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IEnumerable<T> FindAll(DetachedCriteria criteria);

    }
}
