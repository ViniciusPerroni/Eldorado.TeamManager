﻿using Eldorado.TeamManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eldorado.TeamManager.DataAccess.Base
{
    public class TeamManagerDbContext : DbContext
    {
        public TeamManagerDbContext(DbContextOptions<TeamManagerDbContext> options) : base(options)
        {
            if (Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                Database.Migrate();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Collaborator> Collaborators { get; set; }
        public DbSet<CollaboratorSkill> CollaboratorSkills { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamSkill> TeamSkills { get; set; }
        public DbSet<TeamCollaborator> TeamCollaborators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TeamManagerDbContext).Assembly);
        }
    }
}
