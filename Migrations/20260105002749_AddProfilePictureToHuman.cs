using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace image_API.Migrations
{
    /// <inheritdoc />
    public partial class AddProfilePictureToHuman : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "_Humans",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "_Humans");
        }
    }
}
