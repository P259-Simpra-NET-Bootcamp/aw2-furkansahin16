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
                    { 1, "9432 Bartoletti Turnpike", "Haleyton", "French Southern Terr", new DateTime(2023, 5, 11, 13, 11, 18, 568, DateTimeKind.Utc).AddTicks(1598), "admin", new DateTime(1973, 8, 30, 6, 3, 20, 577, DateTimeKind.Local).AddTicks(9745), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Wallace92@yahoo.com", "Wallace", "Hand", "80237159147", "Mississippi", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "52257 Schuppe Flats", "New Cassieberg", "Argentina", new DateTime(2023, 5, 11, 13, 11, 18, 568, DateTimeKind.Utc).AddTicks(4027), "admin", new DateTime(1974, 8, 1, 22, 53, 11, 807, DateTimeKind.Local).AddTicks(5573), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Greg_Carter@hotmail.com", "Greg", "Carter", "09382972750", "North Dakota", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "54272 Irving Mills", "New Davionbury", "Indonesia", new DateTime(2023, 5, 11, 13, 11, 18, 568, DateTimeKind.Utc).AddTicks(5114), "admin", new DateTime(1990, 8, 9, 3, 7, 32, 964, DateTimeKind.Local).AddTicks(6452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Olivia.Moore74@gmail.com", "Olivia", "Moore", "82876993655", "Ohio", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "24500 Annie Coves", "West Antoinette", "Norfolk Island", new DateTime(2023, 5, 11, 13, 11, 18, 568, DateTimeKind.Utc).AddTicks(6120), "admin", new DateTime(1982, 1, 6, 20, 17, 30, 338, DateTimeKind.Local).AddTicks(1608), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Charlotte87@yahoo.com", "Charlotte", "Yost", "16258603097", "West Virginia", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "0292 Tillman Roads", "New Vivianne", "Bangladesh", new DateTime(2023, 5, 11, 13, 11, 18, 568, DateTimeKind.Utc).AddTicks(7255), "admin", new DateTime(1965, 2, 25, 20, 4, 26, 314, DateTimeKind.Local).AddTicks(1205), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alexandra_Gleichner72@gmail.com", "Alexandra", "Gleichner", "72723911778", "Idaho", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "084 Glover Land", "Gutmannside", "Lithuania", new DateTime(2023, 5, 11, 13, 11, 18, 568, DateTimeKind.Utc).AddTicks(8322), "admin", new DateTime(1974, 8, 19, 5, 32, 7, 978, DateTimeKind.Local).AddTicks(9003), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Peggy_Okuneva50@gmail.com", "Peggy", "Okuneva", "50261341380", "New Hampshire", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "58462 Smitham Meadow", "Bertrammouth", "Antigua and Barbuda", new DateTime(2023, 5, 11, 13, 11, 18, 568, DateTimeKind.Utc).AddTicks(9263), "admin", new DateTime(1962, 5, 24, 13, 6, 29, 821, DateTimeKind.Local).AddTicks(6115), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jenna60@gmail.com", "Jenna", "Mayer", "94884512540", "New York", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "698 Kamren Unions", "Port Abbyview", "Spain", new DateTime(2023, 5, 11, 13, 11, 18, 569, DateTimeKind.Utc).AddTicks(221), "admin", new DateTime(1967, 11, 30, 9, 32, 46, 689, DateTimeKind.Local).AddTicks(8799), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Patricia_Hackett57@hotmail.com", "Patricia", "Hackett", "55831909051", "Rhode Island", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "9751 Josefina Court", "North Cecilshire", "Virgin Islands, U.S.", new DateTime(2023, 5, 11, 13, 11, 18, 569, DateTimeKind.Utc).AddTicks(1317), "admin", new DateTime(1984, 6, 18, 10, 0, 57, 728, DateTimeKind.Local).AddTicks(8425), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Wade2@gmail.com", "Wade", "Stehr", "38514456634", "Utah", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "34303 Katheryn Stream", "Lake Trisha", "Spain", new DateTime(2023, 5, 11, 13, 11, 18, 569, DateTimeKind.Utc).AddTicks(2387), "admin", new DateTime(1994, 10, 19, 21, 3, 59, 11, DateTimeKind.Local).AddTicks(1978), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roosevelt_Osinski82@hotmail.com", "Roosevelt", "Osinski", "91496976067", "Idaho", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, "5950 Pasquale Heights", "Lake Jennings", "United Arab Emirates", new DateTime(2023, 5, 11, 13, 11, 18, 569, DateTimeKind.Utc).AddTicks(3362), "admin", new DateTime(1986, 10, 21, 6, 54, 9, 179, DateTimeKind.Local).AddTicks(3857), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Johnny_Okuneva38@gmail.com", "Johnny", "Okuneva", "15452379403", "Maryland", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, "8307 Jones Corners", "Olafmouth", "Liberia", new DateTime(2023, 5, 11, 13, 11, 18, 569, DateTimeKind.Utc).AddTicks(4347), "admin", new DateTime(1995, 11, 6, 0, 54, 37, 177, DateTimeKind.Local).AddTicks(2812), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marguerite_Wiza@gmail.com", "Marguerite", "Wiza", "20673377885", "Arkansas", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, "322 Rosalee Lock", "East Theresashire", "El Salvador", new DateTime(2023, 5, 11, 13, 11, 18, 569, DateTimeKind.Utc).AddTicks(5304), "admin", new DateTime(1980, 12, 27, 4, 40, 49, 933, DateTimeKind.Local).AddTicks(3644), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carlton.Hirthe@gmail.com", "Carlton", "Hirthe", "49210859116", "California", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, "761 Gutmann Cape", "Danielchester", "Republic of Korea", new DateTime(2023, 5, 11, 13, 11, 18, 569, DateTimeKind.Utc).AddTicks(6328), "admin", new DateTime(1968, 1, 30, 16, 29, 14, 730, DateTimeKind.Local).AddTicks(7732), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lela_Anderson15@gmail.com", "Lela", "Anderson", "68298290896", "Connecticut", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, "636 Stoltenberg Spur", "Okunevafurt", "Paraguay", new DateTime(2023, 5, 11, 13, 11, 18, 569, DateTimeKind.Utc).AddTicks(7305), "admin", new DateTime(1976, 11, 24, 23, 19, 36, 83, DateTimeKind.Local).AddTicks(4276), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tyler_Larkin96@gmail.com", "Tyler", "Larkin", "46804185862", "Idaho", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, "569 Corwin Plains", "Douglasfurt", "Comoros", new DateTime(2023, 5, 11, 13, 11, 18, 569, DateTimeKind.Utc).AddTicks(8355), "admin", new DateTime(1972, 11, 11, 9, 19, 10, 944, DateTimeKind.Local).AddTicks(5642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cornelius.Yost54@hotmail.com", "Cornelius", "Yost", "10280065681", "Virginia", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, "60116 Littel Hills", "New Afton", "Bulgaria", new DateTime(2023, 5, 11, 13, 11, 18, 569, DateTimeKind.Utc).AddTicks(9305), "admin", new DateTime(1964, 10, 26, 5, 10, 47, 148, DateTimeKind.Local).AddTicks(8010), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jared71@gmail.com", "Jared", "Tremblay", "46048189680", "Rhode Island", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, "3643 Bogan Locks", "West Garrick", "Guinea", new DateTime(2023, 5, 11, 13, 11, 18, 570, DateTimeKind.Utc).AddTicks(243), "admin", new DateTime(1982, 5, 19, 18, 1, 24, 12, DateTimeKind.Local).AddTicks(4972), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Monica_Dibbert51@yahoo.com", "Monica", "Dibbert", "14419937119", "Massachusetts", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, "488 Ryan Knolls", "South Else", "Wallis and Futuna", new DateTime(2023, 5, 11, 13, 11, 18, 570, DateTimeKind.Utc).AddTicks(1299), "admin", new DateTime(1960, 6, 25, 11, 30, 6, 190, DateTimeKind.Local).AddTicks(9277), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ricky77@yahoo.com", "Ricky", "Mosciski", "50024870797", "Vermont", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, "0454 Bennett Avenue", "Brendonmouth", "Guam", new DateTime(2023, 5, 11, 13, 11, 18, 570, DateTimeKind.Utc).AddTicks(2404), "admin", new DateTime(1960, 2, 22, 0, 16, 55, 672, DateTimeKind.Local).AddTicks(1714), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Casey.Okuneva@hotmail.com", "Casey", "Okuneva", "17758578287", "Michigan", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, "5700 Muller Roads", "North Nameshire", "Mozambique", new DateTime(2023, 5, 11, 13, 11, 18, 570, DateTimeKind.Utc).AddTicks(3361), "admin", new DateTime(1973, 6, 1, 7, 43, 54, 775, DateTimeKind.Local).AddTicks(8286), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Timothy_Bogisich@gmail.com", "Timothy", "Bogisich", "23366717486", "Connecticut", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, "8477 Sporer Branch", "Kozeyport", "Fiji", new DateTime(2023, 5, 11, 13, 11, 18, 570, DateTimeKind.Utc).AddTicks(4363), "admin", new DateTime(1965, 5, 23, 7, 20, 45, 212, DateTimeKind.Local).AddTicks(6140), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Merle_Stehr10@yahoo.com", "Merle", "Stehr", "68052897220", "Louisiana", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, "88410 Mann Manor", "South Lisahaven", "Mali", new DateTime(2023, 5, 11, 13, 11, 18, 570, DateTimeKind.Utc).AddTicks(5417), "admin", new DateTime(1993, 7, 5, 20, 14, 22, 870, DateTimeKind.Local).AddTicks(2011), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Victor.Miller91@gmail.com", "Victor", "Miller", "45164357514", "Wisconsin", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, "39193 Jasper Alley", "Sofiafort", "Venezuela", new DateTime(2023, 5, 11, 13, 11, 18, 570, DateTimeKind.Utc).AddTicks(6409), "admin", new DateTime(2002, 9, 30, 12, 2, 30, 602, DateTimeKind.Local).AddTicks(7908), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Courtney_Fahey@hotmail.com", "Courtney", "Fahey", "64549537617", "Iowa", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, "8794 Ken Rue", "Lake Walker", "San Marino", new DateTime(2023, 5, 11, 13, 11, 18, 570, DateTimeKind.Utc).AddTicks(7339), "admin", new DateTime(1974, 4, 4, 11, 8, 56, 813, DateTimeKind.Local).AddTicks(7540), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hector22@yahoo.com", "Hector", "Kutch", "65618952499", "Delaware", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, "34000 Tod Port", "Clydeport", "Bouvet Island (Bouve", new DateTime(2023, 5, 11, 13, 11, 18, 570, DateTimeKind.Utc).AddTicks(8405), "admin", new DateTime(1998, 7, 31, 22, 49, 40, 605, DateTimeKind.Local).AddTicks(2778), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Patti_Gorczany2@yahoo.com", "Patti", "Gorczany", "44185912803", "New Hampshire", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, "615 Antone Cliffs", "Arahaven", "Philippines", new DateTime(2023, 5, 11, 13, 11, 18, 570, DateTimeKind.Utc).AddTicks(9382), "admin", new DateTime(1964, 9, 2, 14, 49, 26, 784, DateTimeKind.Local).AddTicks(7546), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jack_Stamm@yahoo.com", "Jack", "Stamm", "94334149629", "Colorado", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, "0267 Bogan Hill", "Gottliebtown", "Benin", new DateTime(2023, 5, 11, 13, 11, 18, 571, DateTimeKind.Utc).AddTicks(336), "admin", new DateTime(1974, 4, 22, 0, 11, 7, 414, DateTimeKind.Local).AddTicks(380), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Omar_Kovacek75@yahoo.com", "Omar", "Kovacek", "32955742022", "Louisiana", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, "51770 Lebsack Tunnel", "South Kellichester", "Rwanda", new DateTime(2023, 5, 11, 13, 11, 18, 571, DateTimeKind.Utc).AddTicks(1257), "admin", new DateTime(1957, 6, 23, 18, 0, 26, 758, DateTimeKind.Local).AddTicks(574), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rosemarie21@yahoo.com", "Rosemarie", "Boehm", "23220637979", "Ohio", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, "3510 Lavada Parkway", "Carleyland", "Latvia", new DateTime(2023, 5, 11, 13, 11, 18, 571, DateTimeKind.Utc).AddTicks(2425), "admin", new DateTime(1982, 2, 3, 6, 45, 9, 960, DateTimeKind.Local).AddTicks(5189), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Muriel_Klocko@hotmail.com", "Muriel", "Klocko", "09131372062", "North Dakota", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, "186 Crist Shore", "New Eduardo", "United Kingdom", new DateTime(2023, 5, 11, 13, 11, 18, 571, DateTimeKind.Utc).AddTicks(4300), "admin", new DateTime(1991, 4, 1, 23, 52, 44, 565, DateTimeKind.Local).AddTicks(7759), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "May.Beatty@yahoo.com", "May", "Beatty", "66369985756", "Vermont", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, "55030 Omer Meadow", "South Rettabury", "United Arab Emirates", new DateTime(2023, 5, 11, 13, 11, 18, 571, DateTimeKind.Utc).AddTicks(7255), "admin", new DateTime(1975, 11, 21, 2, 10, 31, 781, DateTimeKind.Local).AddTicks(6286), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Heidi.Moore@gmail.com", "Heidi", "Moore", "92167107742", "New Hampshire", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, "89876 Camila Trace", "Lake Leonard", "Uruguay", new DateTime(2023, 5, 11, 13, 11, 18, 571, DateTimeKind.Utc).AddTicks(8724), "admin", new DateTime(1988, 3, 14, 8, 29, 11, 795, DateTimeKind.Local).AddTicks(4860), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "June_Jacobson62@yahoo.com", "June", "Jacobson", "80974393988", "Texas", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, "0022 Milan Walk", "Lake Caleb", "Trinidad and Tobago", new DateTime(2023, 5, 11, 13, 11, 18, 572, DateTimeKind.Utc).AddTicks(41), "admin", new DateTime(1961, 4, 12, 1, 23, 13, 325, DateTimeKind.Local).AddTicks(4776), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brent_Turner@gmail.com", "Brent", "Turner", "64412220714", "North Carolina", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, "1626 Oral Fork", "Port Kaylahmouth", "Zimbabwe", new DateTime(2023, 5, 11, 13, 11, 18, 572, DateTimeKind.Utc).AddTicks(1044), "admin", new DateTime(1953, 5, 30, 5, 44, 52, 730, DateTimeKind.Local).AddTicks(7965), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Abel_Mohr@gmail.com", "Abel", "Mohr", "82825327807", "West Virginia", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, "074 Rutherford Stravenue", "Eliseport", "Nicaragua", new DateTime(2023, 5, 11, 13, 11, 18, 572, DateTimeKind.Utc).AddTicks(2025), "admin", new DateTime(1961, 8, 15, 22, 33, 27, 994, DateTimeKind.Local).AddTicks(2449), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Antonia.Kris@yahoo.com", "Antonia", "Kris", "50767393873", "North Dakota", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, "8325 Schmidt Trail", "New Annabellemouth", "Albania", new DateTime(2023, 5, 11, 13, 11, 18, 572, DateTimeKind.Utc).AddTicks(3004), "admin", new DateTime(2001, 10, 27, 13, 32, 20, 387, DateTimeKind.Local).AddTicks(8559), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lora.Haag@yahoo.com", "Lora", "Haag", "77019889112", "Arizona", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, "8300 Ray Island", "South Selena", "Saint Barthelemy", new DateTime(2023, 5, 11, 13, 11, 18, 572, DateTimeKind.Utc).AddTicks(4017), "admin", new DateTime(1987, 11, 13, 7, 1, 13, 777, DateTimeKind.Local).AddTicks(7511), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Violet44@hotmail.com", "Violet", "Gleason", "11333755473", "Ohio", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, "0002 Nader Courts", "North Desmondberg", "Netherlands", new DateTime(2023, 5, 11, 13, 11, 18, 572, DateTimeKind.Utc).AddTicks(4962), "admin", new DateTime(1956, 11, 27, 6, 31, 20, 782, DateTimeKind.Local).AddTicks(112), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Denise54@yahoo.com", "Denise", "Reichert", "00860581757", "Alabama", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, "6585 Hosea Lakes", "Alvenaton", "Kenya", new DateTime(2023, 5, 11, 13, 11, 18, 572, DateTimeKind.Utc).AddTicks(6034), "admin", new DateTime(1960, 8, 22, 1, 14, 5, 972, DateTimeKind.Local).AddTicks(6493), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Todd_Hyatt38@yahoo.com", "Todd", "Hyatt", "39945195666", "Montana", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41, "0510 Cedrick Circles", "West Esteban", "Ghana", new DateTime(2023, 5, 11, 13, 11, 18, 572, DateTimeKind.Utc).AddTicks(7106), "admin", new DateTime(1960, 12, 1, 11, 40, 11, 173, DateTimeKind.Local).AddTicks(7473), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stanley_Haag69@gmail.com", "Stanley", "Haag", "22292275202", "Maine", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42, "2441 Mertz Glens", "Gleasonchester", "Reunion", new DateTime(2023, 5, 11, 13, 11, 18, 572, DateTimeKind.Utc).AddTicks(8027), "admin", new DateTime(1975, 4, 27, 15, 43, 36, 356, DateTimeKind.Local).AddTicks(9960), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jackie_Jast@yahoo.com", "Jackie", "Jast", "88320955701", "Illinois", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Staff",
                columns: new[] { "Id", "AddressLine", "City", "Country", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "FirstName", "LastName", "Phone", "Province", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 43, "886 Heber Branch", "West Eden", "Mali", new DateTime(2023, 5, 11, 13, 11, 18, 572, DateTimeKind.Utc).AddTicks(8964), "admin", new DateTime(1984, 3, 5, 11, 20, 3, 462, DateTimeKind.Local).AddTicks(664), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cassandra_Fay@hotmail.com", "Cassandra", "Fay", "37580793782", "South Carolina", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44, "804 Nathaniel Port", "Stephenbury", "Cuba", new DateTime(2023, 5, 11, 13, 11, 18, 572, DateTimeKind.Utc).AddTicks(9974), "admin", new DateTime(1963, 7, 7, 15, 31, 11, 223, DateTimeKind.Local).AddTicks(8090), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maxine94@gmail.com", "Maxine", "Trantow", "04937879270", "New York", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45, "1018 Schumm Brook", "Jaquelinmouth", "Serbia", new DateTime(2023, 5, 11, 13, 11, 18, 573, DateTimeKind.Utc).AddTicks(1009), "admin", new DateTime(1956, 12, 7, 17, 15, 53, 538, DateTimeKind.Local).AddTicks(1641), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paul39@gmail.com", "Paul", "Dibbert", "04439540595", "Massachusetts", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 46, "769 Zboncak Ridges", "North Salvador", "United Arab Emirates", new DateTime(2023, 5, 11, 13, 11, 18, 573, DateTimeKind.Utc).AddTicks(2016), "admin", new DateTime(1968, 3, 25, 2, 38, 38, 587, DateTimeKind.Local).AddTicks(3665), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vivian_Hills12@gmail.com", "Vivian", "Hills", "76593850235", "Alabama", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 47, "864 Audreanne Parkway", "Parisland", "Burundi", new DateTime(2023, 5, 11, 13, 11, 18, 573, DateTimeKind.Utc).AddTicks(3014), "admin", new DateTime(1955, 6, 5, 3, 34, 40, 585, DateTimeKind.Local).AddTicks(6587), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ginger.Gottlieb@hotmail.com", "Ginger", "Gottlieb", "12146180560", "Idaho", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48, "4559 Reina Extensions", "West Corene", "Iraq", new DateTime(2023, 5, 11, 13, 11, 18, 573, DateTimeKind.Utc).AddTicks(3959), "admin", new DateTime(1953, 11, 22, 13, 13, 20, 367, DateTimeKind.Local).AddTicks(215), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stanley_Gaylord@hotmail.com", "Stanley", "Gaylord", "09935440484", "Arkansas", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49, "0998 Gilbert Islands", "Kesslerchester", "Canada", new DateTime(2023, 5, 11, 13, 11, 18, 573, DateTimeKind.Utc).AddTicks(5032), "admin", new DateTime(1996, 1, 24, 3, 21, 56, 600, DateTimeKind.Local).AddTicks(9038), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Clinton.Leannon80@hotmail.com", "Clinton", "Leannon", "51847379146", "Idaho", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 50, "437 Rubie Greens", "Kaitlynborough", "Cote d'Ivoire", new DateTime(2023, 5, 11, 13, 11, 18, 573, DateTimeKind.Utc).AddTicks(5992), "admin", new DateTime(1972, 5, 16, 18, 54, 58, 421, DateTimeKind.Local).AddTicks(3398), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kristi_Fisher44@gmail.com", "Kristi", "Fisher", "34858194076", "Georgia", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
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
