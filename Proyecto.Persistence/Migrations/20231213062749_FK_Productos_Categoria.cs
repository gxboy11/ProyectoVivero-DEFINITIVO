using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FK_Productos_Categoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdCategoria",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdCategoria",
                table: "Productos",
                column: "IdCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_IdCategoria",
                table: "Productos",
                column: "IdCategoria",
                principalTable: "Categorias",
                principalColumn: "IdCategoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_IdCategoria",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_IdCategoria",
                table: "Productos");

            migrationBuilder.AlterColumn<string>(
                name: "IdCategoria",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
