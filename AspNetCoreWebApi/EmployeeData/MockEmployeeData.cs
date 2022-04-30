using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApi.Models;

namespace RestApi.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> employees=new List<Employee>()
        {
            new Employee()
            {
                Id=Guid.NewGuid(),
                Name="EmployeeOne"
            },
            new Employee()
            {
                Id=Guid.NewGuid(),
                Name="EmployeeTwo"
            }
        };
        
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee EditEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
