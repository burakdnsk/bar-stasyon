using barİstasyon.Application.Interfaces;

namespace barİstasyon.Persistence.Repositories
{
    public interface Repository<T> : IRepository<T> where T : class
    {

    }
}