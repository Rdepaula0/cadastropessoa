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
    public class UserDTO
    {
        [DataMember]
        public virtual string Email { get; set; }
        [DataMember]
        public virtual string Password{ get; set; }
    }
}
