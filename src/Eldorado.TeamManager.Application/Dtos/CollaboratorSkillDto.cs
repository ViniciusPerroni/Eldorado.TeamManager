namespace Eldorado.TeamManager.Application.Dtos
{
    public class CollaboratorSkillDto
    {
        public int Id { get; set; }
        public long CollaboratorId { get; set; }
        public long SkillId { get; set; }
        public SkillDto Skill { get; set; }

    }
}
