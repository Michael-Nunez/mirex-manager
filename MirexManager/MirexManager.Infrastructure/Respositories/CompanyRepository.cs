using MirexManager.Domain.Abstractions;
using MirexManager.Domain.Companies;
using MirexManager.Infrastructure.Contexts;

namespace MirexManager.Infrastructure.Respositories;

internal sealed class CompanyRepository : BaseRepository<Company>, ICompanyRepository
{
    public CompanyRepository(ApplicationDbContext context) : base(context)
    {
    }
}
