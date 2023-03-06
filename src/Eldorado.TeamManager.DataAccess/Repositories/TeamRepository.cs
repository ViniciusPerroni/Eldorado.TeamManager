using Eldorado.TeamManager.DataAccess.Base;
using Eldorado.TeamManager.Domain.Entities;
using Eldorado.TeamManager.Domain.Repositories;

namespace Eldorado.TeamManager.DataAccess.Repositories
{
    public class TeamRepository : CrudRepository<Team>, ITeamRepository
    {
        public TeamRepository(TeamManagerDbContext dbContext) : base(dbContext)
        {
        }
    }
}