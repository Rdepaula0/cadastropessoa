using CP.Domain;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Infrastructure
{    
    public class PhoneMap : ClassMap<Phone>
    {
        public PhoneMap()
        {
            Table("Phone");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Number).Column("number");
            Map(x => x.TypeNumber).Column("typenumber").Nullable();
        }
    }
}
