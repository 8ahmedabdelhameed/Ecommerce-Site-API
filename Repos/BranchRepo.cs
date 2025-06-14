using WebApplication3.Dtos;
using WebApplication3.Interfaces;
using WebApplication3.Model;

namespace WebApplication3.Repos
{
    public class BranchRepo : IBranch
    {
        private readonly AppDbContext _context;

        public BranchRepo(AppDbContext context)
        {
            _context = context;
        }

        public List<BranchGetWithEmployee> branchGetWithEmployees()
        {
            return _context.branches.Select(x => new BranchGetWithEmployee
            {
                BranchName = x.BranchName,
                BranchLocation = x.BranchLocation,
                Employees = x.employees.Select(x => new EmployeePostOrGet
                {
                    Name = x.Name,
                    Postition = x.Postition,
                }).ToList()
            }).ToList();
        }

        public void DeleteBranch(int id)
        {
            var branch = _context.branches.Find(id);
            if (branch != null)
            {
                _context.Remove(branch);
                _context.SaveChanges();
            }
        }

        public void PostBranch(BranchPostOrGet branch)
        {
            Branch branch1 = new Branch
            {
                BranchLocation = branch.BranchLocation,
                BranchName = branch.BranchName,
            };
            _context.Add(branch1);
            _context.SaveChanges();
        }
    }
}
