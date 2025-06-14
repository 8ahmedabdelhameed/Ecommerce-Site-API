namespace WebApplication3.Dtos
{
    public class BranchGetWithEmployee
    {
        public string BranchName { get; set; }
        public string BranchLocation { get; set; }
        public List<EmployeePostOrGet> Employees { get; set; }
    }
    public class BranchPostOrGet
    {
        public string BranchName { get; set; }
        public string BranchLocation { get; set; }
    }
}
