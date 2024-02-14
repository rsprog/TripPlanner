using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TripPlanner.API.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDateFromDestination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Destinations_PreviousDestinationId",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_PreviousDestinationId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DepartureDate",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "PreviousDestinationId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DayNumber",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "SequenceNumber",
                table: "Activities");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Activities",
                newName: "Date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Activities",
                newName: "Time");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DepartureDate",
                table: "Destinations",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "PreviousDestinationId",
                table: "Destinations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayNumber",
                table: "Activities",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SequenceNumber",
                table: "Activities",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_PreviousDestinationId",
                table: "Destinations",
                column: "PreviousDestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Destinations_PreviousDestinationId",
                table: "Destinations",
                column: "PreviousDestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
