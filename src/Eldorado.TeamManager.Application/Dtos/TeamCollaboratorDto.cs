namespace Eldorado.TeamManager.Application.Dtos
{

    public class TeamCollaboratorDto
    {
        public TeamCollaboratorDto()
        {
            TeamCollaborators = new List<CollaboratorDto>();
            TeamCollaboratorSkills = new List<CollaboratorSkillDto>();

        }

        public int Id { get; set; }
        public long CollaboratorId { get; set; }
        public long TeamId { get; set; }
        public List<CollaboratorSkillDto> TeamCollaboratorSkills { get; set; }
        public List<CollaboratorDto> TeamCollaborators { get; set; }

    }
}