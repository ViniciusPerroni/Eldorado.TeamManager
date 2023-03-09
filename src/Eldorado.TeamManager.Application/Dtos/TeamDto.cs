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
        public string Name { get; set; }
        public string PathAvatar { get; set; }
        public string Observation { get; set; }
        public List<TeamSkillDto> TeamSkills { get; set; }
        public List<int> SelectedSkills { get; set; }
    }
}
