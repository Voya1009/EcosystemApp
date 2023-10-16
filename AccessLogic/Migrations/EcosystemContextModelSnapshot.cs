﻿// <auto-generated />
using System;
using AccessLogic.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AccessLogic.Migrations
{
    [DbContext(typeof(EcosystemContext))]
    partial class EcosystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CountryEcosystem", b =>
                {
                    b.Property<int>("CountriesId")
                        .HasColumnType("int");

                    b.Property<int>("EcosystemsId")
                        .HasColumnType("int");

                    b.HasKey("CountriesId", "EcosystemsId");

                    b.HasIndex("EcosystemsId");

                    b.ToTable("CountryEcosystem");
                });

            modelBuilder.Entity("Domain.Entities.Conservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MaxSecurityRange")
                        .HasColumnType("int")
                        .HasColumnName("Rango de seguridad máximo");

                    b.Property<int>("MinSecurityRange")
                        .HasColumnType("int")
                        .HasColumnName("Rango de seguridad mínimo");

                    b.HasKey("Id");

                    b.ToTable("Conservations");
                });

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alpha3")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Código alfa-3");

                    b.HasKey("Id");

                    b.HasIndex("Alpha3")
                        .IsUnique();

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Domain.Entities.Ecosystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Area")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Área");

                    b.Property<int>("EcoConservationId")
                        .HasColumnType("int");

                    b.Property<string>("GeoDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ubicación");

                    b.Property<string>("ImgRoute")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Imagen");

                    b.Property<int>("Security")
                        .HasColumnType("int")
                        .HasColumnName("Seguridad");

                    b.HasKey("Id");

                    b.HasIndex("EcoConservationId");

                    b.ToTable("Ecosystems");
                });

            modelBuilder.Entity("Domain.Entities.Species", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CientificName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Cientific name");

                    b.Property<string>("ImgRoute")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Image");

                    b.Property<decimal>("LongRangeAdultMax")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Max length");

                    b.Property<decimal>("LongRangeAdultMin")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Min length");

                    b.Property<int>("Security")
                        .HasColumnType("int")
                        .HasColumnName("Seguridad");

                    b.Property<int>("SpeciesConservationId")
                        .HasColumnType("int");

                    b.Property<decimal>("WeightRangeMax")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Max weight");

                    b.Property<decimal>("WeightRangeMin")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Min weight");

                    b.HasKey("Id");

                    b.HasIndex("SpeciesConservationId");

                    b.ToTable("Species");
                });

            modelBuilder.Entity("Domain.Entities.Threat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Danger")
                        .HasColumnType("int")
                        .HasColumnName("Nivel de peligrosidad");

                    b.HasKey("Id");

                    b.ToTable("Threats");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha de registro");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Params.Param", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Limits");
                });

            modelBuilder.Entity("EcosystemSpecies", b =>
                {
                    b.Property<int>("EcosystemsId")
                        .HasColumnType("int");

                    b.Property<int>("SpeciesId")
                        .HasColumnType("int");

                    b.HasKey("EcosystemsId", "SpeciesId");

                    b.HasIndex("SpeciesId");

                    b.ToTable("EcosystemSpecies");
                });

            modelBuilder.Entity("EcosystemThreat", b =>
                {
                    b.Property<int>("EcosystemsId")
                        .HasColumnType("int");

                    b.Property<int>("ThreatsId")
                        .HasColumnType("int");

                    b.HasKey("EcosystemsId", "ThreatsId");

                    b.HasIndex("ThreatsId");

                    b.ToTable("EcosystemThreat");
                });

            modelBuilder.Entity("SpeciesThreat", b =>
                {
                    b.Property<int>("SpeciesId")
                        .HasColumnType("int");

                    b.Property<int>("ThreatsId")
                        .HasColumnType("int");

                    b.HasKey("SpeciesId", "ThreatsId");

                    b.HasIndex("ThreatsId");

                    b.ToTable("SpeciesThreat");
                });

            modelBuilder.Entity("CountryEcosystem", b =>
                {
                    b.HasOne("Domain.Entities.Country", null)
                        .WithMany()
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Ecosystem", null)
                        .WithMany()
                        .HasForeignKey("EcosystemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Conservation", b =>
                {
                    b.OwnsOne("Domain.ValueObjects.Name", "ConservationName", b1 =>
                        {
                            b1.Property<int>("ConservationId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(450)")
                                .HasColumnName("Nombre");

                            b1.HasKey("ConservationId");

                            b1.HasIndex("Value")
                                .IsUnique();

                            b1.ToTable("Conservations");

                            b1.WithOwner()
                                .HasForeignKey("ConservationId");
                        });

                    b.Navigation("ConservationName")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.OwnsOne("Domain.ValueObjects.Name", "CountryName", b1 =>
                        {
                            b1.Property<int>("CountryId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(450)")
                                .HasColumnName("Nombre");

                            b1.HasKey("CountryId");

                            b1.HasIndex("Value")
                                .IsUnique();

                            b1.ToTable("Countries");

                            b1.WithOwner()
                                .HasForeignKey("CountryId");
                        });

                    b.Navigation("CountryName")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Ecosystem", b =>
                {
                    b.HasOne("Domain.Entities.Conservation", "EcoConservation")
                        .WithMany("ConservationEcosystems")
                        .HasForeignKey("EcoConservationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.OwnsOne("Domain.ValueObjects.Description", "EcoDescription", b1 =>
                        {
                            b1.Property<int>("EcosystemId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("EcosystemId");

                            b1.ToTable("Ecosystems");

                            b1.WithOwner()
                                .HasForeignKey("EcosystemId");
                        });

                    b.OwnsOne("Domain.ValueObjects.Name", "EcosystemName", b1 =>
                        {
                            b1.Property<int>("EcosystemId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(450)")
                                .HasColumnName("Nombre");

                            b1.HasKey("EcosystemId");

                            b1.HasIndex("Value")
                                .IsUnique();

                            b1.ToTable("Ecosystems");

                            b1.WithOwner()
                                .HasForeignKey("EcosystemId");
                        });

                    b.Navigation("EcoConservation");

                    b.Navigation("EcoDescription")
                        .IsRequired();

                    b.Navigation("EcosystemName")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Species", b =>
                {
                    b.HasOne("Domain.Entities.Conservation", "SpeciesConservation")
                        .WithMany("ConservationSpecies")
                        .HasForeignKey("SpeciesConservationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.OwnsOne("Domain.ValueObjects.Description", "SpeciesDescription", b1 =>
                        {
                            b1.Property<int>("SpeciesId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("SpeciesId");

                            b1.ToTable("Species");

                            b1.WithOwner()
                                .HasForeignKey("SpeciesId");
                        });

                    b.OwnsOne("Domain.ValueObjects.Name", "SpeciesName", b1 =>
                        {
                            b1.Property<int>("SpeciesId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(450)")
                                .HasColumnName("Nombre");

                            b1.HasKey("SpeciesId");

                            b1.HasIndex("Value")
                                .IsUnique();

                            b1.ToTable("Species");

                            b1.WithOwner()
                                .HasForeignKey("SpeciesId");
                        });

                    b.Navigation("SpeciesConservation");

                    b.Navigation("SpeciesDescription")
                        .IsRequired();

                    b.Navigation("SpeciesName")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Threat", b =>
                {
                    b.OwnsOne("Domain.ValueObjects.Description", "ThreatDescription", b1 =>
                        {
                            b1.Property<int>("ThreatId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ThreatId");

                            b1.ToTable("Threats");

                            b1.WithOwner()
                                .HasForeignKey("ThreatId");
                        });

                    b.OwnsOne("Domain.ValueObjects.Name", "ThreatName", b1 =>
                        {
                            b1.Property<int>("ThreatId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(450)")
                                .HasColumnName("Nombre");

                            b1.HasKey("ThreatId");

                            b1.HasIndex("Value")
                                .IsUnique();

                            b1.ToTable("Threats");

                            b1.WithOwner()
                                .HasForeignKey("ThreatId");
                        });

                    b.Navigation("ThreatDescription")
                        .IsRequired();

                    b.Navigation("ThreatName")
                        .IsRequired();
                });

            modelBuilder.Entity("EcosystemSpecies", b =>
                {
                    b.HasOne("Domain.Entities.Ecosystem", null)
                        .WithMany()
                        .HasForeignKey("EcosystemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Species", null)
                        .WithMany()
                        .HasForeignKey("SpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EcosystemThreat", b =>
                {
                    b.HasOne("Domain.Entities.Ecosystem", null)
                        .WithMany()
                        .HasForeignKey("EcosystemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Threat", null)
                        .WithMany()
                        .HasForeignKey("ThreatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SpeciesThreat", b =>
                {
                    b.HasOne("Domain.Entities.Species", null)
                        .WithMany()
                        .HasForeignKey("SpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Threat", null)
                        .WithMany()
                        .HasForeignKey("ThreatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Conservation", b =>
                {
                    b.Navigation("ConservationEcosystems");

                    b.Navigation("ConservationSpecies");
                });
#pragma warning restore 612, 618
        }
    }
}
