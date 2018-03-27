using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Domain
{
    [Serializable, ActiveRecord]
    public class PhysicalPerson: Person
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime DateofBirth { get; set; }
        public virtual string Occupation { get; set;  }
    }
}
