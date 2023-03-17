
using Microsoft.EntityFrameworkCore;

namespace Practice_Crud.Models
{
   public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
   {
      protected readonly ApplicationContext _context;

      protected GenericRepository(ApplicationContext context)
      {
         _context = context;
      }

      public async Task<T> Get(long id)
      {
         return await _context.Set<T>().FindAsync(id);
      }

      public async Task<IEnumerable<T>> GetAll()
      {
         return await _context.Set<T>().ToListAsync();
      }

      public async Task Add(T entity)
      {
         await _context.Set<T>().AddAsync(entity);
      }

      public void Delete(T entity)
      {
         _context.Set<T>().Remove(entity);
      }

      public void Update(T entity)
      {
         _context.Set<T>().Update(entity);
      }
   }
}
