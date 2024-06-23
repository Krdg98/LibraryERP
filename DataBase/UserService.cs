using LibraryERP.DataBase.Abstracts;
using LibraryERP.DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace LibraryERP.DataBase
{
	public class UserService : Servicable<UserModel>
	{
		public UserService(LibraryDbContext libraryDbContext, DbSet<UserModel> table) : base(libraryDbContext, table)
		{
		}
	}
}
