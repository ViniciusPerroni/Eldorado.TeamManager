using Eldorado.TeamManager.Application.Dtos;

namespace Eldorado.TeamManager.Web.Models.TeamCollaborator
{
    public class TeamCollaboratorListViewModel
    {
        public TeamCollaboratorListViewModel()
        {
            TeamCollaborators = new List<TeamCollaboratorDto>();
        }
        
        public IEnumerable<TeamCollaboratorDto> TeamCollaborators { get; set; }
    }
}