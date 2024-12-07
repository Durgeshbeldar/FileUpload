using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pagination.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RollNo = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Name", "RollNo" },
                values: new object[,]
                {
                    { new Guid("0f5d492e-b509-424e-b180-136f1697e52a"), "Pune", "Simran Kaur", 30 },
                    { new Guid("1bbe8309-d595-4a5e-9327-31608556ed48"), "Mumbai", "Tanvi Mehta", 34 },
                    { new Guid("1ec05bdb-1216-42ab-b978-e29257ec0046"), "Delhi", "Vishal Kumar", 57 },
                    { new Guid("2af9af0b-a21e-4851-8cf7-a4d499e4a58d"), "Delhi", "Vikram Yadav", 31 },
                    { new Guid("2f790e80-599f-4e8d-a5c3-cef319e15b02"), "Pune", "Karan Deshmukh", 35 },
                    { new Guid("3f0d2bb4-e762-4ed0-b133-732525154392"), "Nagpur", "Nikita Singh", 36 },
                    { new Guid("3f6a10d7-99e4-4a73-8cb1-76295850f9a8"), "Delhi", "Parul Sharma", 42 },
                    { new Guid("43577e46-cc8d-426f-bdae-329803711200"), "Mumbai", "Ravi Sharma", 29 },
                    { new Guid("47addbb1-5bd5-4269-9d44-abc31ac6e349"), "Nagpur", "Aarti Agarwal", 32 },
                    { new Guid("47d44011-c793-4608-844e-9994494d902b"), "Chennai", "Ankit Singh", 28 },
                    { new Guid("4bdea171-0bc8-4392-b02a-e1af563dc402"), "Chennai", "Sakshi Sharma", 38 },
                    { new Guid("52429c67-d79d-4b02-9dfb-4bcd55316bfd"), "Nagpur", "Madhuri Gupta", 51 },
                    { new Guid("5ecfb4d1-ec5d-417a-a00a-f6cc7135cce4"), "Delhi", "Pranav Joshi", 52 },
                    { new Guid("65354df2-c141-4592-9136-8afef1dd5425"), "Mumbai", "Harshita Singh", 49 },
                    { new Guid("68cb2ae4-9e38-417e-a711-2edc3efc33f9"), "Mumbai", "Amit Kumar", 24 },
                    { new Guid("69a2eebe-03cc-47fe-a6f8-8cffdb0181a3"), "Chennai", "Manish Joshi", 33 },
                    { new Guid("6a210f44-758e-4865-a5e4-37cf05e12363"), "Nagpur", "Shyam Kumavat", 23 },
                    { new Guid("6c129cd9-390b-45cd-b722-bbdb72f8699f"), "Chennai", "Siddharth Thakur", 43 },
                    { new Guid("7a85e196-ae09-44be-ba90-03d0fe9f0cbc"), "Pune", "Tushar Yadav", 55 },
                    { new Guid("7d37cdee-eef7-489b-99ce-e83ab5b67332"), "Nagpur", "Mehul Jain", 41 },
                    { new Guid("870e29c7-eebb-45a5-9584-bddd18453505"), "Mumbai", "Isha Gupta", 44 },
                    { new Guid("8c28ed92-ad9f-49b6-9d3a-b1a9cc92d9ee"), "Delhi", "Pradeep Kumar", 37 },
                    { new Guid("8ea0cf98-39f8-458e-9957-7e1aa91b1e65"), "Chennai", "Gaurav Patil", 53 },
                    { new Guid("941cbb07-abd6-494a-af89-809dca93c679"), "Mumbai", "Sonali Verma", 54 },
                    { new Guid("9904381d-f48c-4e50-ad73-65f6123e368b"), "Pune", "Sandeep Raghav", 50 },
                    { new Guid("9e6943b4-abf4-4bec-8174-dc3ef98d1790"), "Pune", "Priya Verma", 25 },
                    { new Guid("a3c0dfad-35a7-4f2f-b99a-0493ffe2b463"), "Delhi", "Raj Patel", 27 },
                    { new Guid("a52da703-185c-4f60-b35c-d8fceff4d5c4"), "Nagpur", "Kajal Verma", 46 },
                    { new Guid("a96d2ed9-7fbd-4603-b536-3a6cc8632736"), "Chennai", "Rohit Pandey", 48 },
                    { new Guid("c8bd6769-f001-451d-8fb5-964a58155948"), "Pune", "Akhil Gupta", 40 },
                    { new Guid("cb33c27d-5d5d-4707-a9d0-eee1a16f7b30"), "Nagpur", "Neha Joshi", 26 },
                    { new Guid("cd040291-1d90-4077-b693-061d232870b7"), "Delhi", "Devika Reddy", 47 },
                    { new Guid("d294d84a-d023-4303-8ee7-c8abe1723563"), "Pune", "Tarun Kumar", 45 },
                    { new Guid("d7e69f79-6745-40a0-b4f4-0ed6bb493661"), "Nagpur", "Pooja Mehta", 56 },
                    { new Guid("e0740b9a-019d-45e9-bac6-3b969afee707"), "Mumbai", "Ritika Patel", 39 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
