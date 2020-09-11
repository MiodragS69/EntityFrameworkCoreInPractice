using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataLayer.Migrations
{
    public partial class InitaialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(nullable: false),
                    QuestionText = table.Column<string>(nullable: true),
                    SoftDeleted = table.Column<bool>(nullable: false),
                    MultiAnswer = table.Column<bool>(nullable: false),
                    Scope = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    TestId = table.Column<int>(nullable: false),
                    TestTitle = table.Column<string>(nullable: true),
                    TestCreatedOn = table.Column<DateTime>(nullable: false),
                    TestActivatedOn = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.TestId);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    AnswerText = table.Column<string>(nullable: true),
                    IsCorrect = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => new { x.AnswerId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Explanations",
                columns: table => new
                {
                    ExplanationId = table.Column<int>(nullable: false),
                    ExplanationText = table.Column<string>(nullable: true),
                    QuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Explanations", x => x.ExplanationId);
                    table.ForeignKey(
                        name: "FK_Explanations_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionsTests",
                columns: table => new
                {
                    QuestionId = table.Column<int>(nullable: false),
                    TestId = table.Column<int>(nullable: false),
                    SoftDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsTests", x => new { x.QuestionId, x.TestId });
                    table.ForeignKey(
                        name: "FK_QuestionsTests_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionsTests_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "TestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Explanations_QuestionId",
                table: "Explanations",
                column: "QuestionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionsTests_TestId",
                table: "QuestionsTests",
                column: "TestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Explanations");

            migrationBuilder.DropTable(
                name: "QuestionsTests");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Tests");
        }
    }
}
