using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballGamePlan.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GamePlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsPass = table.Column<bool>(type: "INTEGER", nullable: false),
                    GamePlanId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plays_GamePlans_GamePlanId",
                        column: x => x.GamePlanId,
                        principalTable: "GamePlans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlayResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GamePlanId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayId = table.Column<int>(type: "INTEGER", nullable: false),
                    Coverage = table.Column<int>(type: "INTEGER", nullable: false),
                    IsPass = table.Column<bool>(type: "INTEGER", nullable: false),
                    PassFailReason = table.Column<int>(type: "INTEGER", nullable: false),
                    YardsGained = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayResults_GamePlans_GamePlanId",
                        column: x => x.GamePlanId,
                        principalTable: "GamePlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayResults_Plays_PlayId",
                        column: x => x.PlayId,
                        principalTable: "Plays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayResults_GamePlanId",
                table: "PlayResults",
                column: "GamePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayResults_PlayId",
                table: "PlayResults",
                column: "PlayId");

            migrationBuilder.CreateIndex(
                name: "IX_Plays_GamePlanId",
                table: "Plays",
                column: "GamePlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayResults");

            migrationBuilder.DropTable(
                name: "Plays");

            migrationBuilder.DropTable(
                name: "GamePlans");
        }
    }
}
