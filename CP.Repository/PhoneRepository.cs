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
    public class PhoneRepository : Repository<Phone>
    {
        public IEnumerable<Phone> FindAllPhone()
        {
            var criterio = DetachedCriteria.For<Phone>();

            return FindAll(criterio);
        }

        public Phone FindPhone(string number)
        {
            var criterio = DetachedCriteria.For<Phone>();

            criterio.Add(Restrictions.Eq("Number", number));

            return FindAll(criterio).FirstOrDefault();
        }
    }
}
