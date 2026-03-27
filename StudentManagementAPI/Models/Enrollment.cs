using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public string Grade { get; set; } = string.Empty;
        public string Semester { get; set; } = string.Empty;
    }
}