using AutoMapper;
using Eldorado.TeamManager.Application.Dtos;
using Eldorado.TeamManager.Domain.Entities;
using Eldorado.TeamManager.Domain.Repositories;

namespace Eldorado.TeamManager.Application.Services.Imp
{
    public class TeamCollaboratorService : ITeamCollaboratorService
    {
        private readonly ITeamCollaboratorRepository _teamCollaboratorRepository;
        private readonly IMapper _mapper;

        public TeamCollaboratorService(ITeamCollaboratorRepository teamCollaboratorRepository, IMapper mapper)
        {
            _teamCollaboratorRepository = teamCollaboratorRepository;
            _mapper = mapper;
        }

        public IEnumerable<TeamCollaboratorDto> ListAll()
        {
            var teamCollaborators = _teamCollaboratorRepository.GetAll();

            return _mapper.Map<List<TeamCollaboratorDto>>(teamCollaborators.ToList());
        }

        public async Task Create(TeamCollaboratorDto dto)
        {
            var teamCollaborator = new TeamCollaborator(dto.CollaboratorId, dto.SkillId);

            await _teamCollaboratorRepository.Create(teamCollaborator);

            await _teamCollaboratorRepository.Update(teamCollaborator);

        }

        public async Task Update(CollaboratorDto dto)
        {
            var teamCollaborator = _teamCollaboratorRepository.GetById(dto.Id).Result;

            await _teamCollaboratorRepository.Update(teamCollaborator);
        }

        public async Task<TeamCollaboratorDto> GetById(int id)
        {
            var teamCollaborator = await _teamCollaboratorRepository.GetById(id);
            return _mapper.Map<TeamCollaboratorDto>(teamCollaborator);
        }

        public async Task Delete(int id)
        {
            await _teamCollaboratorRepository.Delete(id);
        }
    }
}