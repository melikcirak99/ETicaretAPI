using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Contexts;
namespace ETicaretAPI.Persistence.Repositories
{
    public class FileReadRepository : ReadRepository<Domain.Entities.File>, IFileReadRepository
    {
        public FileReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
