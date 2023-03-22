using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eldorado.TeamManager.DataAccess.Migrations
{
    public partial class DataSkill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 101L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "C#", 2 },
                    { 102L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "JavaScript", 2 },
                    { 103L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Java", 2 },
                    { 104L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Python", 2 },
                    { 105L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "PHP", 2 },
                    { 106L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "VisualBasic", 2 },
                    { 107L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "C", 2 },
                    { 108L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "C++", 2 },
                    { 109L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "SQL", 2 },
                    { 110L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "PL/SQL", 2 },
                    { 111L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "T-SQL", 2 },
                    { 112L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Delphi", 2 },
                    { 113L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "FoxPro", 2 },
                    { 114L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Oracle", 1 },
                    { 115L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "SQL Server", 2 },
                    { 116L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "PostgreSQl", 2 },
                    { 117L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "MySQL", 2 },
                    { 118L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Firebird", 2 },
                    { 119L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "MongoDB", 2 },
                    { 120L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "RavenDB", 2 },
                    { 121L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Docker", 6 },
                    { 122L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Kubernetes", 6 },
                    { 123L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Ansible", 6 },
                    { 124L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "GitLab", 6 },
                    { 125L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "GitHub", 6 },
                    { 126L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Adm Windows", 6 },
                    { 127L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Adm Linux", 6 },
                    { 128L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Azure", 6 },
                    { 129L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "AWS", 6 },
                    { 130L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Google Cloud", 6 },
                    { 131L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Oracle Cloud", 6 },
                    { 132L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "SonarQube", 3 },
                    { 133L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Black Duck", 3 },
                    { 134L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Pacote Office", 3 },
                    { 135L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Jira", 3 },
                    { 136L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Trello", 3 },
                    { 137L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "TFS", 3 },
                    { 138L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Figma", 3 },
                    { 139L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "ASP.NET", 4 },
                    { 140L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Spring Boot", 3 },
                    { 141L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Angular", 3 },
                    { 142L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "VueJS", 3 },
                    { 143L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "React", 3 },
                    { 145L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "SCRUM", 5 },
                    { 146L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "PMBOK", 5 },
                    { 147L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "EXtreme programming", 5 },
                    { 148L, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dolor nec nisl volutpat finibus.", "Kanban", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 148L);
        }
    }
}
