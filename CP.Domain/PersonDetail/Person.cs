using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Domain
{
    [Serializable, ActiveRecord]
    public class Person
    {
        public virtual List<Phone> PhoneList { get; set; }
        public virtual List<Address> AddressList { get; set; }
    }
}
