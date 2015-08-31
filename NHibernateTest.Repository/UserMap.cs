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
            Map(x => x.State).Column("State");
            Map(x => x.JoinedOn).Column("JoinDate");
           // HasManyToMany<Role>(x => x.Roles).ChildKeyColumn("RoleId");
            HasMany<Role>(x => x.Roles).KeyColumn("EmployeeId");//.Inverse();
            
        }
    }
}
