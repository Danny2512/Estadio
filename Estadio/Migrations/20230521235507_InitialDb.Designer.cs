﻿// <auto-generated />
using System;
using Estadio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Estadio.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230521235507_InitialDb")]
    partial class InitialDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Estadio.Data.Entities.EntranceGate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("EntranceGates");
                });

            modelBuilder.Entity("Estadio.Data.Entities.EntranceGateTiket", b =>
                {
                    b.Property<Guid>("TicketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EntranceGateId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TicketId", "EntranceGateId");

                    b.HasIndex("EntranceGateId");

                    b.ToTable("EntranceGateTikets");
                });

            modelBuilder.Entity("Estadio.Data.Entities.Tiket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Tikets");
                });

            modelBuilder.Entity("Estadio.Data.Entities.EntranceGateTiket", b =>
                {
                    b.HasOne("Estadio.Data.Entities.EntranceGate", "EntranceGate")
                        .WithMany("EntranceGateTiket")
                        .HasForeignKey("EntranceGateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Estadio.Data.Entities.Tiket", "Tiket")
                        .WithMany("EntranceGateTiket")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntranceGate");

                    b.Navigation("Tiket");
                });

            modelBuilder.Entity("Estadio.Data.Entities.EntranceGate", b =>
                {
                    b.Navigation("EntranceGateTiket");
                });

            modelBuilder.Entity("Estadio.Data.Entities.Tiket", b =>
                {
                    b.Navigation("EntranceGateTiket");
                });
#pragma warning restore 612, 618
        }
    }
}
