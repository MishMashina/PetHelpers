using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetHelpers.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Addvalueobjectstomainmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "requisite");

            migrationBuilder.DropTable(
                name: "social_media");

            migrationBuilder.DropColumn(
                name: "phone_number",
                table: "volunteers");

            migrationBuilder.DropColumn(
                name: "help_status",
                table: "pet");

            migrationBuilder.DropColumn(
                name: "owners_phone_number",
                table: "pet");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "volunteers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "volunteers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "volunteers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "requisites",
                table: "volunteers",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "social_medias",
                table: "volunteers",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "weight",
                table: "pet",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<double>(
                name: "height",
                table: "pet",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "HelpStatus",
                table: "pet",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnersPhoneNumber",
                table: "pet",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "requisites",
                table: "pet",
                type: "jsonb",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "volunteers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "volunteers");

            migrationBuilder.DropColumn(
                name: "requisites",
                table: "volunteers");

            migrationBuilder.DropColumn(
                name: "social_medias",
                table: "volunteers");

            migrationBuilder.DropColumn(
                name: "HelpStatus",
                table: "pet");

            migrationBuilder.DropColumn(
                name: "OwnersPhoneNumber",
                table: "pet");

            migrationBuilder.DropColumn(
                name: "requisites",
                table: "pet");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "volunteers",
                newName: "full_name");

            migrationBuilder.AddColumn<string>(
                name: "phone_number",
                table: "volunteers",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "weight",
                table: "pet",
                type: "integer",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<int>(
                name: "height",
                table: "pet",
                type: "integer",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AddColumn<int>(
                name: "help_status",
                table: "pet",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "owners_phone_number",
                table: "pet",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "requisite",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    pet_id = table.Column<Guid>(type: "uuid", nullable: true),
                    title = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    volunteer_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_requisite", x => x.id);
                    table.ForeignKey(
                        name: "fk_requisite_pet_pet_id",
                        column: x => x.pet_id,
                        principalTable: "pet",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_requisite_volunteers_volunteer_id",
                        column: x => x.volunteer_id,
                        principalTable: "volunteers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "social_media",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    link = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    volunteer_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_social_media", x => x.id);
                    table.ForeignKey(
                        name: "fk_social_media_volunteers_volunteer_id",
                        column: x => x.volunteer_id,
                        principalTable: "volunteers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "ix_requisite_pet_id",
                table: "requisite",
                column: "pet_id");

            migrationBuilder.CreateIndex(
                name: "ix_requisite_volunteer_id",
                table: "requisite",
                column: "volunteer_id");

            migrationBuilder.CreateIndex(
                name: "ix_social_media_volunteer_id",
                table: "social_media",
                column: "volunteer_id");
        }
    }
}
