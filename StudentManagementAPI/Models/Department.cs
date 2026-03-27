using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.Models
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
    }
}