using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetHelpers.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreatedbaseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_pet_volunteers_volunteer_id",
                table: "pet");

            migrationBuilder.AlterColumn<Guid>(
                name: "volunteer_id",
                table: "pet",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "fk_pet_volunteers_volunteer_id",
                table: "pet",
                column: "volunteer_id",
                principalTable: "volunteers",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_pet_volunteers_volunteer_id",
                table: "pet");

            migrationBuilder.AlterColumn<Guid>(
                name: "volunteer_id",
                table: "pet",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_pet_volunteers_volunteer_id",
                table: "pet",
                column: "volunteer_id",
                principalTable: "volunteers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
