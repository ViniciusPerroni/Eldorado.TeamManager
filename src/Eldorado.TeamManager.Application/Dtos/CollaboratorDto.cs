namespace Eldorado.TeamManager.Application.Dtos
{

    public class CollaboratorDto
    {
        public CollaboratorDto()
        {
            SelectedSkills = new List<int>();
            CollaboratorSkills = new List<CollaboratorSkillDto>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string RG { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public string Observation { get; set; }
        public List<CollaboratorSkillDto> CollaboratorSkills{ get; set; }
        public List<int> SelectedSkills { get; set; }
    }
}