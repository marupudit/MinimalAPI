
namespace MinimalAPI.Model
{
    public interface IDataRepository
    {
        List<Employee> AddEmployee(Employee employee);
        Employee GetEmployeeById(string id);
        List<Employee> GetEmployees();
        Employee PutEmployee(Employee employee);
    }
}