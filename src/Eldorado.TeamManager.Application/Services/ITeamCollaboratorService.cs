using Eldorado.TeamManager.Application.Dtos;

namespace Eldorado.TeamManager.Application.Services
{
    public interface ITeamCollaboratorService
    {
        Task Create(TeamCollaboratorDto dto);
        Task Update(TeamCollaboratorDto dto);
        Task Delete(int id);
        IEnumerable<TeamCollaboratorDto> ListAll();
        Task<TeamCollaboratorDto> GetById(int id);
    }
}