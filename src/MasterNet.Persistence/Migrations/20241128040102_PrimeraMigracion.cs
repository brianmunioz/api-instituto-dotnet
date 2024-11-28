using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    FechaPublicacion = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Grado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "precios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    PrecioActual = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    PrecioPromocion = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_precios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "calificaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Alumno = table.Column<string>(type: "TEXT", nullable: true),
                    Puntaje = table.Column<int>(type: "INTEGER", nullable: false),
                    Comentario = table.Column<string>(type: "TEXT", nullable: true),
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_calificaciones_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "imagenes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_imagenes_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cursos_instructores",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    InstructorId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos_instructores", x => new { x.InstructorId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_cursos_instructores_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_instructores_instructores_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cursos_precios",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PrecioId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos_precios", x => new { x.PrecioId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_cursos_precios_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_precios_precios_PrecioId",
                        column: x => x.PrecioId,
                        principalTable: "precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("1ddc2737-4639-4919-af32-925042759147"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 11, 28, 4, 1, 1, 530, DateTimeKind.Utc).AddTicks(2579), "Handmade Wooden Shirt" },
                    { new Guid("4d46a85d-daa0-4b96-ab83-e12ee9387978"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 11, 28, 4, 1, 1, 530, DateTimeKind.Utc).AddTicks(2181), "Handmade Rubber Mouse" },
                    { new Guid("50d9b3fe-8472-4960-b15c-aa54e3f6ebe3"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 11, 28, 4, 1, 1, 530, DateTimeKind.Utc).AddTicks(2418), "Tasty Cotton Towels" },
                    { new Guid("52712dfa-d399-4fcf-a21b-00cd9e2c80dd"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 11, 28, 4, 1, 1, 530, DateTimeKind.Utc).AddTicks(2312), "Handmade Plastic Shoes" },
                    { new Guid("93b6c5ac-de2e-4590-a6a3-962c85184bac"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 11, 28, 4, 1, 1, 530, DateTimeKind.Utc).AddTicks(2612), "Generic Soft Pants" },
                    { new Guid("c40d304e-74eb-446f-9955-b64732b3f279"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 11, 28, 4, 1, 1, 530, DateTimeKind.Utc).AddTicks(2453), "Awesome Metal Mouse" },
                    { new Guid("ceba950d-ae05-4c3f-9708-3636c3119b13"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 11, 28, 4, 1, 1, 530, DateTimeKind.Utc).AddTicks(2352), "Sleek Plastic Chicken" },
                    { new Guid("d4df2955-3374-4c5d-bb3c-a9a0db72df98"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 11, 28, 4, 1, 1, 530, DateTimeKind.Utc).AddTicks(2484), "Unbranded Fresh Bike" },
                    { new Guid("ef1ffaa8-bf70-40ca-a42e-eacae96bad84"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 11, 28, 4, 1, 1, 530, DateTimeKind.Utc).AddTicks(2383), "Sleek Granite Shoes" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("004a10b9-d65d-457f-965c-3242e26a7541"), "Crooks", "Forward Group Analyst", "Katarina" },
                    { new Guid("01bb879f-418b-4487-8aab-db310de339fa"), "Crist", "Principal Branding Assistant", "Yadira" },
                    { new Guid("02a7fee8-dd7d-4886-b4e5-d34715dd606d"), "Larkin", "Dynamic Program Technician", "Morgan" },
                    { new Guid("204b0c6c-35f4-437f-b6d7-cb60bc19efe9"), "Halvorson", "Regional Interactions Analyst", "Anais" },
                    { new Guid("2b7ba4d7-6e70-437e-9448-beb24c0cf26f"), "Kuhlman", "Investor Assurance Assistant", "Angelo" },
                    { new Guid("51913e73-fad8-454f-9a67-2682337cd9bf"), "Frami", "Product Creative Technician", "Cesar" },
                    { new Guid("731f4f91-04cf-45cc-986b-c1e00b9f8704"), "Feeney", "Direct Metrics Liaison", "Eliezer" },
                    { new Guid("b658b37b-899c-4b6c-b82b-bb4bc5f7115a"), "Mosciski", "Senior Mobility Manager", "Florine" },
                    { new Guid("c15edab1-e03d-4bed-9173-a0bfee362e5e"), "Schroeder", "Investor Communications Agent", "Jan" },
                    { new Guid("fc918021-cba4-47bc-b5e7-fc62bdbfa784"), "Gottlieb", "District Functionality Assistant", "Bill" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("2a88d250-5990-4c0b-af30-93ce0d9ab96a"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.CreateIndex(
                name: "IX_calificaciones_CursoId",
                table: "calificaciones",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_instructores_CursoId",
                table: "cursos_instructores",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_precios_CursoId",
                table: "cursos_precios",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_imagenes_CursoId",
                table: "imagenes",
                column: "CursoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "calificaciones");

            migrationBuilder.DropTable(
                name: "cursos_instructores");

            migrationBuilder.DropTable(
                name: "cursos_precios");

            migrationBuilder.DropTable(
                name: "imagenes");

            migrationBuilder.DropTable(
                name: "instructores");

            migrationBuilder.DropTable(
                name: "precios");

            migrationBuilder.DropTable(
                name: "cursos");
        }
    }
}
