using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreacionProductos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCategoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagenProducto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
