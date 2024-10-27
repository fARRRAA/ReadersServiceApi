using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReadersServiceApi.Migrations
{
    /// <inheritdoc />
    public partial class dadad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Profile_Photo",
                table: "Readers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profile_Photo",
                table: "Readers");
        }
    }
}
