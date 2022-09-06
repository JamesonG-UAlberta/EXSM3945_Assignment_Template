﻿// <auto-generated />
using API_Assignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_Assignment.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220906140852_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_general_ci")
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("API_Assignment.Models.Dealership", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("address");

                    b.Property<int>("ManufacturerID")
                        .HasColumnType("int(11)")
                        .HasColumnName("manufacturerid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("char(10)")
                        .HasColumnName("phonenumber");

                    b.HasKey("ID");

                    b.HasIndex(new[] { "ManufacturerID" }, "FK_Dealership_Manufacturer");

                    b.ToTable("dealership", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "123 Cool St",
                            ManufacturerID = 1,
                            Name = "Joe's Discount Fords",
                            PhoneNumber = "8005551234"
                        });
                });

            modelBuilder.Entity("API_Assignment.Models.Vehicle", b =>
                {
                    b.Property<string>("VIN")
                        .HasColumnType("char(17)")
                        .HasColumnName("vin");

                    b.Property<int>("DealershipID")
                        .HasColumnType("int(11)");

                    b.Property<int>("ModelID")
                        .HasColumnType("int(11)")
                        .HasColumnName("modelid");

                    b.Property<string>("TrimLevel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("trimlevel");

                    b.HasKey("VIN");

                    b.HasIndex(new[] { "DealershipID" }, "FK_Vehicle_Dealership");

                    b.HasIndex(new[] { "ModelID" }, "FK_Vehicle_Model");

                    b.ToTable("vehicle", (string)null);

                    b.HasData(
                        new
                        {
                            VIN = "1FA6P8TH4J5102322",
                            DealershipID = 1,
                            ModelID = 1,
                            TrimLevel = "Ecoboost"
                        },
                        new
                        {
                            VIN = "2C3CDXCT7JH260378",
                            DealershipID = 1,
                            ModelID = 6,
                            TrimLevel = "R/T"
                        },
                        new
                        {
                            VIN = "2HGFC3A51LH220441",
                            DealershipID = 1,
                            ModelID = 7,
                            TrimLevel = "SI"
                        });
                });

            modelBuilder.Entity("API_Assignment.Models.VehicleManufacturer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.ToTable("manufacturer", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Ford"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Chevrolet"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Dodge"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Honda"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Toyota"
                        });
                });

            modelBuilder.Entity("API_Assignment.Models.VehicleModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<int>("ManufacturerID")
                        .HasColumnType("int(11)")
                        .HasColumnName("manufacturerid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.HasIndex(new[] { "ManufacturerID" }, "FK_Model_Manufacturer");

                    b.ToTable("model", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ManufacturerID = 1,
                            Name = "Mustang"
                        },
                        new
                        {
                            ID = 2,
                            ManufacturerID = 1,
                            Name = "F-150"
                        },
                        new
                        {
                            ID = 3,
                            ManufacturerID = 2,
                            Name = "Corvette"
                        },
                        new
                        {
                            ID = 4,
                            ManufacturerID = 2,
                            Name = "Camaro"
                        },
                        new
                        {
                            ID = 5,
                            ManufacturerID = 3,
                            Name = "Challenger"
                        },
                        new
                        {
                            ID = 6,
                            ManufacturerID = 3,
                            Name = "Charger"
                        },
                        new
                        {
                            ID = 7,
                            ManufacturerID = 4,
                            Name = "Civic"
                        },
                        new
                        {
                            ID = 8,
                            ManufacturerID = 4,
                            Name = "Accord"
                        },
                        new
                        {
                            ID = 9,
                            ManufacturerID = 5,
                            Name = "Corolla"
                        },
                        new
                        {
                            ID = 10,
                            ManufacturerID = 5,
                            Name = "Camry"
                        });
                });

            modelBuilder.Entity("API_Assignment.Models.Dealership", b =>
                {
                    b.HasOne("API_Assignment.Models.VehicleManufacturer", "VehicleManufacturer")
                        .WithMany("Dealerships")
                        .HasForeignKey("ManufacturerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Dealership_Manufacturer");

                    b.Navigation("VehicleManufacturer");
                });

            modelBuilder.Entity("API_Assignment.Models.Vehicle", b =>
                {
                    b.HasOne("API_Assignment.Models.Dealership", "Dealership")
                        .WithMany("Vehicles")
                        .HasForeignKey("DealershipID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Vehicle_Dealership");

                    b.HasOne("API_Assignment.Models.VehicleModel", "VehicleModel")
                        .WithMany("Vehicles")
                        .HasForeignKey("ModelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Vehicle_Model");

                    b.Navigation("Dealership");

                    b.Navigation("VehicleModel");
                });

            modelBuilder.Entity("API_Assignment.Models.VehicleModel", b =>
                {
                    b.HasOne("API_Assignment.Models.VehicleManufacturer", "VehicleManufacturer")
                        .WithMany("VehicleModels")
                        .HasForeignKey("ManufacturerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Model_Manufacturer");

                    b.Navigation("VehicleManufacturer");
                });

            modelBuilder.Entity("API_Assignment.Models.Dealership", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("API_Assignment.Models.VehicleManufacturer", b =>
                {
                    b.Navigation("Dealerships");

                    b.Navigation("VehicleModels");
                });

            modelBuilder.Entity("API_Assignment.Models.VehicleModel", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
