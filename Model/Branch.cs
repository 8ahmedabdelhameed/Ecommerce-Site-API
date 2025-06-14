namespace WebApplication3.Model
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchLocation{ get; set; }
        public List<Employee> employees { get; set; }
    }
}
