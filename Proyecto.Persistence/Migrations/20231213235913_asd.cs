using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class asd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrito_Usuarios_ParentId",
                table: "Carrito");

            migrationBuilder.DropIndex(
                name: "IX_Carrito_ParentId",
                table: "Carrito");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Carrito",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Carrito",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
