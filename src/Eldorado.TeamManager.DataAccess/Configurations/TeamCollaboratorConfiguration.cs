using Eldorado.TeamManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eldorado.TeamManager.DataAccess.Configurations
{
    public class TeamCollaboratorConfiguration : IEntityTypeConfiguration<TeamCollaborator>
    {
        public void Configure(EntityTypeBuilder<TeamCollaborator> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
        }
    }
}