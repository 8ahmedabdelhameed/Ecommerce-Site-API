using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; } 
        public string Name { get; set; }
        public string Postition{ get; set; }
        public List<Branch> Branches { get; set; }

    }
}
