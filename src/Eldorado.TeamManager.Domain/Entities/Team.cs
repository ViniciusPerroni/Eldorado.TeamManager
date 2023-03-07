namespace Eldorado.TeamManager.Domain.Entities
{

    public class Team : BaseEntity
    {
        public Team() { }

        public Team(string teamName, string avatar, string teamObservation)
        {
            TeamName = teamName;
            Avatar = avatar;
            TeamObservation = teamObservation;
        }

        public string TeamName { get; set; }
        public string Avatar { get; set; }
        public string TeamObservation { get; set; }
        public List<TeamSkill> TeamSkills { get; set; }

        public void Edit(string teamName, string avatar, string teamObservation)
        {
            TeamName = teamName;
            Avatar = avatar;
            TeamObservation = teamObservation;
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