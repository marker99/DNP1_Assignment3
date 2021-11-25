using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebClient.Models;

namespace WebClient.Data.Implementations
{
	public class UserService : IUserService
	{

		public UserService()
		{
		}

		public async Task<User> ValidateUser(string userName, string Password)
		{
			Console.WriteLine("UserService: Attempting to Validate User");
			using HttpClient client = new();
			Console.WriteLine("UserService: 1");
			User userInfo = new();
			userInfo.Username = userName;
			userInfo.Password = Password;
			Console.WriteLine("UserService: 2");

			string userInfoAsJSON = JsonSerializer.Serialize(userInfo);
			Console.WriteLine("UserService: 3");

			StringContent content = new StringContent(
				userInfoAsJSON,
				Encoding.UTF8,
				"application/json"
			);
			Console.WriteLine($"UserService: 4\n{content.ReadAsStringAsync().Result}");

			HttpResponseMessage responseMessage =
				await client.PostAsync($"https://localhost:5001/User", content);
			Console.WriteLine($"UserService: 5\n{responseMessage.RequestMessage}");

			if (!responseMessage.IsSuccessStatusCode)
				throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
			Console.WriteLine("UserService: 6");

			string result = await responseMessage.Content.ReadAsStringAsync();
			Console.WriteLine("UserService: 7");

			User user = JsonSerializer.Deserialize<User>(result, new JsonSerializerOptions
			{
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase
			});
			Console.WriteLine("UserService: 8");
			Console.WriteLine($"Returning User {user.Username}, {user.Password}");

			return user;

		}

	}
}