﻿using Entities.Models;

namespace WebAPI.Data
{
	public interface IUserService
	{
		User ValidateUser(string username, string password);
	}
}