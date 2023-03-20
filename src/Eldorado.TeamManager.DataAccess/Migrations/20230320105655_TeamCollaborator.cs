using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Eldorado.TeamManager.DataAccess.Migrations
{
    public partial class TeamCollaborator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamCollaborators",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CollaboratorId = table.Column<long>(type: "bigint", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamCollaborators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamCollaborators_Collaborators_CollaboratorId",
                        column: x => x.CollaboratorId,
                        principalTable: "Collaborators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamCollaborators_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamCollaborators_CollaboratorId",
                table: "TeamCollaborators",
                column: "CollaboratorId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamCollaborators_TeamId",
                table: "TeamCollaborators",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamCollaborators");
        }
    }
}
