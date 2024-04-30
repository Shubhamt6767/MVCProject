using LabPractice.Models;
using System;

namespace LabPractice.Service
{
    public class SQLEmployeeService : IEmployeeRepository
    {
        private readonly Appdbcontaxcts context;

        public SQLEmployeeService(Appdbcontaxcts context)
        {
            this.context = context;
        }
       

        public IEnumerable<Employee> GetAllEmployee()
        {

            return context.Employees.ToList();

        }

        public Employee GetEmployee(int Id)
        {
            return context.Employees.Find(Id);
        }

        public Employee AddEmployee(Employee employee)
        {
            if(employee != null) {
                context.Employees.Add(employee);
                context.SaveChanges();
            }
            return employee;
            
        }

        public Employee UpdateEmployee(Employee employee)
        {
            if (employee != null)
            {
                context.Employees.Update(employee);
                context.SaveChanges();
            }
            return employee;

        }
        public Employee DeleteEmployee(int Id)
        {
            Employee employee = context.Employees.Find(Id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        }
    }
