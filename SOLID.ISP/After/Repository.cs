using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.After
{
    public class Repository
    {
        public static IEnumerable<Employee> loadEmployee()
        {
            return new List<Employee>
            {

                new Staff
                {
                    EmployeeNo="1S123456",
                    Name="RogerF",
                    Salary=1000
                },
                new Consultant
                {
                    EmployeeNo="1C123456",
                    Name="Sameh",
                    Salary=1000
                },
                   new Daylabourer
                {
                    EmployeeNo="1D123456",
                    Name="Nadal",
                    Salary=1000
                },
            };
        }
    }
}
