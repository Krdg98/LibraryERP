using LibraryERP.DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace LibraryERP.DataBase.Abstracts
{
	public class Servicable<T> where T : class
	{
		protected LibraryDbContext Context { get; private set; }
		public DbSet<T> Table { get; private set; }

		public Servicable(LibraryDbContext libraryDbContext, DbSet<T> table)
		{
			Context = libraryDbContext;
			Table = table;
		}

		public virtual async Task<List<T>> GetAllAsync()
		{
			return await Table.ToListAsync();
		}

		public virtual async Task<T> GetByIdAsync(int id)
		{
			return await Table.FindAsync(id);
		}

		public virtual async Task AddAsync(T model)
		{
			Table.Add(model);
			await Context.SaveChangesAsync();
		}

		public virtual void UpdateAsync(T model)
		{
			Table.Update(model);
			Context.SaveChangesAsync();
		}


		public virtual async Task DeleteAsync(T? model)
		{
			T result = await Table.FindAsync(model);
			await Delete(result);
			
		}

		public virtual async Task DeleteAsync(int id)
		{
			var model = await Table.FindAsync(id);
			await Delete(model);
		}

		private async Task Delete(T? model)
		{
			if (model != null)
			{
				Table.Remove(model);
				await Context.SaveChangesAsync();
			}
		}
	}
}
