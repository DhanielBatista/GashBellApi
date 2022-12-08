using Microsoft.EntityFrameworkCore.Migrations;

namespace GashBellApi.Migrations
{
    public partial class addAlignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_demons_humans_PartnerId",
                table: "demons");

            migrationBuilder.DropForeignKey(
                name: "FK_spells_demons_DemonId",
                table: "spells");

            migrationBuilder.DropForeignKey(
                name: "FK_types_spells_SpellId",
                table: "types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_types",
                table: "types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_spells",
                table: "spells");

            migrationBuilder.DropPrimaryKey(
                name: "PK_humans",
                table: "humans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_demons",
                table: "demons");

            migrationBuilder.RenameTable(
                name: "types",
                newName: "Types");

            migrationBuilder.RenameTable(
                name: "spells",
                newName: "Spells");

            migrationBuilder.RenameTable(
                name: "humans",
                newName: "Humans");

            migrationBuilder.RenameTable(
                name: "demons",
                newName: "Demons");

            migrationBuilder.RenameIndex(
                name: "IX_types_SpellId",
                table: "Types",
                newName: "IX_Types_SpellId");

            migrationBuilder.RenameIndex(
                name: "IX_spells_DemonId",
                table: "Spells",
                newName: "IX_Spells_DemonId");

            migrationBuilder.RenameIndex(
                name: "IX_demons_PartnerId",
                table: "Demons",
                newName: "IX_Demons_PartnerId");

            migrationBuilder.AlterColumn<int>(
                name: "PartnerId",
                table: "Demons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Types",
                table: "Types",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Spells",
                table: "Spells",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Humans",
                table: "Humans",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Demons",
                table: "Demons",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Alignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AligmentImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AligmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alignments", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Demons_Humans_PartnerId",
                table: "Demons",
                column: "PartnerId",
                principalTable: "Humans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_Demons_DemonId",
                table: "Spells",
                column: "DemonId",
                principalTable: "Demons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Types_Spells_SpellId",
                table: "Types",
                column: "SpellId",
                principalTable: "Spells",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demons_Humans_PartnerId",
                table: "Demons");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Demons_DemonId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_Types_Spells_SpellId",
                table: "Types");

            migrationBuilder.DropTable(
                name: "Alignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Types",
                table: "Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Spells",
                table: "Spells");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Humans",
                table: "Humans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Demons",
                table: "Demons");

            migrationBuilder.RenameTable(
                name: "Types",
                newName: "types");

            migrationBuilder.RenameTable(
                name: "Spells",
                newName: "spells");

            migrationBuilder.RenameTable(
                name: "Humans",
                newName: "humans");

            migrationBuilder.RenameTable(
                name: "Demons",
                newName: "demons");

            migrationBuilder.RenameIndex(
                name: "IX_Types_SpellId",
                table: "types",
                newName: "IX_types_SpellId");

            migrationBuilder.RenameIndex(
                name: "IX_Spells_DemonId",
                table: "spells",
                newName: "IX_spells_DemonId");

            migrationBuilder.RenameIndex(
                name: "IX_Demons_PartnerId",
                table: "demons",
                newName: "IX_demons_PartnerId");

            migrationBuilder.AlterColumn<int>(
                name: "PartnerId",
                table: "demons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_types",
                table: "types",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_spells",
                table: "spells",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_humans",
                table: "humans",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_demons",
                table: "demons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_demons_humans_PartnerId",
                table: "demons",
                column: "PartnerId",
                principalTable: "humans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_spells_demons_DemonId",
                table: "spells",
                column: "DemonId",
                principalTable: "demons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_types_spells_SpellId",
                table: "types",
                column: "SpellId",
                principalTable: "spells",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
