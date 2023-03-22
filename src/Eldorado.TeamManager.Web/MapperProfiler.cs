using AutoMapper;

using Eldorado.TeamManager.Application.Dtos;
using Eldorado.TeamManager.Domain.Entities;

namespace Eldorado.TeamManager.Web
{
    public class MapperProfiler : Profile
    {
        public MapperProfiler()
        {
            CreateMap<User, UserDto>();
            CreateMap<Skill, SkillDto>();
            CreateMap<CollaboratorSkill, CollaboratorSkillDto>();
            CreateMap<Collaborator, CollaboratorDto>();
            CreateMap<Team, TeamDto>();
            CreateMap<TeamSkill, TeamSkillDto>();
            CreateMap<TeamCollaborator, TeamCollaboratorDto>();
        }
    }
}
