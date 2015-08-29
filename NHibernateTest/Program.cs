using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernateTest.Entity;
using NHibernateTest.Repository;

namespace NHibernateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository ur = new UserRepository();
            IList<User> users = ur.GetAllUsers();
        }
    }
}
