using CP.Domain;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Infrastructure
{    
    public class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
            Table("Address");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.City).Column("city");
            Map(x => x.Street).Column("street").Nullable();
            Map(x => x.Number).Column("number").Nullable();
            Map(x => x.State).Column("state").Nullable();
            Map(x => x.TypeAddress).Column("typeaddress").Nullable();
        }
    }
}
