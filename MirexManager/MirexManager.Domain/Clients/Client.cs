using MirexManager.Domain.Abstractions;
using MirexManager.Domain.Companies;

namespace MirexManager.Domain.Clients;

public sealed class Client : Entity
{
    public Client()
        : base(0)
    {
        
    }
    public Client(int id)
        : base(id)
    {
    }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public int CompanyId { get; set; }
    public Company Company { get; set; }
}
