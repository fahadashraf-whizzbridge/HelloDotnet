using Common.DTOs;
using Common.Model;
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

		[HttpGet("/all-by-name/{name}")]
		public List<UserDTO> GetAllByName(string name)
		{
			return _userService.GetAllByName(name);
		}

		[HttpGet("/users")]
		public List<UserDTO> GetAll()
		{
			return _userService.GetAll();
		}

		[HttpGet("/users/{id}")]
		public UserDTO GetOne(string id)
		{
			return _userService.GetOne(id);
		}


		[HttpPost("/users")]
		public bool GetAll([FromBody] UserDTO userDTO)
		{
			return _userService.AddUser(userDTO);
		}


	}
}
