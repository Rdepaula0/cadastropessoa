using CP.Domain;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Infrastructure
{    
    public class LegalPersonMap : ClassMap<LegalPerson>
    {
        public LegalPersonMap()
        {
            Table("LegalPerson");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Company_Name).Column("companyname");
            Map(x => x.CNPJ).Column("cnpj").Nullable();
            Map(x => x.Responsible).Column("responsible").Nullable();

            HasMany(x => x.PhoneList);
            HasMany(x => x.AddressList);
        }
    }
}
