using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP4_Reuse_OOP2
{
    public static class YourUtils
    {
        public static int Tuoi(this Employee employee)
        {
            return DateTime.Now.Year - employee.BirthDay.Year;
        }

       
        public static bool IsBirthdayThisMonth(this Employee employee)
        {
            return employee.BirthDay.Month == DateTime.Now.Month;
        }
    }
}
