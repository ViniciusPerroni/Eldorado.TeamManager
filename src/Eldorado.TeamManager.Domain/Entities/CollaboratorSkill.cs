namespace Eldorado.TeamManager.Domain.Entities
{
    public class CollaboratorSkill : BaseEntity
    {
        public CollaboratorSkill()
        {
            
        }
        public CollaboratorSkill(long collaboratorId, long skillId)
        {
            CollaboratorId = collaboratorId;
            SkillId = skillId;
        }
        public long CollaboratorId { get; set; }
        public virtual Collaborator Collaborator { get; set; }
        public long SkillId { get; set; }
        public virtual Skill Skill { get; set; }
    }
}