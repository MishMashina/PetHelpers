using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetHelpers.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "volunteers",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    full_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    phone_number = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    years_of_experience = table.Column<int>(type: "integer", nullable: false),
                    pets_found_home = table.Column<int>(type: "integer", nullable: false),
                    pets_looking_for_home = table.Column<int>(type: "integer", nullable: false),
                    pets_in_treatment = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_volunteers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pet",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    volunteer_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    species = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    color = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    health_info = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    location = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    owners_phone_number = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    weight = table.Column<int>(type: "integer", nullable: false),
                    height = table.Column<int>(type: "integer", nullable: false),
                    is_castrated = table.Column<bool>(type: "boolean", nullable: false),
                    is_vaccinated = table.Column<bool>(type: "boolean", nullable: false),
                    birthdate = table.Column<DateOnly>(type: "date", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    help_status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pet", x => x.id);
                    table.ForeignKey(
                        name: "fk_pet_volunteers_volunteer_id",
                        column: x => x.volunteer_id,
                        principalTable: "volunteers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "social_media",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    link = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
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

            migrationBuilder.CreateTable(
                name: "pet_photo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_main = table.Column<bool>(type: "boolean", nullable: false),
                    path = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    pet_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pet_photo", x => x.id);
                    table.ForeignKey(
                        name: "fk_pet_photo_pet_pet_id",
                        column: x => x.pet_id,
                        principalTable: "pet",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "requisite",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    pet_id = table.Column<Guid>(type: "uuid", nullable: true),
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

            migrationBuilder.CreateIndex(
                name: "ix_pet_volunteer_id",
                table: "pet",
                column: "volunteer_id");

            migrationBuilder.CreateIndex(
                name: "ix_pet_photo_pet_id",
                table: "pet_photo",
                column: "pet_id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pet_photo");

            migrationBuilder.DropTable(
                name: "requisite");

            migrationBuilder.DropTable(
                name: "social_media");

            migrationBuilder.DropTable(
                name: "pet");

            migrationBuilder.DropTable(
                name: "volunteers");
        }
    }
}
