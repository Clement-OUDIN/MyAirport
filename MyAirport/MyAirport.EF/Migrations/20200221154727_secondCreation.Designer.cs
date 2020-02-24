﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyAirport.EF;

namespace MyAirport.EF.Migrations
{
    [DbContext(typeof(MyAirportDB))]
    [Migration("20200221154727_secondCreation")]
    partial class secondCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("LO.MyAirport.EF.Bagage", b =>
                {
                    b.Property<int>("BagageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CLASSE")
                        .HasColumnType("TEXT");

                    b.Property<string>("CODE_IATA")
                        .HasColumnType("TEXT");

                    b.Property<int>("DATE_CREATION")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DES")
                        .HasColumnType("TEXT");

                    b.Property<string>("IMM")
                        .HasColumnType("TEXT");

                    b.Property<int>("PAX")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PKG")
                        .HasColumnType("TEXT");

                    b.Property<int>("VolId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BagageId");

                    b.ToTable("Bagages");
                });

            modelBuilder.Entity("LO.MyAirport.EF.Vol", b =>
                {
                    b.Property<int>("VolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CIE")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DES")
                        .HasColumnType("TEXT");

                    b.Property<string>("DHC")
                        .HasColumnType("TEXT");

                    b.Property<string>("IMM")
                        .HasColumnType("TEXT");

                    b.Property<int>("JEX")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LIG")
                        .HasColumnType("TEXT");

                    b.Property<int>("PAX")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PKG")
                        .HasColumnType("TEXT");

                    b.HasKey("VolId");

                    b.ToTable("Vols");
                });
#pragma warning restore 612, 618
        }
    }
}