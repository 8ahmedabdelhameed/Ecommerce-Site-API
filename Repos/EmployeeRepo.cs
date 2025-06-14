using System.Xml.Linq;
using WebApplication3.Dtos;
using WebApplication3.Interfaces;
using WebApplication3.Model;

namespace WebApplication3.Repos
{
    public class EmployeeRepo : IEmployee
    {
        private readonly AppDbContext _context;

        public EmployeeRepo(AppDbContext context)
        {
            _context = context;
        }

        public List<EmployeeGetorPostWithBranch> GetAll()
        {
            return _context.employees.Select(x=>new EmployeeGetorPostWithBranch
            {
                Name = x.Name,
                Postition = x.Postition,
                Branchs = x.Branches.Select(x=>new BranchPostOrGet
                {
                    BranchLocation = x.BranchLocation,
                    BranchName =x.BranchName,
                }).ToList()
            }).ToList();
        }

        public void PostEmployee(EmployeeGetorPostWithBranch employee)
        {
            Employee employee1 = new Employee
            {
                Name = employee.Name,
                Postition = employee.Postition,
                Branches = employee.Branchs.Select(x=>new Branch
                {
                    BranchLocation =x.BranchLocation,
                    BranchName = x.BranchName,
                }).ToList(),
            };
        }

        public void Update(int id, EmployeePostOrGet employeePostOrGet)
        {
            var employee = _context.employees.Find(id);
                if (employee != null) 
            {
                employee.Name = employeePostOrGet.Name;
                employee.Postition = employeePostOrGet.Postition;
                _context.Update(employee);
                _context.SaveChanges();
            }
        }
    }
}
