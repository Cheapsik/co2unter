﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using co2unter.API.Infrastructure;

#nullable disable

namespace co2unter.API.Migrations
{
    [DbContext(typeof(Co2UnterDbContext))]
    [Migration("20240928193436_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("co2unter.API.Infrastructure.Entities.ServiceEmission", b =>
                {
                    b.Property<string>("ServiceType")
                        .HasColumnType("text")
                        .HasColumnName("service_type");

                    b.Property<int>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.Property<double>("TotalCO2EmissionsKg")
                        .HasColumnType("double precision")
                        .HasColumnName("total_co2emissions_kg");

                    b.HasKey("ServiceType", "Year")
                        .HasName("pk_service_emissions");

                    b.ToTable("service_emissions", (string)null);
                });

            modelBuilder.Entity("co2unter.API.Infrastructure.Entities.TransportEmission", b =>
                {
                    b.Property<string>("TransportType")
                        .HasColumnType("text")
                        .HasColumnName("transport_type");

                    b.Property<int>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.Property<double>("TotalCO2EmissionsKg")
                        .HasColumnType("double precision")
                        .HasColumnName("total_co2emissions_kg");

                    b.Property<double>("TotalDistanceKm")
                        .HasColumnType("double precision")
                        .HasColumnName("total_distance_km");

                    b.HasKey("TransportType", "Year")
                        .HasName("pk_transport_emissions");

                    b.ToTable("transport_emissions", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
