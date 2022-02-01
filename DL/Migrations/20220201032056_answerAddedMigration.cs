using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DL.Migrations
{
    public partial class answerAddedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer",
                table: "BingoCards");

            migrationBuilder.DropColumn(
                name: "isMarked",
                table: "BingoCards");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BingoCardID = table.Column<int>(type: "integer", nullable: false),
                    block = table.Column<string>(type: "text", nullable: false),
                    isMarked = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Answers_BingoCards_BingoCardID",
                        column: x => x.BingoCardID,
                        principalTable: "BingoCards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_BingoCardID",
                table: "Answers",
                column: "BingoCardID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "BingoCards",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isMarked",
                table: "BingoCards",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
