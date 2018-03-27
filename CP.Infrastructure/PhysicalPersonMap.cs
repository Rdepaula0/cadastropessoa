using CP.Domain;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Infrastructure
{    
    public class PhysicalPersonMap : ClassMap<PhysicalPerson>
    {
        public PhysicalPersonMap()
        {
            Table("PhysicalPerson");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Name).Column("name");
            Map(x => x.DateofBirth).Column("dateofbirth").Nullable();
            Map(x => x.Occupation).Column("occupation").Nullable();

            HasMany(x => x.PhoneList);
            HasMany(x => x.AddressList);
        }
    }
}
