using Eldorado.TeamManager.Application.Dtos;

namespace Eldorado.TeamManager.Web.Models.Team
{
    public class TeamListViewModel
    {
        public TeamListViewModel()
        {
            Teams = new List<TeamDto>();
        }

        public IEnumerable<TeamDto> Teams { get; set; }
    }
}