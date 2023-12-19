using Common.DTOs;
using Common.Model;
using ORM.DatabaseContext;

namespace RESTCore.Services
{
	public class UserService
	{
		private readonly AppDbContext _appDbContext;

		public UserService(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public List<UserDTO> GetAll()
		{
			return _appDbContext
				.Users
				.Select(x => new UserDTO
					{
						Name = x.Name,
						Description = x.Description,
						Id = x.Id,
						Designation = x.Designation
					})
				.ToList();
		}



		public bool AddUser(UserDTO userDTO)
		{
			try
			{
				// add user in the database
				_appDbContext.Users.Add(new User
				{
					Name = userDTO.Name,
					Description = userDTO.Description,
					Designation = userDTO.Designation,
				});
				_appDbContext.SaveChanges();

				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public UserDTO GetOne(string id)
		{
			User user = _appDbContext.Users.Where(x => x.Id == id).FirstOrDefault();
			return new UserDTO
			{
				Name = user.Name,
				Description = user.Description,
				Designation = user.Designation,
				Id = user.Id
			};
		}


		public List<UserDTO> GetAllByName(string name)
		{
			return _appDbContext
				.Users
				.Select(x => new UserDTO
				{
					Name = x.Name,
					Description = x.Description,
					Id = x.Id,
					Designation = x.Designation
				})
				.Where(x =>
					x.Name.ToLower().Contains(name.ToLower())
				).ToList();
		}
	}
}
