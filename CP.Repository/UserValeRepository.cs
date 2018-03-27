using CP.Domain;
using CP.FrameWork;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Repository
{
    public class UserValeRepository : Repository<UserVale>
    {
        public IEnumerable<UserVale> FindAllUser()
        {
            var criterio = DetachedCriteria.For<UserVale>();

            return FindAll(criterio);
        }

        public UserVale FindUser(string email, string password)
        {
            var criterio = DetachedCriteria.For<UserVale>();

            criterio.Add(Restrictions.Eq("Email", email));
            criterio.Add(Restrictions.Eq("Password", password));

            return FindAll(criterio).FirstOrDefault();
        }
    }
}
