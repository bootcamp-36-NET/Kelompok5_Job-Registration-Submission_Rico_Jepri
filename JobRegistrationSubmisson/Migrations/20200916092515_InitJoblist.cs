using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRegistrationSubmisson.Migrations
{
    public partial class InitJoblist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Employees",
                columns: table => new
                {
                    EmpId = table.Column<string>(nullable: false),
                    Adress = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTimeOffset>(nullable: false),
                    UpdateTime = table.Column<DateTimeOffset>(nullable: false),
                    DeleteTime = table.Column<DateTimeOffset>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Employees", x => x.EmpId);
                    table.ForeignKey(
                        name: "FK_Tb_Employees_TB_M_User_EmpId",
                        column: x => x.EmpId,
                        principalTable: "TB_M_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_Trans_Joblist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CreateData = table.Column<DateTimeOffset>(nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(nullable: false),
                    DeleteData = table.Column<DateTimeOffset>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Trans_Joblist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_JobSeeker",
                columns: table => new
                {
                    JobSId = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Birth_Date = table.Column<DateTime>(nullable: false),
                    Nationality = table.Column<string>(nullable: true),
                    Marital_Status = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    Last_Education = table.Column<string>(nullable: true),
                    GPA = table.Column<string>(nullable: true),
                    Technical_Skill = table.Column<string>(nullable: true),
                    Experience = table.Column<string>(nullable: true),
                    Achievement = table.Column<string>(nullable: true),
                    RegistDate = table.Column<DateTimeOffset>(nullable: false),
                    UpdateDate = table.Column<DateTimeOffset>(nullable: false),
                    RejectDate = table.Column<DateTimeOffset>(nullable: false),
                    Approve = table.Column<bool>(nullable: false),
                    Reject = table.Column<bool>(nullable: false),
                    JoblistId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_JobSeeker", x => x.JobSId);
                    table.ForeignKey(
                        name: "FK_TB_M_JobSeeker_TB_M_User_JobSId",
                        column: x => x.JobSId,
                        principalTable: "TB_M_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_M_JobSeeker_TB_Trans_Joblist_JoblistId",
                        column: x => x.JoblistId,
                        principalTable: "TB_Trans_Joblist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_JobSeeker_JoblistId",
                table: "TB_M_JobSeeker",
                column: "JoblistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Employees");

            migrationBuilder.DropTable(
                name: "TB_M_JobSeeker");

            migrationBuilder.DropTable(
                name: "TB_Trans_Joblist");
        }
    }
}
