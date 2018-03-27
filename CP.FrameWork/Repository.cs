using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.FrameWork
{
    public class Repository<T> : IRepository<T>
    {
        protected ISession Session = null;

        public Repository()
        {
            Session = Database.OpenSession();
        }
        public Repository(ISession session)
        {
            Session = session;
        }
        public int Add(T entity)
        {
            var transaction = Session.BeginTransaction();
            try
            {
                var newId = (int)Session.Save(entity);
                Session.Flush();
                transaction.Commit();
                return newId;

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return 0;
            }
        }

        public void Delete(T entity)
        {
            var transaction = Session.BeginTransaction();

            try
            {
                Session.Delete(entity);
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
        }

        public void Update(T entity)
        {
            var transaction = Session.BeginTransaction();

            try
            {
                var newId = (int)Session.Save(entity);
                Session.Flush();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
        }

        public IEnumerable<T> FindAll(DetachedCriteria criteria)
        {
            return criteria.GetExecutableCriteria(Session).Future<T>();
        }
    }
}
