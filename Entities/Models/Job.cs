using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Job
    {
        [Key]
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }
}