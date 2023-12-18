using Common.Model;
using HelloToDotnet.Services;
using Microsoft.AspNetCore.Mvc;
using RESTCore.Services;

namespace RESTCore.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{
		private readonly UserService _userService;

		public UserController(UserService userService)
		{
			_userService = userService;
		}

		[HttpGet("/users")]
		public List<User> GetAll()
		{
			return _userService.GetAll();
		}
	}
}
