using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Dilemma.DAL.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dilemmas",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("162fa395-e7d3-4d6f-9a2d-59e9860d062a"), "Dilemma 1" },
                    { new Guid("0e97b21f-f5e6-4fda-acef-e500cc3ec2aa"), "Dilemma 2" },
                    { new Guid("90b4e40e-84ab-4977-8b81-ac29bf305a6b"), "Dilemma 3" }
                });

            migrationBuilder.InsertData(
                table: "Solutions",
                columns: new[] { "Id", "DilemmaId", "Image", "Rate", "Text" },
                values: new object[,]
                {
                    { new Guid("66a360e7-2ee4-4dba-82b6-5efd83402081"), new Guid("162fa395-e7d3-4d6f-9a2d-59e9860d062a"), "dilemma_1_solution_1.jpeg", 0.69999999999999996, "Dilemma 1 Solution 1" },
                    { new Guid("717e11a7-2fe7-43eb-a2ce-699eeaf3d9d7"), new Guid("162fa395-e7d3-4d6f-9a2d-59e9860d062a"), "dilemma_1_solution_2.jpeg", -0.40000000000000002, "Dilemma 1 Solution 2" },
                    { new Guid("1dd7f1aa-7ecf-4804-9bff-1862e01a5b0a"), new Guid("0e97b21f-f5e6-4fda-acef-e500cc3ec2aa"), "dilemma_1_solution_1.jpeg", 0.40000000000000002, "Dilemma 2 Solution 1" },
                    { new Guid("25f1de4e-5dbd-4b12-b4fd-53cc9194f672"), new Guid("0e97b21f-f5e6-4fda-acef-e500cc3ec2aa"), "dilemma_1_solution_2.jpeg", -0.5, "Dilemma 2 Solution 2" },
                    { new Guid("aa39be35-41c5-411e-923d-a1139cef286b"), new Guid("90b4e40e-84ab-4977-8b81-ac29bf305a6b"), "dilemma_1_solution_1.jpeg", 0.59999999999999998, "Dilemma 3 Solution 1" },
                    { new Guid("fd7d0f5d-738c-46e4-957c-4abfec5b8c1a"), new Guid("90b4e40e-84ab-4977-8b81-ac29bf305a6b"), "dilemma_1_solution_2.jpeg", -0.20000000000000001, "Dilemma 3 Solution 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("1dd7f1aa-7ecf-4804-9bff-1862e01a5b0a"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("25f1de4e-5dbd-4b12-b4fd-53cc9194f672"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("66a360e7-2ee4-4dba-82b6-5efd83402081"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("717e11a7-2fe7-43eb-a2ce-699eeaf3d9d7"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("aa39be35-41c5-411e-923d-a1139cef286b"));

            migrationBuilder.DeleteData(
                table: "Solutions",
                keyColumn: "Id",
                keyValue: new Guid("fd7d0f5d-738c-46e4-957c-4abfec5b8c1a"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("0e97b21f-f5e6-4fda-acef-e500cc3ec2aa"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("162fa395-e7d3-4d6f-9a2d-59e9860d062a"));

            migrationBuilder.DeleteData(
                table: "Dilemmas",
                keyColumn: "Id",
                keyValue: new Guid("90b4e40e-84ab-4977-8b81-ac29bf305a6b"));
        }
    }
}
