using System;
using System.Collections.Generic;

namespace Adapter
{
    public class EmployeeAdapter : ITarget
    {
        ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();
        
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            string id = null;
            string name = null;
            string designation = null;
            string salary = null;

            List<Employee> listEmployee = new List<Employee>();

            for (int i = 0; i< employeesArray.GetLength(0); i++)
            { 
                for (int j = 0; j< employeesArray.GetLength(1); j++)
                {
                    if (j==0)
                    {
                        id = employeesArray[i, j];
                    }
                    else if (j==1)
                    {
                        name = employeesArray[i, j];
                    }
                    else if (j == 2)
                    {
                        designation = employeesArray[i, j];
                    }
                    else if (j == 3)
                    {
                        salary = employeesArray[i, j];
                    }
                    listEmployee.Add(new Employee(Convert.ToInt32(id), name, designation, Convert.ToDecimal(salary)));
                }
            }
            Console.WriteLine("Adapter converted Array of Employee to List of Employee");
            Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
            thirdPartyBillingSystem.ProcessSalary(listEmployee);
        }
    }
}
