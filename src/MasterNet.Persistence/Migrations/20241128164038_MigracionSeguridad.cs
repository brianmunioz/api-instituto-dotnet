using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterNet.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigracionSeguridad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("1ddc2737-4639-4919-af32-925042759147"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("4d46a85d-daa0-4b96-ab83-e12ee9387978"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("50d9b3fe-8472-4960-b15c-aa54e3f6ebe3"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("52712dfa-d399-4fcf-a21b-00cd9e2c80dd"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("93b6c5ac-de2e-4590-a6a3-962c85184bac"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("c40d304e-74eb-446f-9955-b64732b3f279"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("ceba950d-ae05-4c3f-9708-3636c3119b13"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("d4df2955-3374-4c5d-bb3c-a9a0db72df98"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("ef1ffaa8-bf70-40ca-a42e-eacae96bad84"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("004a10b9-d65d-457f-965c-3242e26a7541"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("01bb879f-418b-4487-8aab-db310de339fa"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("02a7fee8-dd7d-4886-b4e5-d34715dd606d"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("204b0c6c-35f4-437f-b6d7-cb60bc19efe9"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("2b7ba4d7-6e70-437e-9448-beb24c0cf26f"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("51913e73-fad8-454f-9a67-2682337cd9bf"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("731f4f91-04cf-45cc-986b-c1e00b9f8704"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("b658b37b-899c-4b6c-b82b-bb4bc5f7115a"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("c15edab1-e03d-4bed-9173-a0bfee362e5e"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("fc918021-cba4-47bc-b5e7-fc62bdbfa784"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("2a88d250-5990-4c0b-af30-93ce0d9ab96a"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    NombreCompleto = table.Column<string>(type: "TEXT", nullable: true),
                    Carrera = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40532fc6-8134-41fc-a191-8887c4050eae", null, "ADMIN", "ADMIN" },
                    { "f479adab-b9f6-40c4-a818-f86b7a03da18", null, "CLIENT", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("2311f8d8-26c6-453e-838f-0895b5ee9beb"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 11, 28, 16, 40, 36, 749, DateTimeKind.Utc).AddTicks(4727), "Handmade Steel Bike" },
                    { new Guid("39bdccb0-cfbc-4327-84de-b880da931069"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 11, 28, 16, 40, 36, 749, DateTimeKind.Utc).AddTicks(4492), "Intelligent Metal Soap" },
                    { new Guid("4ebc1ffb-87a2-4427-a99c-9f1bc66b6902"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 11, 28, 16, 40, 36, 749, DateTimeKind.Utc).AddTicks(4441), "Handmade Concrete Chair" },
                    { new Guid("59924213-54e2-4c22-900c-cc2b72917fad"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 11, 28, 16, 40, 36, 749, DateTimeKind.Utc).AddTicks(4592), "Fantastic Plastic Gloves" },
                    { new Guid("616ba53c-126c-494b-ad2f-bf3d4069ed0f"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2024, 11, 28, 16, 40, 36, 749, DateTimeKind.Utc).AddTicks(4333), "Practical Granite Shirt" },
                    { new Guid("6986f99e-19d5-4dd8-b8c4-5695c96ab368"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 11, 28, 16, 40, 36, 749, DateTimeKind.Utc).AddTicks(4813), "Intelligent Metal Chicken" },
                    { new Guid("7a4aad20-941a-4726-978b-233a49b5c488"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 11, 28, 16, 40, 36, 749, DateTimeKind.Utc).AddTicks(4548), "Fantastic Fresh Sausages" },
                    { new Guid("831d8ad7-39ce-4b6d-b9bb-6691c4dcec5d"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 11, 28, 16, 40, 36, 749, DateTimeKind.Utc).AddTicks(4392), "Refined Plastic Salad" },
                    { new Guid("a7873de5-d667-4552-956f-828d48b58c64"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 11, 28, 16, 40, 36, 749, DateTimeKind.Utc).AddTicks(4199), "Ergonomic Steel Gloves" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("272b47fa-ba00-49fd-9706-c15791942da0"), "Trantow", "Future Accountability Designer", "Pearlie" },
                    { new Guid("65fb4aaf-cb87-4182-87bc-ca63627ff0f0"), "Goldner", "Corporate Paradigm Representative", "Nestor" },
                    { new Guid("894827a2-d48f-4a2e-892d-f816f33746c4"), "Aufderhar", "Senior Communications Manager", "Brett" },
                    { new Guid("b7409f40-b2cd-4ddc-9b5f-4856f6bbeda7"), "Casper", "Chief Data Designer", "Adela" },
                    { new Guid("b7d077ba-448e-49c3-8307-c7f55be4a532"), "Cronin", "Lead Creative Engineer", "Jeffery" },
                    { new Guid("ca1047a5-6272-42d5-97e1-b381c7d8a077"), "Weber", "Forward Data Analyst", "Kaylin" },
                    { new Guid("ca9e2d07-bf69-4bcf-ac2c-ea7316332b4c"), "Pouros", "Principal Markets Facilitator", "Burdette" },
                    { new Guid("cc340e5f-14c0-4a7d-a106-e785f2d4e1da"), "Leffler", "Investor Research Analyst", "Rosemarie" },
                    { new Guid("f60841c6-d8a8-4d39-9f07-a6beeb1a851c"), "Schimmel", "Customer Brand Specialist", "Scot" },
                    { new Guid("f67b54f8-cfaa-4ee4-9104-d4019c3a658f"), "Ritchie", "Future Accountability Consultant", "Anabel" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("076699db-4380-43c8-8dae-22d2562b0aba"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "POLICIES", "CURSO_READ", "40532fc6-8134-41fc-a191-8887c4050eae" },
                    { 2, "POLICIES", "CURSO_CREATE", "40532fc6-8134-41fc-a191-8887c4050eae" },
                    { 3, "POLICIES", "CURSO_UPDATE", "40532fc6-8134-41fc-a191-8887c4050eae" },
                    { 4, "POLICIES", "CURSO_DELETE", "40532fc6-8134-41fc-a191-8887c4050eae" },
                    { 5, "POLICIES", "INSTRUCTOR_READ", "40532fc6-8134-41fc-a191-8887c4050eae" },
                    { 6, "POLICIES", "INSTRUCTOR_CREATE", "40532fc6-8134-41fc-a191-8887c4050eae" },
                    { 7, "POLICIES", "INSTRUCTOR_UPDATE", "40532fc6-8134-41fc-a191-8887c4050eae" },
                    { 8, "POLICIES", "INSTRUCTOR_DELETE", "40532fc6-8134-41fc-a191-8887c4050eae" },
                    { 9, "POLICIES", "COMENTARIO_READ", "40532fc6-8134-41fc-a191-8887c4050eae" },
                    { 10, "POLICIES", "COMENTARIO_CREATE", "40532fc6-8134-41fc-a191-8887c4050eae" },
                    { 11, "POLICIES", "COMENTARIO_UPDATE", "40532fc6-8134-41fc-a191-8887c4050eae" },
                    { 12, "POLICIES", "COMENTARIO_DELETE", "40532fc6-8134-41fc-a191-8887c4050eae" },
                    { 13, "POLICIES", "COMENTARIO_READ", "f479adab-b9f6-40c4-a818-f86b7a03da18" },
                    { 14, "POLICIES", "COMENTARIO_CREATE", "f479adab-b9f6-40c4-a818-f86b7a03da18" },
                    { 15, "POLICIES", "CURSO_READ", "f479adab-b9f6-40c4-a818-f86b7a03da18" },
                    { 16, "POLICIES", "INSTRUCTOR_READ", "f479adab-b9f6-40c4-a818-f86b7a03da18" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("2311f8d8-26c6-453e-838f-0895b5ee9beb"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("39bdccb0-cfbc-4327-84de-b880da931069"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("4ebc1ffb-87a2-4427-a99c-9f1bc66b6902"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("59924213-54e2-4c22-900c-cc2b72917fad"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("616ba53c-126c-494b-ad2f-bf3d4069ed0f"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("6986f99e-19d5-4dd8-b8c4-5695c96ab368"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("7a4aad20-941a-4726-978b-233a49b5c488"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("831d8ad7-39ce-4b6d-b9bb-6691c4dcec5d"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("a7873de5-d667-4552-956f-828d48b58c64"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("272b47fa-ba00-49fd-9706-c15791942da0"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("65fb4aaf-cb87-4182-87bc-ca63627ff0f0"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("894827a2-d48f-4a2e-892d-f816f33746c4"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("b7409f40-b2cd-4ddc-9b5f-4856f6bbeda7"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("b7d077ba-448e-49c3-8307-c7f55be4a532"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("ca1047a5-6272-42d5-97e1-b381c7d8a077"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("ca9e2d07-bf69-4bcf-ac2c-ea7316332b4c"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("cc340e5f-14c0-4a7d-a106-e785f2d4e1da"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("f60841c6-d8a8-4d39-9f07-a6beeb1a851c"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("f67b54f8-cfaa-4ee4-9104-d4019c3a658f"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("076699db-4380-43c8-8dae-22d2562b0aba"));

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
        }
    }
}
