using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 5, DepartmentName = "Sales" });

            //Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee 
            { 
                EmployeeId = 1,
                FirstName = "Benjamin",
                LastName = "Uchenna",
                Email = "benjamin.uchenna@chisoftmedia.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/benjamin.png"

            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Joy",
                LastName = "Obiageri",
                Email = "joy.obiageri@chisoftmedia.com",
                DateOfBirth = new DateTime(1984, 05, 25),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "images/joy.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Emmanuel",
                LastName = "Chinaecherem",
                Email = "emma.echerem@chisoftmedia.com",
                DateOfBirth = new DateTime(2002, 04, 15),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "images/emma.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Shepherd",
                LastName = "Chukwebuka",
                Email = "shepherd.ebuka@chisoftmedia.com",
                DateOfBirth = new DateTime(2012, 12, 25),
                Gender = Gender.Male,
                DepartmentId = 4,
                PhotoPath = "images/shepherd.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 5,
                FirstName = "Tobechukwu",
                LastName = "Mikael",
                Email = "tobechukwu.mikael@chisoftmedia.com",
                DateOfBirth = new DateTime(2017, 10, 2),
                Gender = Gender.Male,
                DepartmentId = 5,
                PhotoPath = "images/tobechukwu.png"
            });
        }
    }
}
