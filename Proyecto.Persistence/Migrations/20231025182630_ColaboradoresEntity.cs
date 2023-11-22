using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ColaboradoresEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Colaboradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CedulaColaborador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreColaborador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoColaborador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DireccionColaborador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalarioColaborador = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colaboradores");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Clientes",
                type: "int",
                nullable: true);
        }
    }
}
