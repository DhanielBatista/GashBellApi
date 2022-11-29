using Microsoft.EntityFrameworkCore.Migrations;

namespace GashBellApi.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "humans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameKana = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    HairColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EyeColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_humans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "demons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameKana = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    EyeColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attribute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartnerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_demons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_demons_humans_PartnerId",
                        column: x => x.PartnerId,
                        principalTable: "humans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "spells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JapaneseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpellStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DemonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_spells_demons_DemonId",
                        column: x => x.DemonId,
                        principalTable: "demons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpellId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_types", x => x.Id);
                    table.ForeignKey(
                        name: "FK_types_spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_demons_PartnerId",
                table: "demons",
                column: "PartnerId");

            migrationBuilder.CreateIndex(
                name: "IX_spells_DemonId",
                table: "spells",
                column: "DemonId");

            migrationBuilder.CreateIndex(
                name: "IX_types_SpellId",
                table: "types",
                column: "SpellId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "types");

            migrationBuilder.DropTable(
                name: "spells");

            migrationBuilder.DropTable(
                name: "demons");

            migrationBuilder.DropTable(
                name: "humans");
        }
    }
}
