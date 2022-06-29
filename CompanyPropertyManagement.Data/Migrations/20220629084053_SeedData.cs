using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyPropertyManagement.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("561de9a3-70d5-42d2-971c-0e19ad1ad677"), 0, "7d1f7836-d2eb-4d33-bbd7-33e65b8abe2a", null, false, false, null, null, null, null, null, false, null, false, "Employee1" });

            migrationBuilder.InsertData(
                table: "BUs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), "Unit 1" },
                    { new Guid("29d9185f-9ca8-4f15-a86d-f11adbf0f36b"), "Unit 2" },
                    { new Guid("fb92c360-448c-4e52-9080-85d7a59bfc92"), "Unit 3" },
                    { new Guid("35cbe220-d0dc-4258-933a-f0b4d7fc4b67"), "Unit 4" },
                    { new Guid("2b1e8d1a-50b6-40a8-8d58-9fc464b416e2"), "Unit 5" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bcc8fd90-c064-46a2-9b41-c0db1180c15d"), "Screen" },
                    { new Guid("16dabedd-5252-4e8e-a149-3dd409b5f698"), "Keyboard" },
                    { new Guid("658e17b9-871c-4a18-b29a-ab6d9aa4cb00"), "Mouse" },
                    { new Guid("b2174ae3-d9e9-4f44-934e-2b43ca071710"), "Chair" },
                    { new Guid("99f0bb8e-5b87-4b01-9a8f-fdd5f4f73a39"), "Table" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "BuId", "CategoryId", "Info" },
                values: new object[,]
                {
                    { new Guid("99e948ca-1897-4973-bf44-4dac4b4da6d8"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("bcc8fd90-c064-46a2-9b41-c0db1180c15d"), null },
                    { new Guid("88ba0577-b66d-4d8a-ac8b-530b8b2e050c"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("99f0bb8e-5b87-4b01-9a8f-fdd5f4f73a39"), null },
                    { new Guid("5eaf5103-f90b-43e4-878d-d9663d107b89"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("99f0bb8e-5b87-4b01-9a8f-fdd5f4f73a39"), null },
                    { new Guid("c7378e56-7659-4d3e-a5ee-d352e26965c0"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("99f0bb8e-5b87-4b01-9a8f-fdd5f4f73a39"), null },
                    { new Guid("02749fad-aa90-4a87-a4b1-2f2f46dd3851"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("b2174ae3-d9e9-4f44-934e-2b43ca071710"), null },
                    { new Guid("e540f085-a188-436a-8af9-54c049ae22ab"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("b2174ae3-d9e9-4f44-934e-2b43ca071710"), null },
                    { new Guid("656b7c0a-23b3-411e-96d0-85021b35c828"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("b2174ae3-d9e9-4f44-934e-2b43ca071710"), null },
                    { new Guid("b41a1297-c7f8-4c1f-887f-2f6ee5813930"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("b2174ae3-d9e9-4f44-934e-2b43ca071710"), null },
                    { new Guid("dec405eb-d8c1-439e-86b2-b63976c41458"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("b2174ae3-d9e9-4f44-934e-2b43ca071710"), null },
                    { new Guid("0412cedb-b55e-42a4-bee2-aa73d65c91d0"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("658e17b9-871c-4a18-b29a-ab6d9aa4cb00"), null },
                    { new Guid("6ee9c83f-3452-4500-8e5c-ced1ae39ede8"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("658e17b9-871c-4a18-b29a-ab6d9aa4cb00"), null },
                    { new Guid("def95b2e-2a0e-4e12-8205-585114fc108e"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("99f0bb8e-5b87-4b01-9a8f-fdd5f4f73a39"), null },
                    { new Guid("901e14e8-ca46-49c8-8a14-641a0c869145"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("658e17b9-871c-4a18-b29a-ab6d9aa4cb00"), null },
                    { new Guid("0583e4db-4a25-4b16-b483-d572f5d740b4"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("658e17b9-871c-4a18-b29a-ab6d9aa4cb00"), null },
                    { new Guid("cfccc6ea-2888-47cd-bb85-00f02bb7a6b0"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("16dabedd-5252-4e8e-a149-3dd409b5f698"), null },
                    { new Guid("827d08f2-99e7-4410-9c28-82609447beba"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("16dabedd-5252-4e8e-a149-3dd409b5f698"), null },
                    { new Guid("6c815a3e-f13f-4577-9aa0-4a1166762fc8"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("16dabedd-5252-4e8e-a149-3dd409b5f698"), null },
                    { new Guid("0bc697e0-ad88-4b8b-811b-36820b427e1c"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("16dabedd-5252-4e8e-a149-3dd409b5f698"), null },
                    { new Guid("fcfab7a5-338f-4bae-8697-74c0f1e452b4"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("16dabedd-5252-4e8e-a149-3dd409b5f698"), null },
                    { new Guid("3f5a1732-9730-4aa6-a014-9f3d4953f791"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("bcc8fd90-c064-46a2-9b41-c0db1180c15d"), null },
                    { new Guid("739c6511-9b77-445b-b38f-a90d90c4e2aa"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("bcc8fd90-c064-46a2-9b41-c0db1180c15d"), null },
                    { new Guid("93de01c0-ce54-4447-9b9f-a84caaf1485c"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("bcc8fd90-c064-46a2-9b41-c0db1180c15d"), null },
                    { new Guid("ab610c59-5c76-4031-9130-9648f40f144e"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("bcc8fd90-c064-46a2-9b41-c0db1180c15d"), null },
                    { new Guid("898b9ef9-172c-49c2-b9e4-6fa0d42dadd3"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("658e17b9-871c-4a18-b29a-ab6d9aa4cb00"), null },
                    { new Guid("62e057da-9c6d-4795-a883-913c0979d218"), new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"), new Guid("99f0bb8e-5b87-4b01-9a8f-fdd5f4f73a39"), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("561de9a3-70d5-42d2-971c-0e19ad1ad677"));

            migrationBuilder.DeleteData(
                table: "BUs",
                keyColumn: "Id",
                keyValue: new Guid("29d9185f-9ca8-4f15-a86d-f11adbf0f36b"));

            migrationBuilder.DeleteData(
                table: "BUs",
                keyColumn: "Id",
                keyValue: new Guid("2b1e8d1a-50b6-40a8-8d58-9fc464b416e2"));

            migrationBuilder.DeleteData(
                table: "BUs",
                keyColumn: "Id",
                keyValue: new Guid("35cbe220-d0dc-4258-933a-f0b4d7fc4b67"));

            migrationBuilder.DeleteData(
                table: "BUs",
                keyColumn: "Id",
                keyValue: new Guid("fb92c360-448c-4e52-9080-85d7a59bfc92"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("02749fad-aa90-4a87-a4b1-2f2f46dd3851"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("0412cedb-b55e-42a4-bee2-aa73d65c91d0"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("0583e4db-4a25-4b16-b483-d572f5d740b4"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("0bc697e0-ad88-4b8b-811b-36820b427e1c"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("3f5a1732-9730-4aa6-a014-9f3d4953f791"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("5eaf5103-f90b-43e4-878d-d9663d107b89"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("62e057da-9c6d-4795-a883-913c0979d218"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("656b7c0a-23b3-411e-96d0-85021b35c828"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("6c815a3e-f13f-4577-9aa0-4a1166762fc8"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("6ee9c83f-3452-4500-8e5c-ced1ae39ede8"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("739c6511-9b77-445b-b38f-a90d90c4e2aa"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("827d08f2-99e7-4410-9c28-82609447beba"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("88ba0577-b66d-4d8a-ac8b-530b8b2e050c"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("898b9ef9-172c-49c2-b9e4-6fa0d42dadd3"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("901e14e8-ca46-49c8-8a14-641a0c869145"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("93de01c0-ce54-4447-9b9f-a84caaf1485c"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("99e948ca-1897-4973-bf44-4dac4b4da6d8"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("ab610c59-5c76-4031-9130-9648f40f144e"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("b41a1297-c7f8-4c1f-887f-2f6ee5813930"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("c7378e56-7659-4d3e-a5ee-d352e26965c0"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("cfccc6ea-2888-47cd-bb85-00f02bb7a6b0"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("dec405eb-d8c1-439e-86b2-b63976c41458"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("def95b2e-2a0e-4e12-8205-585114fc108e"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("e540f085-a188-436a-8af9-54c049ae22ab"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("fcfab7a5-338f-4bae-8697-74c0f1e452b4"));

            migrationBuilder.DeleteData(
                table: "BUs",
                keyColumn: "Id",
                keyValue: new Guid("9c15bf3f-72d1-4ddc-8f23-e366e459399c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("16dabedd-5252-4e8e-a149-3dd409b5f698"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("658e17b9-871c-4a18-b29a-ab6d9aa4cb00"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99f0bb8e-5b87-4b01-9a8f-fdd5f4f73a39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2174ae3-d9e9-4f44-934e-2b43ca071710"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bcc8fd90-c064-46a2-9b41-c0db1180c15d"));
        }
    }
}
