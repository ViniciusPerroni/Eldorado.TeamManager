using Eldorado.TeamManager.Application.Dtos;

namespace Eldorado.TeamManager.Web.Models.TeamCollaborator
{
    public class TeamCollaboratorViewModel
    {
        public TeamCollaboratorViewModel()
        {
            TeamCollaborator = new TeamCollaboratorDto();
            Skills = new List<TeamCollaboratorDto>();
        }

        public TeamCollaboratorDto TeamCollaborator { get; set; }
        public List<TeamCollaboratorDto> Skills { get; set;}

    }
}