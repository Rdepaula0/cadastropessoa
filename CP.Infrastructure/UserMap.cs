using CP.Domain;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Infrastructure
{    
    public class UserValeMap : ClassMap<UserVale>
    {
        public UserValeMap()
        {
            Table("UserVale");
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Email).Column("email");
            Map(x => x.Password).Column("password");
        }
    }
}
