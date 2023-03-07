namespace Eldorado.TeamManager.Application.Dtos
{

    public class TeamDto
    {
        public TeamDto()
        {
            SelectedSkills = new List<int>();
            Skills = new List<SkillDto>();
        }

        public int Id { get; set; }
        public string TeamName { get; set; }
        public string Avatar { get; set; }
        public string TeamObservation { get; set; }
        public List<SkillDto> Skills { get; set; }
        public List<int> SelectedSkills { get; set; }
       
    }

}