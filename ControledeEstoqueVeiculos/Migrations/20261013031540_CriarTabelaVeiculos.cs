using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControledeEstoqueVeiculos.Migrations
{
    /// <inheritdoc />
    public partial class CriarTabelaVeiculos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VEICULOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Marca = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Modelo = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Ano = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Cor = table.Column<string>(type: "NVARCHAR2(25)", maxLength: 25, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tipo = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Situacao = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    IsAtivo = table.Column<bool>(type: "BOOLEAN", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEICULOS", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VEICULOS");
        }
    }
}
