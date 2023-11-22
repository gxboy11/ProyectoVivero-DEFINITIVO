using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UserFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdPersona",
                table: "Usuarios",
                newName: "IdColaborador");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdCliente",
                table: "Usuarios",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdColaborador",
                table: "Usuarios",
                column: "IdColaborador");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Clientes_IdCliente",
                table: "Usuarios",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Colaboradores_IdColaborador",
                table: "Usuarios",
                column: "IdColaborador",
                principalTable: "Colaboradores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Clientes_IdCliente",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Colaboradores_IdColaborador",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_IdCliente",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_IdColaborador",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "IdColaborador",
                table: "Usuarios",
                newName: "IdPersona");
        }
    }
}
