using WebApplication3.Dtos;

namespace WebApplication3.Interfaces
{
    public interface IEmployee
    {
        List<EmployeeGetorPostWithBranch> GetAll();
        void PostEmployee (EmployeeGetorPostWithBranch employee);
        void Update(int id, EmployeePostOrGet employeePostOrGet);
    }
}
