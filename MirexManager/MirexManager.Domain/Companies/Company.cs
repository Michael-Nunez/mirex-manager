using MirexManager.Domain.Abstractions;
using MirexManager.Domain.Clients;

namespace MirexManager.Domain.Companies;

public sealed class Company : Entity
{
    public Company(int id)
        : base(id)
    {
    }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public ICollection<Client> Clients { get; set; }
}
