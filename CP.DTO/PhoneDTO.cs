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
    public class PhoneDTO
    {
        [DataMember]
        public virtual int Id { get; set; }
        [DataMember]
        public virtual string Number { get; set; }
        [DataMember]
        public virtual TypeNumberEnum TypeNumber { get; set; }
    }
}
