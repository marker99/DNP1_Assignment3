using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
	public class Job
	{
		[Key]
		public int JobId { get; set; }
		public string JobTitle { get; set; }
		public int Salary { get; set; }
	}
}