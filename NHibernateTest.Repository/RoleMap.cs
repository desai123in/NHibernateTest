using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernateTest.Entity;
using FluentNHibernate.Mapping;

namespace NHibernateTest.Repository
{
    public class RoleMap:ClassMap<Role>
    {
        public RoleMap()
        {
            Id(x => x.Id).Column("RoleId");
            Map(x => x.Name).Column("RoleName");
            References<User>(x => x.User, "EmployeeId");
           // HasManyToMany<User>(x => x.Users).ParentKeyColumn("EmployeeId").Inverse();
            //References(x => x, "department_id");
           // References(x=>x)
           //.Class<User>()
           //.Columns("EmployeeId");
        }
    }
}
