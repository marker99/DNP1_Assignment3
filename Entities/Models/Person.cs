using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
	public class Person
	{
		public int Id { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		public string HairColor { get; set; }
		public string EyeColor { get; set; }
		public int Age { get; set; }
		public float Weight { get; set; }
		public int Height { get; set; }
		public string Sex { get; set; }
	}
}