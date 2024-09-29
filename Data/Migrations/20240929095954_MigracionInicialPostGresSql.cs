using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace practica2.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicialPostGresSql : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_cuenta_bancaria",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titular = table.Column<string>(type: "TEXT", nullable: true),
                    TipoCuenta = table.Column<string>(type: "TEXT", nullable: true),
                    SaldoInicial = table.Column<decimal>(type: "TEXT", nullable: false),
                    Correo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_cuenta_bancaria", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_cuenta_bancaria");
        }
    }
}
