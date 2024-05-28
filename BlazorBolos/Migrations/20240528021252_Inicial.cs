using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorBolos.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ImagemUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bolos",
                columns: new[] { "Id", "Descricao", "ImagemUrl", "Nome", "Preco" },
                values: new object[,]
                {
                    { 1, "Bolo de banana", "https://macoratti.net/Imagens/bolos/bolo_banana.jpg", "Bolo de banana", 23.00m },
                    { 2, "Bolo brigadeiro", "https://macoratti.net/Imagens/bolos/bolo_brigadeiro.jpg", "Bolo Brigadeiro", 31.50m },
                    { 3, "Bolo de Chocolate", "https://macoratti.net/Imagens/bolos/bolo_chocolate.jpg", "Bolo de Chocolate", 41.00m },
                    { 4, "Bolo de laranja", "https://macoratti.net/Imagens/bolos/bolo_laranja", "Bolo de Laranja", 35.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bolos");
        }
    }
}
