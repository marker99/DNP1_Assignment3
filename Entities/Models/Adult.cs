using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
	public class Adult : Person
	{
		public Job Job { get; set; }
	}
}