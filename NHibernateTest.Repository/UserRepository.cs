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
           //BELOW WORKS NICE,
            var users = NHibernateHelper.OpenSession()
           .GetNamedQuery("AllUser2")
                //.List<Object>();
           .List<User>().Distinct().ToList();

            //LETS SEE IF WE CAN GET RID OF HBM FILE

           // var users2 = users.GroupBy(o => ((User)(((object[])o)[0])).Id);

             //var list = NHibernateHelper.OpenSession().CreateSQLQuery("exec GetCustomerByNaturalKey ?, ?")
             //.AddEntity(typeof(User))
             ////.SetInt32(0, customerNo)
             ////.SetDateTime(1, createdDate)
             //.List<User>();

             //var result = session.CreateSQLQuery("exec GetMemberGameActivity :mToken, :StartDate, :EndDate")
             //        .SetResultTransformer(Transformers.AliasToBean())
             //        .SetParameter("mToken", token)
             //        .SetParameter("StartDate", startDate)
             //        .SetParameter("EndDate", endDate)
             //        .List().ToList();
            
            return users;

        }
    }
}
