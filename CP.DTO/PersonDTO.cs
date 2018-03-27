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
    public class PersonDTO
    {
        [DataMember]
        public virtual List<PhoneDTO> PhoneList { get; set; }
        [DataMember]
        public virtual List<AddressDTO> AddressList { get; set; }
    }
}
