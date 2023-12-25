using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DnD.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aligment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalityTraits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ideals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bonds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flaws = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceId = table.Column<int>(type: "int", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    AbilityScoresId = table.Column<int>(type: "int", nullable: true),
                    DescriptionId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Abilities_AbilityScoresId",
                        column: x => x.AbilityScoresId,
                        principalTable: "Abilities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Descriptions_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Descriptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Damage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipments_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WeaponProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponProperties_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CreatedAt", "Guid", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), new Guid("2d927dc9-9568-4554-9b42-2aae2a026409"), "Warrior", null });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "CharacterId", "Cost", "CreatedAt", "Damage", "Description", "Guid", "Name", "UpdatedAt", "Weight" },
                values: new object[] { 1, null, 1000, new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), "1d8", "-", new Guid("2fbe30b3-5224-4d3e-880a-226f128ff24e"), "BattleAxe", null, 4f });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "CreatedAt", "Guid", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), new Guid("7f699f15-a972-404c-b2cc-f54315a87442"), "Human", null });

            migrationBuilder.InsertData(
                table: "WeaponProperties",
                columns: new[] { "Id", "CreatedAt", "Description", "EquipmentId", "Guid", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), "ToDo", null, new Guid("13e4e1c8-9548-44ec-bd09-4c1c2ca29257"), "Ammunition", null },
                    { 2, new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), "ToDo", null, new Guid("934fc7fe-1fcc-4600-a7b0-46dd1624b953"), "Finese", null },
                    { 3, new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), "ToDo", null, new Guid("a379b070-07f0-4ea3-b06d-4effb3eb5caa"), "Heavy", null },
                    { 4, new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), "ToDo", null, new Guid("e47f5ba5-4830-435c-9041-12f8af485396"), "Light", null },
                    { 5, new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), "ToDo", null, new Guid("c79679dc-59ab-4c88-afeb-a9f65fdaabcb"), "Loading", null },
                    { 6, new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), "ToDo", null, new Guid("90e5449b-9d24-4618-a40c-26731204a3dc"), "Range", null },
                    { 7, new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), "ToDo", null, new Guid("9d941ecd-e212-4852-8231-f040f15f11f5"), "Reach", null },
                    { 8, new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), "ToDo", null, new Guid("43790d45-7251-45df-ae26-9107345b495d"), "Special", null },
                    { 9, new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), "ToDo", null, new Guid("395fd1d3-4a34-44da-b50c-74bc85149e47"), "Thrown", null },
                    { 10, new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), "ToDo", null, new Guid("5088da03-2e65-4c63-8a13-27c31d2b7593"), "TwoHanded", null },
                    { 11, new DateTime(2000, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc), "ToDo", null, new Guid("523b4c22-aa24-4aef-962f-7831ec531360"), "Versatile", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AbilityScoresId",
                table: "Characters",
                column: "AbilityScoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ClassId",
                table: "Characters",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_DescriptionId",
                table: "Characters",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_CharacterId",
                table: "Equipments",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponProperties_EquipmentId",
                table: "WeaponProperties",
                column: "EquipmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponProperties");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
