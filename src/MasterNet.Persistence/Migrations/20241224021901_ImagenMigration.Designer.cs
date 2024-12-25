﻿// <auto-generated />
using System;
using MasterNet.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MasterNet.Persistence.Migrations
{
    [DbContext(typeof(MasterNetDbContext))]
    [Migration("20241224021901_ImagenMigration")]
    partial class ImagenMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.2.24128.4");

            modelBuilder.Entity("MasterNet.Domain.Calificacion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Alumno")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comentario")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CursoId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Puntaje")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("calificaciones", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.Curso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FechaPublicacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("cursos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("936bd3aa-b6ae-481e-81f5-67f1842b34d2"),
                            Descripcion = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            FechaPublicacion = new DateTime(2024, 12, 24, 2, 18, 57, 778, DateTimeKind.Utc).AddTicks(3625),
                            Titulo = "Small Plastic Chair"
                        },
                        new
                        {
                            Id = new Guid("8f222477-7b64-41cc-8f38-77def998628e"),
                            Descripcion = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            FechaPublicacion = new DateTime(2024, 12, 24, 2, 18, 57, 778, DateTimeKind.Utc).AddTicks(4220),
                            Titulo = "Generic Granite Ball"
                        },
                        new
                        {
                            Id = new Guid("43f8bc1f-a4ff-4025-bb36-87e20b8b029b"),
                            Descripcion = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            FechaPublicacion = new DateTime(2024, 12, 24, 2, 18, 57, 778, DateTimeKind.Utc).AddTicks(4369),
                            Titulo = "Practical Cotton Fish"
                        },
                        new
                        {
                            Id = new Guid("935dfd9c-2fda-46e6-87b8-3375cb6a137e"),
                            Descripcion = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            FechaPublicacion = new DateTime(2024, 12, 24, 2, 18, 57, 778, DateTimeKind.Utc).AddTicks(4585),
                            Titulo = "Rustic Fresh Chicken"
                        },
                        new
                        {
                            Id = new Guid("c0a78f51-beea-4415-88f1-1be25c851894"),
                            Descripcion = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            FechaPublicacion = new DateTime(2024, 12, 24, 2, 18, 57, 778, DateTimeKind.Utc).AddTicks(4740),
                            Titulo = "Licensed Concrete Car"
                        },
                        new
                        {
                            Id = new Guid("f16aa6a5-67a7-45f2-b474-67420f20c893"),
                            Descripcion = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            FechaPublicacion = new DateTime(2024, 12, 24, 2, 18, 57, 778, DateTimeKind.Utc).AddTicks(4907),
                            Titulo = "Refined Steel Chair"
                        },
                        new
                        {
                            Id = new Guid("d5ddf285-ed3d-41e1-826f-e3467e81e086"),
                            Descripcion = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            FechaPublicacion = new DateTime(2024, 12, 24, 2, 18, 57, 778, DateTimeKind.Utc).AddTicks(5243),
                            Titulo = "Incredible Wooden Keyboard"
                        },
                        new
                        {
                            Id = new Guid("8ab10e9e-3a00-4485-af3b-e3bf1c739e5d"),
                            Descripcion = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            FechaPublicacion = new DateTime(2024, 12, 24, 2, 18, 57, 778, DateTimeKind.Utc).AddTicks(5629),
                            Titulo = "Licensed Steel Pizza"
                        },
                        new
                        {
                            Id = new Guid("2dbb2a7b-668f-49db-bf9b-5bdb4ab5f79f"),
                            Descripcion = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            FechaPublicacion = new DateTime(2024, 12, 24, 2, 18, 57, 778, DateTimeKind.Utc).AddTicks(7092),
                            Titulo = "Rustic Plastic Chair"
                        });
                });

            modelBuilder.Entity("MasterNet.Domain.CursoInstructor", b =>
                {
                    b.Property<Guid>("InstructorId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("TEXT");

                    b.HasKey("InstructorId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("cursos_instructores", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.CursoPrecio", b =>
                {
                    b.Property<Guid>("PrecioId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("TEXT");

                    b.HasKey("PrecioId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("cursos_precios", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.Instructor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Grado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("instructores", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a776977d-b88a-4e82-9295-7f511d22565c"),
                            Apellidos = "Hirthe",
                            Grado = "Customer Accounts Technician",
                            Nombre = "Leda"
                        },
                        new
                        {
                            Id = new Guid("5e6218bc-d697-45e6-868a-f2089b1aefd1"),
                            Apellidos = "Powlowski",
                            Grado = "Product Assurance Officer",
                            Nombre = "Rozella"
                        },
                        new
                        {
                            Id = new Guid("a7eebc62-46a4-41b3-b8e3-f3a79326f706"),
                            Apellidos = "Schimmel",
                            Grado = "Customer Metrics Technician",
                            Nombre = "Constantin"
                        },
                        new
                        {
                            Id = new Guid("915ce452-d332-40f4-8155-3f7175ec5b3a"),
                            Apellidos = "Heller",
                            Grado = "Internal Operations Designer",
                            Nombre = "Albert"
                        },
                        new
                        {
                            Id = new Guid("442dd2dc-c59e-4e57-8fff-47c5c8aaae8e"),
                            Apellidos = "Jacobs",
                            Grado = "Legacy Integration Coordinator",
                            Nombre = "Eden"
                        },
                        new
                        {
                            Id = new Guid("ac59877c-70f6-4189-a6e0-e27f4d9df19f"),
                            Apellidos = "Becker",
                            Grado = "Investor Mobility Assistant",
                            Nombre = "Letitia"
                        },
                        new
                        {
                            Id = new Guid("bf11351d-3881-45f3-8015-462d88cce688"),
                            Apellidos = "Koss",
                            Grado = "Dynamic Brand Specialist",
                            Nombre = "August"
                        },
                        new
                        {
                            Id = new Guid("37956a3c-14d5-4bad-8f1e-c56107effa02"),
                            Apellidos = "Bailey",
                            Grado = "Regional Infrastructure Producer",
                            Nombre = "Korbin"
                        },
                        new
                        {
                            Id = new Guid("d630eaa0-4fbb-4852-a3a7-89074f867c9e"),
                            Apellidos = "Windler",
                            Grado = "Internal Metrics Associate",
                            Nombre = "Grant"
                        },
                        new
                        {
                            Id = new Guid("e08808e9-1833-4375-91cd-7b2eeaddb6f9"),
                            Apellidos = "Cummerata",
                            Grado = "Senior Marketing Specialist",
                            Nombre = "Jamar"
                        });
                });

            modelBuilder.Entity("MasterNet.Domain.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("PublicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("imagenes", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.Precio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("PrecioActual")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioPromocion")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("precios", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("f787cdda-d96b-4476-a0f0-d5686952a15f"),
                            Nombre = "Precio Regular",
                            PrecioActual = 10.0m,
                            PrecioPromocion = 8.0m
                        });
                });

            modelBuilder.Entity("MasterNet.Persistence.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Carrera")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c12b130f-c668-4940-b87d-f9412ae5e8a5",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "5164430f-e0c2-4b12-94de-2785b1209c32",
                            Name = "CLIENT",
                            NormalizedName = "CLIENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_READ",
                            RoleId = "c12b130f-c668-4940-b87d-f9412ae5e8a5"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_CREATE",
                            RoleId = "c12b130f-c668-4940-b87d-f9412ae5e8a5"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_UPDATE",
                            RoleId = "c12b130f-c668-4940-b87d-f9412ae5e8a5"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_DELETE",
                            RoleId = "c12b130f-c668-4940-b87d-f9412ae5e8a5"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "c12b130f-c668-4940-b87d-f9412ae5e8a5"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_CREATE",
                            RoleId = "c12b130f-c668-4940-b87d-f9412ae5e8a5"
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_UPDATE",
                            RoleId = "c12b130f-c668-4940-b87d-f9412ae5e8a5"
                        },
                        new
                        {
                            Id = 8,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_DELETE",
                            RoleId = "c12b130f-c668-4940-b87d-f9412ae5e8a5"
                        },
                        new
                        {
                            Id = 9,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_READ",
                            RoleId = "c12b130f-c668-4940-b87d-f9412ae5e8a5"
                        },
                        new
                        {
                            Id = 10,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_CREATE",
                            RoleId = "c12b130f-c668-4940-b87d-f9412ae5e8a5"
                        },
                        new
                        {
                            Id = 11,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_UPDATE",
                            RoleId = "c12b130f-c668-4940-b87d-f9412ae5e8a5"
                        },
                        new
                        {
                            Id = 12,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_DELETE",
                            RoleId = "c12b130f-c668-4940-b87d-f9412ae5e8a5"
                        },
                        new
                        {
                            Id = 13,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_READ",
                            RoleId = "5164430f-e0c2-4b12-94de-2785b1209c32"
                        },
                        new
                        {
                            Id = 14,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_CREATE",
                            RoleId = "5164430f-e0c2-4b12-94de-2785b1209c32"
                        },
                        new
                        {
                            Id = 15,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_READ",
                            RoleId = "5164430f-e0c2-4b12-94de-2785b1209c32"
                        },
                        new
                        {
                            Id = 16,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "5164430f-e0c2-4b12-94de-2785b1209c32"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MasterNet.Domain.Calificacion", b =>
                {
                    b.HasOne("MasterNet.Domain.Curso", "Curso")
                        .WithMany("Calificaciones")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("MasterNet.Domain.CursoInstructor", b =>
                {
                    b.HasOne("MasterNet.Domain.Curso", "Curso")
                        .WithMany("CursoInstructores")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MasterNet.Domain.Instructor", "Instructor")
                        .WithMany("CursoInstructores")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("MasterNet.Domain.CursoPrecio", b =>
                {
                    b.HasOne("MasterNet.Domain.Curso", "Curso")
                        .WithMany("CursoPrecios")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MasterNet.Domain.Precio", "Precio")
                        .WithMany("CursoPrecios")
                        .HasForeignKey("PrecioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Precio");
                });

            modelBuilder.Entity("MasterNet.Domain.Photo", b =>
                {
                    b.HasOne("MasterNet.Domain.Curso", "Curso")
                        .WithMany("Photos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MasterNet.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MasterNet.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MasterNet.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MasterNet.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MasterNet.Domain.Curso", b =>
                {
                    b.Navigation("Calificaciones");

                    b.Navigation("CursoInstructores");

                    b.Navigation("CursoPrecios");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("MasterNet.Domain.Instructor", b =>
                {
                    b.Navigation("CursoInstructores");
                });

            modelBuilder.Entity("MasterNet.Domain.Precio", b =>
                {
                    b.Navigation("CursoPrecios");
                });
#pragma warning restore 612, 618
        }
    }
}