using barİstasyon.Application.Interfaces;
using barİstasyon.Domain.Context;

namespace barİstasyon.Persistence.Repositories
{
    public interface Repository<T> : IRepository<T> where T : class
    {
        private readonly BarContext context;

        public Task CreateAsync(T entity)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
            context.Set<T>().Add(entity);
            await context.SaveChangesAsync();
        }

        public Task<T> GetByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}