using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddJobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO Jobs (Name,Duration) VALUES ('Job1',1)");
            migrationBuilder.Sql($"INSERT INTO Jobs (Name,Duration) VALUES ('Job2',2)");
            migrationBuilder.Sql($"INSERT INTO Jobs (Name,Duration) VALUES ('Job3',3)");
            migrationBuilder.Sql($"INSERT INTO Jobs (Name,Duration) VALUES ('Job4',4)");
            migrationBuilder.Sql($"INSERT INTO Jobs (Name,Duration) VALUES ('Job5',5)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
