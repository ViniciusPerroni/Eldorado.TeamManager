using AutoMapper;
using Eldorado.TeamManager.Application.Dtos;
using Eldorado.TeamManager.Domain.Entities;
using Eldorado.TeamManager.Domain.Repositories;


namespace Eldorado.TeamManager.Application.Services.Imp
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;

        private readonly IMapper _mapper;

        public TeamService(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }

        public IEnumerable<TeamDto> ListAll()
        {
            var teams = _teamRepository.GetAll();

            return _mapper.Map<List<TeamDto>>(teams.ToList());
        }
        public async Task Create(TeamDto dto)
        {
            var team = new Team(dto.Name, dto.PathAvatar, dto.Observation);

            await _teamRepository.Create(team);

            team.SetTeamSkills(dto.SelectedSkills);

            await _teamRepository.Update(team);
        }
        public async Task Update(TeamDto dto)
        {
            var team = _teamRepository.GetById(dto.Id).Result;
            team.Edit(dto.Name, dto.PathAvatar, dto.Observation);
            team.SetTeamSkills(dto.SelectedSkills);

            await _teamRepository.Update(team);
        }

        public async Task<TeamDto> GetById(int id)
        {
            var team = await _teamRepository.GetById(id);
            return _mapper.Map<TeamDto>(team);
        }

        public async Task Delete(int id)
        {
            await _teamRepository.Delete(id);
        }

        public async Task AddCollaborator(long teamId, long collaboratorId)
        {
            var team = await _teamRepository.GetById((int)teamId);
            var teamCollaborator = new TeamCollaborator(collaboratorId, team.Id);

            team.TeamCollaborators.Add(teamCollaborator);
            await _teamRepository.Update(team);
        }

        public async Task DeleteCollaborator(long teamId, long teamCollaboratorId)
        {
            var team = await _teamRepository.GetById((int)teamId);
            var teamCollaborator = team.TeamCollaborators.FirstOrDefault(tc => tc.Id == teamCollaboratorId);

            team.TeamCollaborators.Remove(teamCollaborator);
            await _teamRepository.Update(team);
        }
    }
}