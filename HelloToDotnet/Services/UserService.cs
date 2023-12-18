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

		public List<User> GetAll()
		{
			return _appDbContext.Users.ToList();
		}

	}
}
