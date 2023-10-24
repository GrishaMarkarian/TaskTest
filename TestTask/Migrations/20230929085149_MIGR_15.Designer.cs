﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestTask;

#nullable disable

namespace TestTask.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230929085149_MIGR_15")]
    partial class MIGR_15
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestTask.Car", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("TestTask.CarsTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ATM_MTM")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ATM MTM");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body_1")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Body 1");

                    b.Property<string>("Body_2")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Body 2");

                    b.Property<string>("Bulding_Condition")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Bulding Condition");

                    b.Property<string>("Cab")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Car_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complectation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DECK_CAB")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DECK,CAB");

                    b.Property<string>("DECK_MATERIAL")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DECK(MATERIAL)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desk")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Desk");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Destination");

                    b.Property<string>("Destination_1")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Destination 1");

                    b.Property<string>("Destination_2")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Destination 2");

                    b.Property<string>("Drivers_Position")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Drivers Position");

                    b.Property<string>("Emission_Regulation")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Emission Regulation");

                    b.Property<string>("Engine_1")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Engine 1");

                    b.Property<string>("Engine_2")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Engine 2");

                    b.Property<string>("Fuel_Induction")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Fuel Induction");

                    b.Property<string>("Gear_Shift_Type")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Gear Shift Type");

                    b.Property<string>("Grade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Loading_Capacity")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Loading Capacity");

                    b.Property<string>("Model_Mark")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Model Mark");

                    b.Property<string>("NOOF_DOORS")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOOF DOORS");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Product");

                    b.Property<string>("ROOF")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ROOF");

                    b.Property<string>("Rear_Time")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Rear Time");

                    b.Property<string>("Rear_Tire")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Rear Tire");

                    b.Property<string>("Roll_Bar")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Roll Bar");

                    b.Property<string>("Seating_Capasity")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Seating Capasity");

                    b.Property<string>("Side_Window")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Side Window");

                    b.Property<string>("Top_Back_Dorr")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Top Back Door");

                    b.Property<string>("Transmission_Model")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Transmission Model");

                    b.Property<string>("Truck_Or_Van")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Truck or Van");

                    b.Property<string>("Vehicle_Model")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Vehicle Model");

                    b.HasKey("Id");

                    b.ToTable("CarsTables");
                });

            modelBuilder.Entity("TestTask.Detail", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TreeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Details");
                });
#pragma warning restore 612, 618
        }
    }
}