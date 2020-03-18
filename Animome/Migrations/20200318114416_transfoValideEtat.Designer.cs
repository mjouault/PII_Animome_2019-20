﻿// <auto-generated />
using System;
using Animome.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Animome.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200318114416_transfoValideEtat")]
    partial class transfoValideEtat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Animome.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ApplicationRoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("ApplicationRoleId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Animome.Models.Commentaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SuiviApplicationUserId")
                        .HasColumnType("int");

                    b.Property<string>("Texte")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SuiviApplicationUserId");

                    b.ToTable("Commentaire");
                });

            modelBuilder.Entity("Animome.Models.Competence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Intitule")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Competence");
                });

            modelBuilder.Entity("Animome.Models.CompetencePrerequis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompetenceId")
                        .HasColumnType("int");

                    b.Property<int?>("PrerequisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompetenceId");

                    b.HasIndex("PrerequisId");

                    b.ToTable("CompetencePrerequis");
                });

            modelBuilder.Entity("Animome.Models.Domaine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Intitule")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Domaine");
                });

            modelBuilder.Entity("Animome.Models.DomaineCompetence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompetenceId")
                        .HasColumnType("int");

                    b.Property<int?>("DomaineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompetenceId");

                    b.HasIndex("DomaineId");

                    b.ToTable("DomaineCompetence");
                });

            modelBuilder.Entity("Animome.Models.Niveau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Intitule")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Niveau");
                });

            modelBuilder.Entity("Animome.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("Animome.Models.Prerequis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Intitule")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Prerequis");
                });

            modelBuilder.Entity("Animome.Models.PrerequisNiveau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NiveauId")
                        .HasColumnType("int");

                    b.Property<int?>("PrerequisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NiveauId");

                    b.HasIndex("PrerequisId");

                    b.ToTable("PrerequisNiveau");
                });

            modelBuilder.Entity("Animome.Models.Suivi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateValide")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DomaineId")
                        .HasColumnType("int");

                    b.Property<int>("Etat")
                        .HasColumnType("int");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DomaineId");

                    b.HasIndex("PatientId");

                    b.ToTable("Suivi");
                });

            modelBuilder.Entity("Animome.Models.SuiviApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("SuiviId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("SuiviId");

                    b.ToTable("SuiviApplicationUser");
                });

            modelBuilder.Entity("Animome.Models.SuiviCompetence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompetenceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateValide")
                        .HasColumnType("datetime2");

                    b.Property<int>("Etat")
                        .HasColumnType("int");

                    b.Property<int?>("SuiviId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompetenceId");

                    b.HasIndex("SuiviId");

                    b.ToTable("SuiviCompetence");
                });

            modelBuilder.Entity("Animome.Models.SuiviExercice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateFait")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateValide")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SuiviNiveauId")
                        .HasColumnType("int");

                    b.Property<bool>("Valide")
                        .HasColumnType("bit");

                    b.Property<string>("ValideurId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SuiviNiveauId");

                    b.HasIndex("ValideurId");

                    b.ToTable("SuiviExercice");
                });

            modelBuilder.Entity("Animome.Models.SuiviNiveau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateValide")
                        .HasColumnType("datetime2");

                    b.Property<int>("Etat")
                        .HasColumnType("int");

                    b.Property<int?>("NiveauId")
                        .HasColumnType("int");

                    b.Property<int?>("SuiviPrerequisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NiveauId");

                    b.HasIndex("SuiviPrerequisId");

                    b.ToTable("SuiviNiveau");
                });

            modelBuilder.Entity("Animome.Models.SuiviPrerequis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateValide")
                        .HasColumnType("datetime2");

                    b.Property<int>("Etat")
                        .HasColumnType("int");

                    b.Property<int?>("PrerequisId")
                        .HasColumnType("int");

                    b.Property<int?>("SuiviCompetenceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrerequisId");

                    b.HasIndex("SuiviCompetenceId");

                    b.ToTable("SuiviPrerequis");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Animome.Models.ApplicationRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.HasDiscriminator().HasValue("ApplicationRole");
                });

            modelBuilder.Entity("Animome.Models.ApplicationUser", b =>
                {
                    b.HasOne("Animome.Models.ApplicationRole", "ApplicationRole")
                        .WithMany()
                        .HasForeignKey("ApplicationRoleId");
                });

            modelBuilder.Entity("Animome.Models.Commentaire", b =>
                {
                    b.HasOne("Animome.Models.SuiviApplicationUser", "SuiviApplicationUser")
                        .WithMany()
                        .HasForeignKey("SuiviApplicationUserId");
                });

            modelBuilder.Entity("Animome.Models.CompetencePrerequis", b =>
                {
                    b.HasOne("Animome.Models.Competence", "Competence")
                        .WithMany()
                        .HasForeignKey("CompetenceId");

                    b.HasOne("Animome.Models.Prerequis", "Prerequis")
                        .WithMany("LesCompetencePrerequis")
                        .HasForeignKey("PrerequisId");
                });

            modelBuilder.Entity("Animome.Models.DomaineCompetence", b =>
                {
                    b.HasOne("Animome.Models.Competence", "Competence")
                        .WithMany("LesDomaineCompetences")
                        .HasForeignKey("CompetenceId");

                    b.HasOne("Animome.Models.Domaine", "Domaine")
                        .WithMany()
                        .HasForeignKey("DomaineId");
                });

            modelBuilder.Entity("Animome.Models.PrerequisNiveau", b =>
                {
                    b.HasOne("Animome.Models.Niveau", "Niveau")
                        .WithMany("LesPrerequisNiveaux")
                        .HasForeignKey("NiveauId");

                    b.HasOne("Animome.Models.Prerequis", "Prerequis")
                        .WithMany()
                        .HasForeignKey("PrerequisId");
                });

            modelBuilder.Entity("Animome.Models.Suivi", b =>
                {
                    b.HasOne("Animome.Models.Domaine", "Domaine")
                        .WithMany("LesSuivis")
                        .HasForeignKey("DomaineId");

                    b.HasOne("Animome.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("Animome.Models.SuiviApplicationUser", b =>
                {
                    b.HasOne("Animome.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("LesSuiviApplicationUsers")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Animome.Models.Suivi", "Suivi")
                        .WithMany("LesSuiviApplicationUsers")
                        .HasForeignKey("SuiviId");
                });

            modelBuilder.Entity("Animome.Models.SuiviCompetence", b =>
                {
                    b.HasOne("Animome.Models.Competence", "Competence")
                        .WithMany("LesSuiviCompetences")
                        .HasForeignKey("CompetenceId");

                    b.HasOne("Animome.Models.Suivi", "Suivi")
                        .WithMany("LesSuiviCompetences")
                        .HasForeignKey("SuiviId");
                });

            modelBuilder.Entity("Animome.Models.SuiviExercice", b =>
                {
                    b.HasOne("Animome.Models.SuiviNiveau", "SuiviNiveau")
                        .WithMany("LesSuiviExercices")
                        .HasForeignKey("SuiviNiveauId");

                    b.HasOne("Animome.Models.ApplicationUser", "Valideur")
                        .WithMany("LesSuiviExercices")
                        .HasForeignKey("ValideurId");
                });

            modelBuilder.Entity("Animome.Models.SuiviNiveau", b =>
                {
                    b.HasOne("Animome.Models.Niveau", "Niveau")
                        .WithMany("LesSuiviNiveaux")
                        .HasForeignKey("NiveauId");

                    b.HasOne("Animome.Models.SuiviPrerequis", "SuiviPrerequis")
                        .WithMany("LesSuiviNiveaux")
                        .HasForeignKey("SuiviPrerequisId");
                });

            modelBuilder.Entity("Animome.Models.SuiviPrerequis", b =>
                {
                    b.HasOne("Animome.Models.Prerequis", "Prerequis")
                        .WithMany("LesSuiviPrerequis")
                        .HasForeignKey("PrerequisId");

                    b.HasOne("Animome.Models.SuiviCompetence", "SuiviCompetence")
                        .WithMany("LesSuiviPrerequis")
                        .HasForeignKey("SuiviCompetenceId");
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
                    b.HasOne("Animome.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Animome.Models.ApplicationUser", null)
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

                    b.HasOne("Animome.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Animome.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
