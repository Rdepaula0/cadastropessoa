using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Domain
{
    [Serializable, ActiveRecord]
    public class Address
    {
        public virtual int Id { get; set; }
        public virtual string Street { get; set; }
        public virtual string Number { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual TypeAddressEnum TypeAddress { get; set; }
    }
}
