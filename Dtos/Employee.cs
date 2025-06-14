namespace WebApplication3.Dtos
{
    public class EmployeePostOrGet
    {
        public string Name { get; set; }
        public string Postition { get; set; }
    }
    public class EmployeeGetorPostWithBranch
    {
        public string Name { get; set; }
        public string Postition { get; set; }
        public List<BranchPostOrGet> Branchs { get; set; }

    }
}
