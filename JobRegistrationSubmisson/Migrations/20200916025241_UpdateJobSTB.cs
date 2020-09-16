using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobRegistrationSubmisson.Migrations
{
    public partial class UpdateJobSTB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Approve",
                table: "TB_M_JobSeeker",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "RegistDate",
                table: "TB_M_JobSeeker",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<bool>(
                name: "Reject",
                table: "TB_M_JobSeeker",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "RejectDate",
                table: "TB_M_JobSeeker",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdateDate",
                table: "TB_M_JobSeeker",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedData",
                table: "TB_M_Employee",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedData",
                table: "TB_M_Employee",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdatedData",
                table: "TB_M_Employee",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<bool>(
                name: "isDelete",
                table: "TB_M_Employee",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approve",
                table: "TB_M_JobSeeker");

            migrationBuilder.DropColumn(
                name: "RegistDate",
                table: "TB_M_JobSeeker");

            migrationBuilder.DropColumn(
                name: "Reject",
                table: "TB_M_JobSeeker");

            migrationBuilder.DropColumn(
                name: "RejectDate",
                table: "TB_M_JobSeeker");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TB_M_JobSeeker");

            migrationBuilder.DropColumn(
                name: "CreatedData",
                table: "TB_M_Employee");

            migrationBuilder.DropColumn(
                name: "DeletedData",
                table: "TB_M_Employee");

            migrationBuilder.DropColumn(
                name: "UpdatedData",
                table: "TB_M_Employee");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "TB_M_Employee");
        }
    }
}
