namespace Eldorado.TeamManager.Domain.Entities
{
    public class TeamSkill : BaseEntity
    {
        public TeamSkill()
        {          
        }
        public TeamSkill(long teamId, long teamSkillId)
        {
            TeamId = teamId;
            TeamSkillId = teamSkillId;
        }
        public long TeamSkillId { get; set; }
        public virtual Team team { get; set; }
        public long TeamSkillId { get; set; }
        public virtual TeamSkill teamSkill { get; set; }
    }
}