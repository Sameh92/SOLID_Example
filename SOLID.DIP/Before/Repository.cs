using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.Before
{
    internal static class Repository
    {
        public static List<Customer> Customers => new List<Customer>()
            {
            new Customer()
            {
                Id = 1,
                Name ="Sameh",
                EmailAddress ="Sameh@test.com",
                MobileNo ="60186679545",
                Address ="KL"
            },
             new Customer()
            {
                Id = 2,
                Name ="Rana",
                EmailAddress ="Rana@test.com",
                MobileNo ="60186679224",
                Address ="SY"
            },
              new Customer()
            {
                Id = 3,
                Name ="Roger",
                EmailAddress ="Roger@test.com",
                MobileNo ="609863167",
                Address ="SW"
            },
            };
    }
}
