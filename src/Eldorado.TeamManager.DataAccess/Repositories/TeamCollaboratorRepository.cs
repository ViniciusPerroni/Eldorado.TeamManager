using Eldorado.TeamManager.DataAccess.Base;
using Eldorado.TeamManager.Domain.Entities;
using Eldorado.TeamManager.Domain.Repositories;

namespace Eldorado.TeamManager.DataAccess.Repositories
{
    public class TeamCollaboratorRepository : CrudRepository<TeamCollaborator>, ITeamCollaboratorRepository
    {
        public TeamCollaboratorRepository(TeamManagerDbContext dbContext) : base(dbContext)
        {
        }
    }
}