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
    public class AddressDTO
    {
        [DataMember]
        public virtual int Id { get; set; }
        [DataMember]
        public virtual string Street { get; set; }
        [DataMember]
        public virtual string Number { get; set; }
        [DataMember]
        public virtual string City { get; set; }
        [DataMember]
        public virtual string State { get; set; }
        [DataMember]
        public virtual TypeAddressEnum TypeAddress { get; set; }
    }
}
