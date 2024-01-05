using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class makeguiduniqueinEquipmenttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("e1f6fe37-665a-4ef4-ae07-d852de1dadd6"));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("0d4dfedd-2134-42cc-ad04-48bc67c9917a"));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("0c28c0e5-e89c-4070-bcd6-26f361af58f5"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("e401be37-3cb8-4339-9430-3a34a6fef085"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("b76727ec-fcd0-4eb2-828c-899816c189d8"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("b7ab8d98-23bb-41a5-94b5-8a9c76f68984"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("2df462bf-bd85-48b0-aa92-f85effa01699"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("67b269a2-3e40-45f7-b36f-ca08ce15f6cb"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("daa57348-ca21-4341-85c4-056053229f55"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("d3b01956-8a13-408d-8bc4-0107679440ab"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("953e1537-beb8-4050-ab3a-5af85a7cf926"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("a4b19609-98b1-4971-81ca-ec68ecfaf838"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("c63d671d-e816-4ba4-ab3a-96872c7f7fd9"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("cfac124a-0ee0-432b-8aad-e43ddd40e1e0"));

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Guid",
                table: "Equipments",
                column: "Guid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Equipments_Guid",
                table: "Equipments");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("2d927dc9-9568-4554-9b42-2aae2a026409"));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("2fbe30b3-5224-4d3e-880a-226f128ff24e"));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("7f699f15-a972-404c-b2cc-f54315a87442"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("13e4e1c8-9548-44ec-bd09-4c1c2ca29257"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("934fc7fe-1fcc-4600-a7b0-46dd1624b953"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: new Guid("a379b070-07f0-4ea3-b06d-4effb3eb5caa"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: new Guid("e47f5ba5-4830-435c-9041-12f8af485396"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: new Guid("c79679dc-59ab-4c88-afeb-a9f65fdaabcb"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: new Guid("90e5449b-9d24-4618-a40c-26731204a3dc"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: new Guid("9d941ecd-e212-4852-8231-f040f15f11f5"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: new Guid("43790d45-7251-45df-ae26-9107345b495d"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: new Guid("395fd1d3-4a34-44da-b50c-74bc85149e47"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: new Guid("5088da03-2e65-4c63-8a13-27c31d2b7593"));

            migrationBuilder.UpdateData(
                table: "WeaponProperties",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: new Guid("523b4c22-aa24-4aef-962f-7831ec531360"));
        }
    }
}
