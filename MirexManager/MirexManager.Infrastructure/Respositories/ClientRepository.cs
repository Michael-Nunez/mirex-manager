using MirexManager.Domain.Abstractions;
using MirexManager.Domain.Clients;
using MirexManager.Infrastructure.Contexts;

namespace MirexManager.Infrastructure.Respositories;

internal sealed class ClientRepository : BaseRepository<Client>, IClientRepository
{
    public ClientRepository(ApplicationDbContext context) : base(context)
    {
    }
}
