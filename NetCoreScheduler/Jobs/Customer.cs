using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreScheduler.Jobs
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        public Customer(int id, string firstName, string email, string mobile)
        {
            Id = id;
            Firstname = firstName;
            Email = email;
            Mobile = mobile;
        }

        public static List<Customer> GetCustomers()
        {
            var list = new List<Customer>();
            list.Add(new Customer(1, "Tesla", "tesla@domain.com", "9632587410"));
            list.Add(new Customer(2, "Newton", "newton@domain.com", "9875641230"));
            return list;
        }

    }
}
