using Entities.Models;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Data;
using WebAPI.Persistence;

namespace WebAPI.Data.Implementations
{
	public class UserService : IUserService
	{
		//private IList<User> _users; // TODO: Move to Database
		private AdultDBContext _adultDBContext;

		public UserService(AdultDBContext adultDBContext)
		{
			_adultDBContext = adultDBContext;
		}

		public User ValidateUser(string username, string password)
		{
			return _adultDBContext.Users.FirstOrDefault(user => user.Username.Equals(username) && user.Password.Equals(password));
		}
	}
}