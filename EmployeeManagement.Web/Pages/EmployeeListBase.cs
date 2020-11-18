using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(5000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Benjamin",
                LastName = "Uchenna",
                Email = "benjamin.uchenna@chisoftmedia.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/benjamin.png"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Joy",
                LastName = "Obiageri",
                Email = "joy.obiageri@chisoftmedia.com",
                DateOfBirth = new DateTime(1984, 05, 25),
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 2, DepartmentName = "Data Analysis" },
                PhotoPath = "images/joy.png"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Emmanuel",
                LastName = "Chinaecherem",
                Email = "emma.echerem@chisoftmedia.com",
                DateOfBirth = new DateTime(2002, 04, 15),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 3, DepartmentName = "Art" },
                PhotoPath = "images/emma.png"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "Shepherd",
                LastName = "Chukwebuka",
                Email = "shepherd.ebuka@chisoftmedia.com",
                DateOfBirth = new DateTime(2012, 12, 25),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/shepherd.png"
            };

            Employee e5 = new Employee
            {
                EmployeeId = 5,
                FirstName = "Tobechukwu",
                LastName = "Mikael",
                Email = "tobechukwu.mikael@chisoftmedia.com",
                DateOfBirth = new DateTime(2017, 10, 2),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 3, DepartmentName = "Sales" },
                PhotoPath = "images/tobechukwu.png"
            };

            Employees = new List<Employee> { e1, e2, e3, e4, e5 };
        }
    }
}
