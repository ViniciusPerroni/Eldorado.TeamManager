using Eldorado.TeamManager.Application.Dtos;

namespace Eldorado.TeamManager.Application.Services
{
    public interface ITeamService
    {
        Task Create(TeamDto dto);
        Task Update(TeamDto dto);
        Task Delete(int id);
        IEnumerable<TeamDto> ListAll();
        Task<TeamDto> GetById(int id);
    }
}