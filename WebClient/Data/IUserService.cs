
using Entities.Models;
using System.Threading.Tasks;

namespace WebClient.Data
{
	public interface IUserService
	{
		Task<User> ValidateUser(string username, string password);
	}
}