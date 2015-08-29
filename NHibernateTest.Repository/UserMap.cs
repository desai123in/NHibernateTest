using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate;
using FluentNHibernate.Mapping;
using NHibernateTest.Entity;

namespace NHibernateTest.Repository
{
    public class UserMap:ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id).Column("EmployeeId");
            Map(x => x.Name).Column("EmployeeName");
            HasMany(x => x.Roles);
        }
    }
}
