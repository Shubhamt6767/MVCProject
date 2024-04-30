using LabPractice.Models;

namespace LabPractice.Service
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);

        Employee DeleteEmployee(int Id);




    }
}
