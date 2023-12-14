using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FK_Carritos_Usuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Carrito",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carrito_ParentId",
                table: "Carrito",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrito_Usuarios_ParentId",
                table: "Carrito",
                column: "ParentId",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrito_Usuarios_ParentId",
                table: "Carrito");

            migrationBuilder.DropIndex(
                name: "IX_Carrito_ParentId",
                table: "Carrito");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Carrito");
        }
    }
}
