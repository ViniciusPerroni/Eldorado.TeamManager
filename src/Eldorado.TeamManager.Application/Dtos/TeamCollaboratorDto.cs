namespace Eldorado.TeamManager.Application.Dtos
{
    public class TeamCollaboratorDto
    {
        public int Id { get; set; }
        public long CollaboratorId { get; set; }
        public CollaboratorDto Collaborator { get; set; }
        public long TeamId { get; set; }
        public TeamDto Team { get; set; }
    }
}