using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
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
                    { new Guid("05e98d6c-d11b-4fec-9dd5-06c8663a2643"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2024, 11, 27, 17, 4, 10, 277, DateTimeKind.Utc).AddTicks(4940), "Incredible Soft Towels" },
                    { new Guid("2b1ed9e7-4f5f-440f-b59c-563fb054d2e5"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 11, 27, 17, 4, 10, 277, DateTimeKind.Utc).AddTicks(4791), "Incredible Cotton Chair" },
                    { new Guid("47fb144d-9ec7-4afe-95d3-e51c52e2eaf7"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 11, 27, 17, 4, 10, 277, DateTimeKind.Utc).AddTicks(5046), "Unbranded Steel Chair" },
                    { new Guid("4facf808-867e-471b-811b-2b6467c78a16"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 11, 27, 17, 4, 10, 277, DateTimeKind.Utc).AddTicks(4904), "Awesome Cotton Bike" },
                    { new Guid("893111be-89eb-4fbb-9a4a-a1603dca9d6a"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 11, 27, 17, 4, 10, 277, DateTimeKind.Utc).AddTicks(5016), "Intelligent Frozen Soap" },
                    { new Guid("94954648-b211-47db-8554-88e91f8811a6"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 11, 27, 17, 4, 10, 277, DateTimeKind.Utc).AddTicks(4843), "Generic Concrete Chips" },
                    { new Guid("9f7b9235-c73c-4bd0-91ab-86b84413aaff"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 11, 27, 17, 4, 10, 277, DateTimeKind.Utc).AddTicks(5126), "Rustic Plastic Chicken" },
                    { new Guid("ebf0570a-b352-49b6-a011-2a375c90139c"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 11, 27, 17, 4, 10, 277, DateTimeKind.Utc).AddTicks(5077), "Unbranded Granite Fish" },
                    { new Guid("fd300c79-3721-4f74-a7d8-cbf3f1940fad"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 11, 27, 17, 4, 10, 277, DateTimeKind.Utc).AddTicks(4974), "Small Rubber Pants" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("09036d66-39b2-4fa6-9da0-20c5b7ba9ccb"), "Muller", "Global Program Architect", "Kenya" },
                    { new Guid("178879a6-3062-4a04-814b-3d3e2e07dd24"), "Waelchi", "Corporate Paradigm Specialist", "Amie" },
                    { new Guid("2404e5f9-508f-4a9a-97cf-ce744ed2f7c0"), "Rice", "Chief Infrastructure Director", "Ron" },
                    { new Guid("2537ec57-c7b2-43c7-9914-1b940397f86e"), "Brown", "International Implementation Liaison", "Maurice" },
                    { new Guid("2b76e08c-8983-469e-8014-5cbacbe90f87"), "Waters", "Forward Markets Designer", "Jaylan" },
                    { new Guid("42a3e746-2e98-41c6-94d1-b53ee86f07ac"), "Kirlin", "Investor Quality Producer", "Linwood" },
                    { new Guid("57e189a8-3505-4da0-a0ae-6e32395ec0b7"), "King", "Legacy Interactions Planner", "Freida" },
                    { new Guid("5af9deb1-5914-471e-8f74-52c914ba76bb"), "Kirlin", "Regional Brand Agent", "Albin" },
                    { new Guid("a7e8e2f5-ce7d-4686-bd52-a22127bb95aa"), "Williamson", "Legacy Functionality Representative", "Danial" },
                    { new Guid("e45507f6-daef-41b0-90e8-94d0f745e56c"), "Crist", "Internal Interactions Analyst", "Kara" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("e6ddc217-67c0-488f-905f-7cdf87c3e6b8"), "Precio Regular", 10.0m, 8.0m });

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
