namespace Eldorado.TeamManager.Application.Dtos
{

    public class TeamDto
    {
        public TeamDto()
        {
            SelectedSkills = new List<int>();
            TeamSkills = new List<TeamSkillDto>();
        }

        public int Id { get; set; }
        public string TeamName { get; set; }
        public string Avatar { get; set; }
        public string TeamObservation { get; set; }
        public List<TeamSkillDto> TeamSkills { get; set; }
        public List<int> SelectedSkills { get; set; }
    }

}