using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpraApi.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Staff",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Staff",
                columns: new[] { "Id", "AddressLine", "City", "Country", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "FirstName", "LastName", "Phone", "Province", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Apt. 548", "Stoltenbergside", "Suriname", new DateTime(2023, 5, 11, 18, 54, 19, 185, DateTimeKind.Utc).AddTicks(7322), "admin", new DateTime(1957, 9, 8, 15, 30, 4, 457, DateTimeKind.Local).AddTicks(5211), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "roxanne.runolfsson21@gmail.com", "Roxanne", "Runolfsson", "69019880565", "Illinois", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Suite 860", "Royceside", "Spain", new DateTime(2023, 5, 11, 18, 54, 19, 185, DateTimeKind.Utc).AddTicks(9801), "admin", new DateTime(1991, 5, 29, 23, 41, 57, 662, DateTimeKind.Local).AddTicks(2693), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "spencer.block@hotmail.com", "Spencer", "Block", "42130698756", "Indiana", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Suite 849", "Lake Alainaville", "Senegal", new DateTime(2023, 5, 11, 18, 54, 19, 186, DateTimeKind.Utc).AddTicks(921), "admin", new DateTime(1968, 9, 15, 13, 32, 14, 347, DateTimeKind.Local).AddTicks(9299), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "virgil.skiles@gmail.com", "Virgil", "Skiles", "64560676037", "Nebraska", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "Suite 779", "Greenfelderside", "French Polynesia", new DateTime(2023, 5, 11, 18, 54, 19, 186, DateTimeKind.Utc).AddTicks(1910), "admin", new DateTime(1979, 3, 22, 9, 47, 34, 22, DateTimeKind.Local).AddTicks(1727), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "theresa5@yahoo.com", "Theresa", "Lang", "08000068143", "Idaho", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "Apt. 432", "West Zoila", "Mexico", new DateTime(2023, 5, 11, 18, 54, 19, 186, DateTimeKind.Utc).AddTicks(2870), "admin", new DateTime(1978, 3, 20, 8, 27, 37, 25, DateTimeKind.Local).AddTicks(309), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "willie.abernathy@yahoo.com", "Willie", "Abernathy", "19108558830", "Hawaii", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "Apt. 948", "New Dulce", "Bhutan", new DateTime(2023, 5, 11, 18, 54, 19, 186, DateTimeKind.Utc).AddTicks(3873), "admin", new DateTime(2002, 5, 30, 10, 39, 35, 38, DateTimeKind.Local).AddTicks(7320), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "judy.weimann74@yahoo.com", "Judy", "Weimann", "12590757150", "South Carolina", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "Apt. 290", "Schinnerton", "British Indian Ocean", new DateTime(2023, 5, 11, 18, 54, 19, 186, DateTimeKind.Utc).AddTicks(4827), "admin", new DateTime(1991, 6, 26, 2, 33, 39, 42, DateTimeKind.Local).AddTicks(4829), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "vickie11@yahoo.com", "Vickie", "Heidenreich", "29296417177", "Massachusetts", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "Apt. 444", "New Chasefurt", "Solomon Islands", new DateTime(2023, 5, 11, 18, 54, 19, 186, DateTimeKind.Utc).AddTicks(5787), "admin", new DateTime(1976, 3, 12, 19, 33, 52, 354, DateTimeKind.Local).AddTicks(5438), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "emilio.carter84@gmail.com", "Emilio", "Carter", "95125652570", "Missouri", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "Apt. 439", "South Jarenmouth", "Sao Tome and Princip", new DateTime(2023, 5, 11, 18, 54, 19, 186, DateTimeKind.Utc).AddTicks(6742), "admin", new DateTime(1982, 8, 27, 0, 37, 0, 7, DateTimeKind.Local).AddTicks(2317), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "vicki.green57@hotmail.com", "Vicki", "Green", "95804034622", "Wisconsin", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "Suite 253", "Mireyafurt", "Egypt", new DateTime(2023, 5, 11, 18, 54, 19, 186, DateTimeKind.Utc).AddTicks(7647), "admin", new DateTime(1954, 6, 7, 5, 10, 51, 970, DateTimeKind.Local).AddTicks(1463), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "clarence.rath@gmail.com", "Clarence", "Rath", "50105240531", "New York", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, "Suite 752", "Smithamhaven", "Iran", new DateTime(2023, 5, 11, 18, 54, 19, 186, DateTimeKind.Utc).AddTicks(8508), "admin", new DateTime(1971, 4, 7, 23, 20, 37, 949, DateTimeKind.Local).AddTicks(4954), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "betty69@yahoo.com", "Betty", "Sanford", "25296144051", "Iowa", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, "Apt. 228", "Alexannemouth", "Guatemala", new DateTime(2023, 5, 11, 18, 54, 19, 186, DateTimeKind.Utc).AddTicks(9385), "admin", new DateTime(1971, 6, 16, 5, 26, 12, 271, DateTimeKind.Local).AddTicks(9173), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "guillermo.mayert68@yahoo.com", "Guillermo", "Mayert", "58555758445", "North Dakota", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, "Apt. 231", "South Frederique", "Samoa", new DateTime(2023, 5, 11, 18, 54, 19, 187, DateTimeKind.Utc).AddTicks(449), "admin", new DateTime(1980, 12, 23, 9, 11, 18, 900, DateTimeKind.Local).AddTicks(418), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "marion_boehm22@yahoo.com", "Marion", "Boehm", "60725877760", "Iowa", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, "Suite 201", "Shanahaven", "Chile", new DateTime(2023, 5, 11, 18, 54, 19, 187, DateTimeKind.Utc).AddTicks(1363), "admin", new DateTime(1962, 10, 26, 4, 35, 47, 419, DateTimeKind.Local).AddTicks(7251), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "eloise15@yahoo.com", "Eloise", "Morar", "32440683981", "Nevada", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, "Apt. 943", "Gerryfort", "Saudi Arabia", new DateTime(2023, 5, 11, 18, 54, 19, 187, DateTimeKind.Utc).AddTicks(2277), "admin", new DateTime(1983, 12, 2, 15, 21, 44, 24, DateTimeKind.Local).AddTicks(8243), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "terrell.erdman42@yahoo.com", "Terrell", "Erdman", "18519570144", "Mississippi", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, "Apt. 812", "West Dashawnton", "Egypt", new DateTime(2023, 5, 11, 18, 54, 19, 187, DateTimeKind.Utc).AddTicks(3186), "admin", new DateTime(1975, 1, 3, 16, 5, 21, 379, DateTimeKind.Local).AddTicks(1593), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "patricia88@yahoo.com", "Patricia", "Wilkinson", "87326366335", "Rhode Island", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, "Suite 670", "Lake Jordane", "Bahrain", new DateTime(2023, 5, 11, 18, 54, 19, 187, DateTimeKind.Utc).AddTicks(4148), "admin", new DateTime(1954, 7, 30, 10, 23, 26, 731, DateTimeKind.Local).AddTicks(8166), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "agnes_damore@gmail.com", "Agnes", "D'Amore", "06720046475", "Missouri", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, "Suite 832", "East Creolamouth", "Haiti", new DateTime(2023, 5, 11, 18, 54, 19, 187, DateTimeKind.Utc).AddTicks(5174), "admin", new DateTime(1964, 3, 22, 1, 56, 4, 288, DateTimeKind.Local).AddTicks(4048), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "robert23@hotmail.com", "Robert", "Jaskolski", "03027608512", "Alabama", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, "Suite 687", "West Stephanietown", "Singapore", new DateTime(2023, 5, 11, 18, 54, 19, 187, DateTimeKind.Utc).AddTicks(6233), "admin", new DateTime(1986, 2, 17, 19, 9, 2, 48, DateTimeKind.Local).AddTicks(9001), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "domingo_schumm@gmail.com", "Domingo", "Schumm", "67360682377", "New Jersey", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, "Suite 858", "New Zack", "Saint Helena", new DateTime(2023, 5, 11, 18, 54, 19, 187, DateTimeKind.Utc).AddTicks(7228), "admin", new DateTime(1969, 3, 10, 15, 38, 7, 830, DateTimeKind.Local).AddTicks(999), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "jacqueline.rempel@hotmail.com", "Jacqueline", "Rempel", "78519165495", "West Virginia", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, "Suite 023", "Eastonmouth", "Haiti", new DateTime(2023, 5, 11, 18, 54, 19, 187, DateTimeKind.Utc).AddTicks(8134), "admin", new DateTime(1990, 11, 7, 16, 38, 46, 783, DateTimeKind.Local).AddTicks(1790), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "erick95@yahoo.com", "Erick", "Gulgowski", "48040562786", "South Dakota", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, "Apt. 861", "Charlestown", "Uzbekistan", new DateTime(2023, 5, 11, 18, 54, 19, 187, DateTimeKind.Utc).AddTicks(9090), "admin", new DateTime(1973, 12, 12, 15, 19, 41, 100, DateTimeKind.Local).AddTicks(635), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "doyle_torphy80@gmail.com", "Doyle", "Torphy", "99740337435", "Wyoming", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, "Suite 575", "New Maeve", "Vietnam", new DateTime(2023, 5, 11, 18, 54, 19, 188, DateTimeKind.Utc).AddTicks(130), "admin", new DateTime(1977, 6, 13, 9, 14, 47, 519, DateTimeKind.Local).AddTicks(6942), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "micheal3@yahoo.com", "Micheal", "Cronin", "99882242572", "South Carolina", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, "Apt. 772", "South Daynashire", "Italy", new DateTime(2023, 5, 11, 18, 54, 19, 188, DateTimeKind.Utc).AddTicks(1173), "admin", new DateTime(1977, 2, 1, 1, 33, 46, 994, DateTimeKind.Local).AddTicks(8050), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "cody83@yahoo.com", "Cody", "Brakus", "61479260872", "Washington", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, "Apt. 964", "Labadiebury", "Bouvet Island (Bouve", new DateTime(2023, 5, 11, 18, 54, 19, 188, DateTimeKind.Utc).AddTicks(2114), "admin", new DateTime(1997, 3, 25, 23, 21, 21, 221, DateTimeKind.Local).AddTicks(994), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dianne_grant@gmail.com", "Dianne", "Grant", "40292861714", "Kentucky", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, "Suite 410", "North Cathryn", "Tonga", new DateTime(2023, 5, 11, 18, 54, 19, 188, DateTimeKind.Utc).AddTicks(3012), "admin", new DateTime(1963, 3, 14, 23, 39, 8, 381, DateTimeKind.Local).AddTicks(4939), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "kim_cartwright@hotmail.com", "Kim", "Cartwright", "86034255857", "South Carolina", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, "Suite 464", "Hilariohaven", "Montenegro", new DateTime(2023, 5, 11, 18, 54, 19, 188, DateTimeKind.Utc).AddTicks(4036), "admin", new DateTime(1971, 8, 21, 7, 46, 3, 224, DateTimeKind.Local).AddTicks(4323), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "cheryl_feest@gmail.com", "Cheryl", "Feest", "66970475245", "Kansas", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, "Suite 353", "Port Dustytown", "Norway", new DateTime(2023, 5, 11, 18, 54, 19, 188, DateTimeKind.Utc).AddTicks(4931), "admin", new DateTime(1971, 12, 29, 10, 24, 45, 917, DateTimeKind.Local).AddTicks(7567), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "jackie32@hotmail.com", "Jackie", "Casper", "55467656221", "Tennessee", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, "Suite 909", "North Nashshire", "Burundi", new DateTime(2023, 5, 11, 18, 54, 19, 188, DateTimeKind.Utc).AddTicks(5881), "admin", new DateTime(1969, 11, 6, 22, 40, 49, 214, DateTimeKind.Local).AddTicks(3518), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "cameron_becker50@hotmail.com", "Cameron", "Becker", "22292857626", "Alaska", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, "Suite 048", "Ahmedshire", "Belarus", new DateTime(2023, 5, 11, 18, 54, 19, 188, DateTimeKind.Utc).AddTicks(6779), "admin", new DateTime(1998, 1, 5, 13, 15, 6, 480, DateTimeKind.Local).AddTicks(4171), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "gerald.gorczany22@hotmail.com", "Gerald", "Gorczany", "50750236880", "Utah", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, "Apt. 087", "Gusikowskifurt", "Palau", new DateTime(2023, 5, 11, 18, 54, 19, 188, DateTimeKind.Utc).AddTicks(7758), "admin", new DateTime(1960, 5, 23, 7, 8, 8, 253, DateTimeKind.Local).AddTicks(3859), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "lyle67@hotmail.com", "Lyle", "Huel", "73062703535", "Illinois", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, "Suite 257", "Selmerfort", "Slovenia", new DateTime(2023, 5, 11, 18, 54, 19, 188, DateTimeKind.Utc).AddTicks(8683), "admin", new DateTime(1971, 4, 25, 21, 36, 50, 192, DateTimeKind.Local).AddTicks(230), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dustin.bergnaum@gmail.com", "Dustin", "Bergnaum", "87848853306", "New Mexico", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, "Apt. 645", "Lake Alysson", "Djibouti", new DateTime(2023, 5, 11, 18, 54, 19, 188, DateTimeKind.Utc).AddTicks(9683), "admin", new DateTime(1999, 7, 17, 0, 53, 39, 371, DateTimeKind.Local).AddTicks(9308), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "shannon_abbott51@hotmail.com", "Shannon", "Abbott", "66559541913", "Texas", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, "Apt. 799", "West Kariane", "Tokelau", new DateTime(2023, 5, 11, 18, 54, 19, 189, DateTimeKind.Utc).AddTicks(599), "admin", new DateTime(1964, 6, 17, 7, 14, 48, 421, DateTimeKind.Local).AddTicks(1395), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "lucia_bogisich@yahoo.com", "Lucia", "Bogisich", "47649602859", "Arkansas", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, "Apt. 553", "Morissettemouth", "French Polynesia", new DateTime(2023, 5, 11, 18, 54, 19, 189, DateTimeKind.Utc).AddTicks(1580), "admin", new DateTime(1997, 10, 11, 0, 19, 31, 443, DateTimeKind.Local).AddTicks(6758), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "carole.brown23@hotmail.com", "Carole", "Brown", "22480197110", "Colorado", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, "Suite 080", "Emardmouth", "Madagascar", new DateTime(2023, 5, 11, 18, 54, 19, 189, DateTimeKind.Utc).AddTicks(2435), "admin", new DateTime(1998, 9, 7, 4, 0, 10, 872, DateTimeKind.Local).AddTicks(3243), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "cory86@hotmail.com", "Cory", "DuBuque", "53844889875", "Texas", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, "Apt. 179", "Wisozkton", "Yemen", new DateTime(2023, 5, 11, 18, 54, 19, 189, DateTimeKind.Utc).AddTicks(3293), "admin", new DateTime(1971, 12, 17, 2, 2, 3, 163, DateTimeKind.Local).AddTicks(764), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "bennie_emard33@gmail.com", "Bennie", "Emard", "10702779484", "Virginia", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, "Apt. 139", "South Casandraberg", "Saint Kitts and Nevi", new DateTime(2023, 5, 11, 18, 54, 19, 189, DateTimeKind.Utc).AddTicks(4136), "admin", new DateTime(1995, 4, 9, 22, 45, 23, 815, DateTimeKind.Local).AddTicks(4691), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "rolando90@hotmail.com", "Rolando", "Schumm", "50344032704", "Minnesota", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, "Suite 539", "New Lawson", "Martinique", new DateTime(2023, 5, 11, 18, 54, 19, 189, DateTimeKind.Utc).AddTicks(5182), "admin", new DateTime(1992, 3, 1, 1, 55, 7, 269, DateTimeKind.Local).AddTicks(6231), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "guillermo_reynolds@yahoo.com", "Guillermo", "Reynolds", "50184297867", "West Virginia", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, "Apt. 760", "East Justinefort", "Germany", new DateTime(2023, 5, 11, 18, 54, 19, 189, DateTimeKind.Utc).AddTicks(6100), "admin", new DateTime(1983, 10, 31, 18, 56, 39, 368, DateTimeKind.Local).AddTicks(928), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "jesse_baumbach62@yahoo.com", "Jesse", "Baumbach", "00048134210", "New Hampshire", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41, "Apt. 732", "East Augusta", "Andorra", new DateTime(2023, 5, 11, 18, 54, 19, 189, DateTimeKind.Utc).AddTicks(7016), "admin", new DateTime(1957, 7, 14, 13, 1, 21, 666, DateTimeKind.Local).AddTicks(2834), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "sam35@gmail.com", "Sam", "Casper", "14557601441", "Florida", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42, "Apt. 175", "West Veda", "Montserrat", new DateTime(2023, 5, 11, 18, 54, 19, 189, DateTimeKind.Utc).AddTicks(7990), "admin", new DateTime(1980, 9, 3, 21, 5, 33, 503, DateTimeKind.Local).AddTicks(9818), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "sophie.nikolaus38@hotmail.com", "Sophie", "Nikolaus", "26303653577", "Minnesota", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Staff",
                columns: new[] { "Id", "AddressLine", "City", "Country", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "FirstName", "LastName", "Phone", "Province", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 43, "Suite 928", "West Wiley", "Russian Federation", new DateTime(2023, 5, 11, 18, 54, 19, 189, DateTimeKind.Utc).AddTicks(8943), "admin", new DateTime(1976, 8, 20, 23, 20, 15, 308, DateTimeKind.Local).AddTicks(1314), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "marco73@hotmail.com", "Marco", "Witting", "14264747436", "New Hampshire", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44, "Apt. 420", "Johnsonfurt", "Canada", new DateTime(2023, 5, 11, 18, 54, 19, 189, DateTimeKind.Utc).AddTicks(9901), "admin", new DateTime(1956, 10, 2, 10, 9, 5, 321, DateTimeKind.Local).AddTicks(7407), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "chester_boyer48@yahoo.com", "Chester", "Boyer", "73081459720", "Oregon", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45, "Suite 986", "South Robb", "Gibraltar", new DateTime(2023, 5, 11, 18, 54, 19, 190, DateTimeKind.Utc).AddTicks(790), "admin", new DateTime(2002, 7, 30, 4, 52, 15, 700, DateTimeKind.Local).AddTicks(6890), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "nellie69@hotmail.com", "Nellie", "Anderson", "93699091653", "Washington", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 46, "Apt. 064", "Lorinetown", "Solomon Islands", new DateTime(2023, 5, 11, 18, 54, 19, 190, DateTimeKind.Utc).AddTicks(1745), "admin", new DateTime(1990, 7, 15, 11, 34, 38, 701, DateTimeKind.Local).AddTicks(2294), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "philip4@hotmail.com", "Philip", "Osinski", "81846974876", "West Virginia", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 47, "Apt. 883", "East Parkerville", "Lesotho", new DateTime(2023, 5, 11, 18, 54, 19, 190, DateTimeKind.Utc).AddTicks(2624), "admin", new DateTime(1975, 4, 5, 6, 32, 11, 603, DateTimeKind.Local).AddTicks(3845), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "noah_kutch@yahoo.com", "Noah", "Kutch", "63844817055", "Montana", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48, "Suite 538", "South Pansy", "Falkland Islands (Ma", new DateTime(2023, 5, 11, 18, 54, 19, 190, DateTimeKind.Utc).AddTicks(3488), "admin", new DateTime(1984, 1, 12, 10, 4, 39, 846, DateTimeKind.Local).AddTicks(6698), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "florence.langworth@yahoo.com", "Florence", "Langworth", "67525259046", "Iowa", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49, "Suite 178", "Feestchester", "Kazakhstan", new DateTime(2023, 5, 11, 18, 54, 19, 190, DateTimeKind.Utc).AddTicks(4406), "admin", new DateTime(1995, 2, 18, 10, 41, 20, 713, DateTimeKind.Local).AddTicks(611), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "hugo.carroll83@gmail.com", "Hugo", "Carroll", "76287414986", "Washington", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 50, "Suite 099", "Martyshire", "Serbia", new DateTime(2023, 5, 11, 18, 54, 19, 190, DateTimeKind.Utc).AddTicks(5378), "admin", new DateTime(2002, 11, 22, 12, 50, 55, 942, DateTimeKind.Local).AddTicks(1321), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "moses.schneider@yahoo.com", "Moses", "Schneider", "56564087105", "Kentucky", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Email",
                schema: "dbo",
                table: "Staff",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Id",
                schema: "dbo",
                table: "Staff",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_LastName_Country",
                schema: "dbo",
                table: "Staff",
                columns: new[] { "LastName", "Country" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staff",
                schema: "dbo");
        }
    }
}
