using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace Sciyo.Data
{
	public class Repository<T> : IRepository<T> where T:BaseEntity
	{
		private ApplicationContext dbContext;

		private DbSet<T> entities;

		public Repository(ApplicationContext context)
		{
			this.dbContext = context;
			entities = dbContext.Set<T>();
		}

		public async Task AddAsync(T entity)
		{
			if (entity == null) {  
                throw new ArgumentNullException("entity");  
            } 
			
			dbContext.Entry(entity).State = EntityState.Added;
			await dbContext.SaveChangesAsync();
		}

		public IQueryable<T> GetAll()
		{
			return entities.AsQueryable();
		}

		public async Task<T> GetAsync(long id)
		{
			return await entities.FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task UpdateAsync(T entity)
		{
			if (entity == null) {  
                throw new ArgumentNullException("entity");  
            } 
			
			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(long id)
		{
			var selectedEntity = await GetAsync(id);

			if (selectedEntity == null) {  
                throw new ArgumentNullException("entity");  
            } 

			entities.Remove(selectedEntity);
			await dbContext.SaveChangesAsync();
		}
	}
}