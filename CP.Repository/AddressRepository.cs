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
    public class AddressRepository : Repository<Address>
    {
        public IEnumerable<Address> FindAllAddress()
        {
            var criterio = DetachedCriteria.For<Address>();

            return FindAll(criterio);
        }

    }
}
