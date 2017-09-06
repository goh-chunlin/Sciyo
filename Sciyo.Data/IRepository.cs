using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sciyo.Data
{
	public interface IRepository<T> where T:BaseEntity
	{
		// Create
		Task AddAsync(T entity);

		// Read
		IQueryable<T> GetAll();
		Task<T> GetAsync(Int64 id);

		// Update
		Task UpdateAsync(T entity);

		// Delete
		Task DeleteAsync(Int64 id);
	}
}