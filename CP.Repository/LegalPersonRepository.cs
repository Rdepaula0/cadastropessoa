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
    public class LegalPersonRepository : Repository<LegalPerson>
    {
        public IEnumerable<LegalPerson> FindAllLegalPersons()
        {
            var criterio = DetachedCriteria.For<LegalPerson>();

            return FindAll(criterio);
        }

        public LegalPerson FindAllLegalPersons(string company)
        {
            var criterio = DetachedCriteria.For<LegalPerson>();

            criterio.Add(Restrictions.Eq("Company_name", company));

            return FindAll(criterio).FirstOrDefault();
        }

    }
}
