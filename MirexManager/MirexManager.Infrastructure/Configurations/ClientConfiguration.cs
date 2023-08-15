using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MirexManager.Domain.Clients;
using MirexManager.Domain.Companies;

namespace MirexManager.Infrastructure.Configurations;

internal sealed class ClientConfiguration
    : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(c => c.Id);

        builder.HasIndex(c => c.Name);
        builder.HasIndex(c => c.Email);
    }
}
