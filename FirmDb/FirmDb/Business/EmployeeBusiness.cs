using FirmDb.Data;
using FirmDb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirmDb.Business
{
    public class EmployeeBusiness
    {
        private EmployeeContext employeeContext;
        public List<Employee> GetAll()
        {
            using (employeeContext = new EmployeeContext())
            {
                return employeeContext.Employees.ToList();
            }
        }
        public Employee Get(int id)
        {
            using (employeeContext = new EmployeeContext())
            {
                return employeeContext.Employees.Find(id);
            }
        }
        public void Add(Employee employee)
        {
            using (employeeContext = new EmployeeContext())
            {
                employeeContext.Employees.Add(employee);
                employeeContext.SaveChanges();
            }
        }
        public void Update(Employee employee)
        {
            using (employeeContext = new EmployeeContext())
            {
                var item = employeeContext.Employees.Find(employee.Id);
                if (item != null)
                {
                    employeeContext.Entry(item).CurrentValues.SetValues(employee);
                    employeeContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using(employeeContext=new EmployeeContext())
            {
                var employee = employeeContext.Employees.Find(id);
                if (employee != null)
                {
                    employeeContext.Employees.Remove(employee);
                    employeeContext.SaveChanges();
                }
            }
        }

    }
}
