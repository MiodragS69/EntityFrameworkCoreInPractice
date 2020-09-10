using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataLayer.Migrations
{
    public partial class Add_EnumsForQuestionScopeAndQuestionRating_Entities_Test_QuestionTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Scope",
                table: "Questions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Scope",
                table: "Questions");
        }
    }
}
