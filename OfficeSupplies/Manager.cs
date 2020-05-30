using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSupplies
{
    public class Manager :Employee
    {
        public Manager(int employeeId):base(employeeId)
        {

        }
        public override string GetFullName()
        {
            return LastName + ", " + FirstName;
        }
        //public override double GetEarnings()
        //{
        //    return 0;
        //}
    }
}
