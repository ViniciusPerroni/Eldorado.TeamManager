namespace Eldorado.TeamManager.Application.Dtos
{
    public class TeamSkillDto
    {
        public int Id { get; set; }
        public long TeamId { get; set; }
        public long TeamSkillId { get; set; }
        public TeamDto TeamSkill { get; set; }

    }

}
