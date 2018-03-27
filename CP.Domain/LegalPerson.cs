using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Domain
{
    [Serializable, ActiveRecord]
    public class LegalPerson : Person
    {
        public virtual int Id { get; set; }
        public virtual string Company_Name { get; set; }
        public virtual string CNPJ { get; set; }
        public virtual string Responsible { get; set; }
    }
}