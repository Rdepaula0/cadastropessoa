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
    public class PhysicalPersonDTO : PersonDTO
    {
        [DataMember]
        public virtual int Id { get; set; }
        [DataMember]
        public virtual string Name { get; set; }
        [DataMember]
        public virtual DateTime DateofBirth { get; set; }
        [DataMember]
        public virtual string Occupation { get; set; }
    }
}
