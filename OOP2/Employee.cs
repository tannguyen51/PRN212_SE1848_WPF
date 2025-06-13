using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Employee
    {
        public int Id { get; set; }
        public string IdCard { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        // cơ chế đa hình(polymorphism)
        public virtual double calSalary()
        {
            return 4000000;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, IdCard: {IdCard}, BirthDay: {BirthDay.ToString("dd/MM/yyyy")}, Salary: {calSalary()}";
        }
    }
}
