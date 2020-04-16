using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee {Id=1,Name="Vishwas",Department="IT",Email="email@gmail.com"},
                new Employee {Id=2,Name="Don",Department="Medical",Email="med@gmail.com"},
                new Employee {Id=3,Name="King",Department="IT",Email="it@gmail.com"},
            };

        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
