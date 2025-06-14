using WebApplication3.Dtos;

namespace WebApplication3.Interfaces
{
    public interface IBranch
    {
        List<BranchGetWithEmployee> branchGetWithEmployees();
       void PostBranch(BranchPostOrGet branch);
        void DeleteBranch(int id);
    }
}
