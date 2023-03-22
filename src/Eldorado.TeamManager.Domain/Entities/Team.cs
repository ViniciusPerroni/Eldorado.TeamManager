namespace Eldorado.TeamManager.Domain.Entities
{
    public class Team : BaseEntity
    {
        public Team() { }

        public Team(string name, string pathAvatar, string observation)
        {
            Name = name;
            PathAvatar = pathAvatar;
            Observation = observation;
        }

        public string Name { get; set; }
        public string PathAvatar { get; set; }
        public string Observation { get; set; }
        public virtual List<TeamSkill> TeamSkills { get; set; }
        public virtual List<TeamCollaborator> TeamCollaborators { get; set; }
        public void Edit(string name, string pathAvatar, string observation)
        {
            Name = name;
            PathAvatar = pathAvatar;
            Observation = observation;
        }

        public void SetTeamSkills(List<int> teamSkillsIds)
        {
            if (TeamSkills != null)
                TeamSkills.Clear();
            else
                TeamSkills = new List<TeamSkill>();

            foreach (var teamSkillId in teamSkillsIds)    
            {
                TeamSkills.Add(new TeamSkill(Id, teamSkillId));
            }
        }
    }
}