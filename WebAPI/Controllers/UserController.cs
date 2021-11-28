using System;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data.Implementations;
using WebAPI.Data;

namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{
		private IUserService _user;

		public UserController(IUserService userService)
		{
			_user = userService;
		}


		[HttpPost]
		public ActionResult GetLoginFromUsername([FromBody] User user)
		{
			Console.WriteLine($"User, {user.Username}, has requested to Log in");
			User u = _user.ValidateUser(user.Username, user.Password);
			Console.WriteLine($"Valid User: {u != null}");
			//return Ok(":)");
			return u == null ? BadRequest("Invalid User") : Ok(u);
		}
	}
}