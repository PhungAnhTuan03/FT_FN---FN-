﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portal_job_FN.Migrations
{
    /// <inheritdoc />
    public partial class initDBBBB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "application_company_id",
                table: "apply_Jobs",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "application_company_id",
                table: "apply_Jobs");
        }
    }
}
