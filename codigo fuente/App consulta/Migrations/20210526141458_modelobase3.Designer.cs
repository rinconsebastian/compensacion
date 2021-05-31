﻿// <auto-generated />
using System;
using App_consulta.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App_consulta.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210526141458_modelobase3")]
    partial class modelobase3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("App_consulta.Models.ActividadModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Actividad");
                });

            modelBuilder.Entity("App_consulta.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "97f6ff5b-6816-44fc-8e6f-bbdedd1223f9",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        });
                });

            modelBuilder.Entity("App_consulta.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("longtext");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("IDDependencia")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            Apellido = "",
                            ConcurrencyStamp = "05622443-5cfd-4389-8879-4523ac4c5aee",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            IDDependencia = 1,
                            LockoutEnabled = false,
                            Nombre = "Admin",
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECPDxHYYnrFlyL6ghv6NFqs7g9ZlRCuHRIgzChzRa5GDZpnwsj563VfwncgzZt+OTw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "NNK44MKHKTBOV6DHXJ4BT2Q3SYO3WQC2",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("App_consulta.Models.Configuracion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Entidad")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImgBackgroud")
                        .HasColumnType("longtext");

                    b.Property<string>("ImgHeader")
                        .HasColumnType("longtext");

                    b.Property<string>("Logo")
                        .HasColumnType("longtext");

                    b.Property<string>("NombrePlan")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("activo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("colorPrincipal")
                        .HasColumnType("longtext");

                    b.Property<string>("colorTextoHeader")
                        .HasColumnType("longtext");

                    b.Property<string>("colorTextoPrincipal")
                        .HasColumnType("longtext");

                    b.Property<string>("contacto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("libre")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("id");

                    b.ToTable("Configuracion");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Entidad = "Entidad",
                            Logo = "/images/SIE.png",
                            NombrePlan = "Plan",
                            activo = true,
                            colorPrincipal = "#52a3a1",
                            colorTextoHeader = "#ffffff",
                            colorTextoPrincipal = "#00000",
                            contacto = "rinconsebastian@gmail.com",
                            libre = true
                        });
                });

            modelBuilder.Entity("App_consulta.Models.LogModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Accion")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Modelo")
                        .HasColumnType("longtext");

                    b.Property<string>("Usuario")
                        .HasColumnType("longtext");

                    b.Property<string>("ValAnterior")
                        .HasColumnType("longtext");

                    b.Property<string>("ValNuevo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("App_consulta.Models.PagoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("longtext");

                    b.Property<string>("Mes")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombreusuario")
                        .HasColumnType("longtext");

                    b.Property<string>("Soporte1")
                        .HasColumnType("longtext");

                    b.Property<string>("Soporte2")
                        .HasColumnType("longtext");

                    b.Property<string>("Soporte3")
                        .HasColumnType("longtext");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPersona");

                    b.ToTable("Pago");
                });

            modelBuilder.Entity("App_consulta.Models.PersonaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Correo")
                        .HasColumnType("longtext");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("IdActividad")
                        .HasColumnType("int");

                    b.Property<int>("IdPlaya")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdActividad");

                    b.HasIndex("IdPlaya");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("App_consulta.Models.PlayaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Poligono")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Playa");
                });

            modelBuilder.Entity("App_consulta.Models.Policy", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("claim")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Policy");

                    b.HasData(
                        new
                        {
                            id = 1,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Configuracion.General",
                            nombre = "Ver Configuración general"
                        },
                        new
                        {
                            id = 2,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Configuracion.Responsable",
                            nombre = "Configuración dependencia"
                        },
                        new
                        {
                            id = 3,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Ejecucion.Editar",
                            nombre = "Editar ejecución"
                        },
                        new
                        {
                            id = 4,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Planeacion.Editar",
                            nombre = "Editar planeación"
                        },
                        new
                        {
                            id = 5,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Indicador.Editar",
                            nombre = "Editar indicadores"
                        },
                        new
                        {
                            id = 6,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Periodo.Editar",
                            nombre = "Editar periodo"
                        },
                        new
                        {
                            id = 7,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Categoria.Editar",
                            nombre = "Editar categorias"
                        },
                        new
                        {
                            id = 8,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Responsable.Editar",
                            nombre = "Editar dependencias"
                        },
                        new
                        {
                            id = 9,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Nivel.Editar",
                            nombre = "Editar niveles"
                        },
                        new
                        {
                            id = 10,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Campo.Editar",
                            nombre = "Editar campos"
                        },
                        new
                        {
                            id = 11,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Evaluacion.Editar",
                            nombre = "Editar evaluaciones"
                        },
                        new
                        {
                            id = 12,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Rol.Editar",
                            nombre = "Editar roles"
                        },
                        new
                        {
                            id = 13,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Usuario.Editar",
                            nombre = "Editar usuarios"
                        },
                        new
                        {
                            id = 14,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Configuracion.Logs",
                            nombre = "Ver registro actividad"
                        },
                        new
                        {
                            id = 15,
                            claim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Nota.Editar",
                            nombre = "Editar notas"
                        });
                });

            modelBuilder.Entity("App_consulta.Models.Responsable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Editar")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("IdJefe")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdJefe");

                    b.ToTable("Responsable");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Editar = true,
                            Nombre = "Entidad"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Configuracion.General",
                            ClaimValue = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Configuracion.Responsable",
                            ClaimValue = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Ejecucion.Editar",
                            ClaimValue = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Planeacion.Editar",
                            ClaimValue = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Indicador.Editar",
                            ClaimValue = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Periodo.Editar",
                            ClaimValue = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Categoria.Editar",
                            ClaimValue = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            Id = 8,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Responsable.Editar",
                            ClaimValue = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            Id = 9,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Nivel.Editar",
                            ClaimValue = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            Id = 10,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Campo.Editar",
                            ClaimValue = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            Id = 11,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Evaluacion.Editar",
                            ClaimValue = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            Id = 12,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Rol.Editar",
                            ClaimValue = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            Id = 13,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Usuario.Editar",
                            ClaimValue = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            Id = 14,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Configuracion.Logs",
                            ClaimValue = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            Id = 15,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/Nota.Editar",
                            ClaimValue = "1",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("App_consulta.Models.PagoModel", b =>
                {
                    b.HasOne("App_consulta.Models.PersonaModel", "Persona")
                        .WithMany()
                        .HasForeignKey("IdPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("App_consulta.Models.PersonaModel", b =>
                {
                    b.HasOne("App_consulta.Models.ActividadModel", "Actividad")
                        .WithMany()
                        .HasForeignKey("IdActividad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App_consulta.Models.PlayaModel", "Playa")
                        .WithMany()
                        .HasForeignKey("IdPlaya")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actividad");

                    b.Navigation("Playa");
                });

            modelBuilder.Entity("App_consulta.Models.Responsable", b =>
                {
                    b.HasOne("App_consulta.Models.Responsable", "ResponsableJefe")
                        .WithMany("Hijos")
                        .HasForeignKey("IdJefe");

                    b.Navigation("ResponsableJefe");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("App_consulta.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("App_consulta.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("App_consulta.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("App_consulta.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App_consulta.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("App_consulta.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("App_consulta.Models.Responsable", b =>
                {
                    b.Navigation("Hijos");
                });
#pragma warning restore 612, 618
        }
    }
}
