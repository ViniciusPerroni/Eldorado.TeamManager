using Eldorado.TeamManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace Eldorado.TeamManager.DataAccess.Configurations
{
    [ExcludeFromCodeCoverage]
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasData(new Skill(101, "C#", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(102, "JavaScript", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(103, "Java", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(104, "Python", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(105, "PHP", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(106, "VisualBasic", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(107, "C", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(108, "C++", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(109, "SQL", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(110, "PL/SQL", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(111, "T-SQL", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(112, "Delphi", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(113, "FoxPro", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));

            builder.HasData(new Skill(114, "Oracle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.DataBase));
            builder.HasData(new Skill(115, "SQL Server", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(116, "PostgreSQl", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(117, "MySQL", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(118, "Firebird", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(119, "MongoDB", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));
            builder.HasData(new Skill(120, "RavenDB", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.ProgrammingLanguage));

            builder.HasData(new Skill(121, "Docker", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.DevOpsInfrastructure));
            builder.HasData(new Skill(122, "Kubernetes", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.DevOpsInfrastructure));
            builder.HasData(new Skill(123, "Ansible", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.DevOpsInfrastructure));
            builder.HasData(new Skill(124, "GitLab", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.DevOpsInfrastructure));
            builder.HasData(new Skill(125, "GitHub", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.DevOpsInfrastructure));
            builder.HasData(new Skill(126, "Adm Windows", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.DevOpsInfrastructure));
            builder.HasData(new Skill(127, "Adm Linux", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.DevOpsInfrastructure));
            builder.HasData(new Skill(128, "Azure", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.DevOpsInfrastructure));
            builder.HasData(new Skill(129, "AWS", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.DevOpsInfrastructure));
            builder.HasData(new Skill(130, "Google Cloud", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.DevOpsInfrastructure));
            builder.HasData(new Skill(131, "Oracle Cloud", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.DevOpsInfrastructure));

            builder.HasData(new Skill(132, "SonarQube", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.SoftwareTools));
            builder.HasData(new Skill(133, "Black Duck", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.SoftwareTools));
            builder.HasData(new Skill(134, "Pacote Office", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.SoftwareTools));
            builder.HasData(new Skill(135, "Jira", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.SoftwareTools));
            builder.HasData(new Skill(136, "Trello", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.SoftwareTools));
            builder.HasData(new Skill(137, "TFS", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.SoftwareTools));
            builder.HasData(new Skill(138, "Figma", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.SoftwareTools));

            builder.HasData(new Skill(139, "ASP.NET", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.FrameWork));
            builder.HasData(new Skill(140, "Spring Boot", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.SoftwareTools));
            builder.HasData(new Skill(141, "Angular", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.SoftwareTools));
            builder.HasData(new Skill(142, "VueJS", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.SoftwareTools));
            builder.HasData(new Skill(143, "React", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.SoftwareTools));

            builder.HasData(new Skill(145, "SCRUM", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.Methodology));
            builder.HasData(new Skill(146, "PMBOK", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.Methodology));
            builder.HasData(new Skill(147, "EXtreme programming", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.Methodology));
            builder.HasData(new Skill(148, "Kanban", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", Domain.Enums.SkillType.Methodology));
        }
    }
}
