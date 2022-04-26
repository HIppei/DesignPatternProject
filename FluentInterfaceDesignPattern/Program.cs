using System;

namespace FluentInterfaceDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentEmployee obj = new FluentEmployee();

            obj.NameOfTheEmployee("Horiba")
                .Borm("4/4/1990")
                .WOrkingOn("IT")
                .StayAt("Japan");


        }
    }

    public class Employee
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
    }

    public class FluentEmployee
    {
        private Employee employee = new Employee();

        public FluentEmployee NameOfTheEmployee(string fullName)
        {
            employee.FullName = fullName;
            return this;
        }
        
        public FluentEmployee Borm(string dateOfBirth)
        {
            employee.DateOfBirth = Convert.ToDateTime(dateOfBirth);
            return this;
        }

        public FluentEmployee WOrkingOn(string department)
        {
            employee.Department = department;
            return this;
        }

        public FluentEmployee StayAt(string address)
        {
            employee.Address = address;
            return this;
        }
    }
}
