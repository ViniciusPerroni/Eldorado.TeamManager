namespace Eldorado.TeamManager.Domain.Entities
{
    public class TeamSkill : BaseEntity
    {
        public TeamSkill()
        {          
        }
        public TeamSkill(long teamId, long skillId)
        {
            TeamId = teamId;
            SkillId = skillId;
        }
        public long TeamId { get; set; }
        public virtual Team Team { get; set; }
        public long SkillId { get; set; }
        public virtual Skill Skill { get; set; }
    }
}