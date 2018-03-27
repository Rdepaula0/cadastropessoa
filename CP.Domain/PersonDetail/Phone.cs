using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Domain
{
    [Serializable, ActiveRecord]
    public class Phone
    {
        public virtual int Id { get; set; }
        public virtual string Number { get; set; }
        public virtual TypeNumberEnum TypeNumber { get; set; }
    }
}
