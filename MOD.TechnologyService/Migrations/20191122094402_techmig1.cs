using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.TechnologyService.Migrations
{
    public partial class techmig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentor",
                columns: table => new
                {
                    Mid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mname = table.Column<string>(nullable: true),
                    Mmail = table.Column<string>(nullable: true),
                    Mnumber = table.Column<int>(nullable: false),
                    Mpassword = table.Column<string>(nullable: true),
                    Mskills = table.Column<string>(nullable: true),
                    Mexperience = table.Column<int>(nullable: false),
                    Mtimeslot = table.Column<string>(nullable: true),
                    Mavailability = table.Column<bool>(nullable: false),
                    Mactive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentor", x => x.Mid);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uname = table.Column<string>(nullable: true),
                    Umail = table.Column<string>(nullable: true),
                    Unumber = table.Column<int>(nullable: false),
                    Upassword = table.Column<string>(nullable: true),
                    Uactive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    Tid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<int>(nullable: false),
                    Mid = table.Column<int>(nullable: false),
                    Sid = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    timeslot = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    Progress = table.Column<string>(nullable: true),
                    rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.Tid);
                    table.ForeignKey(
                        name: "FK_Training_Mentor_Mid",
                        column: x => x.Mid,
                        principalTable: "Mentor",
                        principalColumn: "Mid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_Skills_Sid",
                        column: x => x.Sid,
                        principalTable: "Skills",
                        principalColumn: "Sid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_User_Uid",
                        column: x => x.Uid,
                        principalTable: "User",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Pid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<int>(nullable: false),
                    Mid = table.Column<int>(nullable: false),
                    amount = table.Column<int>(nullable: false),
                    Mentor_Amount = table.Column<int>(nullable: false),
                    TrainingTid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Pid);
                    table.ForeignKey(
                        name: "FK_Payment_Mentor_Mid",
                        column: x => x.Mid,
                        principalTable: "Mentor",
                        principalColumn: "Mid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_Training_TrainingTid",
                        column: x => x.TrainingTid,
                        principalTable: "Training",
                        principalColumn: "Tid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_User_Uid",
                        column: x => x.Uid,
                        principalTable: "User",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Mid",
                table: "Payment",
                column: "Mid");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_TrainingTid",
                table: "Payment",
                column: "TrainingTid");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Uid",
                table: "Payment",
                column: "Uid");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Mid",
                table: "Training",
                column: "Mid");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Sid",
                table: "Training",
                column: "Sid");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Uid",
                table: "Training",
                column: "Uid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
