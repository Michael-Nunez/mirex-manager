using MirexManager.Application.Abstracts;
using MirexManager.Domain.Abstractions;
using MirexManager.Domain.Clients;

namespace MirexManager.Application.Clients;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(
        IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public List<Client> GetClients()
    {
        return _clientRepository.GetAll();
    }
}
