using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FindVehicleApp.Data.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Ford')");
          migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Honda')");
          migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Toyota')");

          migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Escort', (SELECT ID FROM Makes WHERE Name = 'Ford'))");
          migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Explorer', (SELECT ID FROM Makes WHERE Name = 'Ford'))");
          migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('F150', (SELECT ID FROM Makes WHERE Name = 'Ford'))");

          migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Accord', (SELECT ID FROM Makes WHERE Name = 'Honda'))");
          migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Civic', (SELECT ID FROM Makes WHERE Name = 'Honda'))");
          migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Odyssey', (SELECT ID FROM Makes WHERE Name = 'Honda'))");

          migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Camry', (SELECT ID FROM Makes WHERE Name = 'Toyota'))");
          migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Corolla', (SELECT ID FROM Makes WHERE Name = 'Toyota'))");
          migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Yaris', (SELECT ID FROM Makes WHERE Name = 'Toyota'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN ('Ford','Honda','Toyota')");
        }
    }
}
