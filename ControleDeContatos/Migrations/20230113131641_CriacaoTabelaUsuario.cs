using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeContatos.Migrations
{
    public partial class CriacaoTabelaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Perfl",
                table: "Usuarios",
                newName: "Perfil");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Perfil",
                table: "Usuarios",
                newName: "Perfl");
        }
    }
}
