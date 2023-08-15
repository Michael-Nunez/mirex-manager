using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MirexManager.Domain.Companies;

namespace MirexManager.Infrastructure.Configurations;

internal sealed class CompanyConfiguration
    : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasKey(c => c.Id);

        builder.HasIndex(c => c.Name);
    }
}
