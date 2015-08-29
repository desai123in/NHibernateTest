using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernateTest.Entity;

namespace NHibernateTest.Repository
{
    public class UserRepository
    {

        public IList<User> GetAllUsers()
        {
             IList<User> users = NHibernateHelper.OpenSession()
                 
            .GetNamedQuery("AllUser")
            .List<User>();

            return users;

        }
    }
}
