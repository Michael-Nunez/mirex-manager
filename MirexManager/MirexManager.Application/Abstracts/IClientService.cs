using MirexManager.Domain.Clients;

namespace MirexManager.Application.Abstracts;

public interface IClientService
{
    List<Client> GetClients();
}
