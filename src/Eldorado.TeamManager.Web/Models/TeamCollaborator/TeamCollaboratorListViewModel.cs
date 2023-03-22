using Eldorado.TeamManager.Application.Dtos;

namespace Eldorado.TeamManager.Web.Models.TeamCollaborator
{
    public class TeamCollaboratorListViewModel
    {
        public TeamCollaboratorListViewModel()
        {
            TeamCollaborators = new List<TeamCollaboratorDto>();
            Collaborators = new List<CollaboratorDto>();
        }
        
        public long TeamId { get; set; }
        public List<TeamCollaboratorDto> TeamCollaborators { get; set; }
        public List<CollaboratorDto> Collaborators { get; set; }
    }
}