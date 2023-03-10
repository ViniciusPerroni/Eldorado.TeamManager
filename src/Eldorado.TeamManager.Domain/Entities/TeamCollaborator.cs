namespace Eldorado.TeamManager.Domain.Entities
{
    public class TeamCollaborator : BaseEntity
    {
        public TeamCollaborator() { }

        public TeamCollaborator(long collaboratorId, long teamId)
        {
            CollaboratorId = collaboratorId;
            TeamId = teamId;
        }
        public long CollaboratorId { get; set; }
        public virtual Collaborator Collaborator { get; set; }
        public long TeamId { get; set; }
        public virtual Team Team { get; set; }

    }
}