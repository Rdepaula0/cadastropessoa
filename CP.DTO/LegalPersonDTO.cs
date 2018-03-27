using CP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CP.DTO
{
    [DataContract]
    public class LegalPersonDTO : PersonDTO
    {
        [DataMember]
        public virtual int Id { get; set; }
        [DataMember]
        public virtual string Company_Name { get; set; }
        [DataMember]
        public virtual string CNPJ { get; set; }
        [DataMember]
        public virtual string Responsible { get; set; }
    }
}
