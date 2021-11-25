using Entities.Models;

namespace WebAPI_2.Data
{
	public interface IUserService
	{
		User ValidateUser(string username, string password);
	}
}