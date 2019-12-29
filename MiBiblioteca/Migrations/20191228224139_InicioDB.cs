using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiBiblioteca.Migrations
{
    public partial class InicioDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 20, nullable: false),
                    Author = table.Column<string>(maxLength: 50, nullable: false),
                    Category = table.Column<string>(maxLength: 50, nullable: false),
                    Editorial = table.Column<string>(maxLength: 40, nullable: false),
                    Language = table.Column<string>(maxLength: 20, nullable: false),
                    Pages = table.Column<int>(maxLength: 6, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
