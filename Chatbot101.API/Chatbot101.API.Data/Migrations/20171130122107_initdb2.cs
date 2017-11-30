using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Chatbot101.API.Data.Migrations
{
    public partial class initdb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IncomingData",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IsProcessed = table.Column<bool>(nullable: false),
                    RawData = table.Column<string>(nullable: true),
                    ReferenceID = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomingData", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncomingData");
        }
    }
}
