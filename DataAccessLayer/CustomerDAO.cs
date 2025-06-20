using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        static List<Customer> customers = new List<Customer>();
        public void GenerateSampleDataset()
        {
            customers.Add(new Customer() { Id = 1, Name = "Obama", Phone = "012345665", Email = "obama@gmail.com" });
            customers.Add(new Customer() { Id = 2, Name = "Putin", Phone = "01235665", Email = "putin@gmail.com" });
            customers.Add(new Customer() { Id = 3, Name = "Kim", Phone = "0164665", Email = "kim@gmail.com" });
            customers.Add(new Customer() { Id = 4, Name = "Trump", Phone = "0222345665", Email = "trump@gmail.com" });
            customers.Add(new Customer() { Id = 5, Name = "Jong", Phone = "01234455", Email = "jong@gmail.com" });
        }
        public List<Customer> GetCustomers() 
        {
            return customers; }
    }
}
