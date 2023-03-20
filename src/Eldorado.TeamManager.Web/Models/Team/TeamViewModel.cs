using Eldorado.TeamManager.Application.Dtos;

namespace Eldorado.TeamManager.Web.Models.Team
{
    public class TeamViewModel
    {
        public TeamViewModel()
        {
            Skills = new List<SkillDto>();
            Team = new TeamDto();
        }
        public TeamDto Team { get; set; }

        public List<SkillDto> Skills { get; set; }
    }
}
