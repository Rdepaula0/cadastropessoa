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
    public class PhysicalPersonRepository : Repository<PhysicalPerson>
    {
        public IEnumerable<PhysicalPerson> FindAllPhysicalPerson()
        {
            var criterio = DetachedCriteria.For<PhysicalPerson>();

            return FindAll(criterio);
        }

        public PhysicalPerson FindPhysicalPerson(string name)
        {
            var criterio = DetachedCriteria.For<PhysicalPerson>();

            criterio.Add(Restrictions.Eq("Name", name));

            return FindAll(criterio).FirstOrDefault();
        }

    }
}
