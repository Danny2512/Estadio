﻿using Estadio.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estadio.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<EntranceGate> EntranceGates { get; set; }
        public DbSet<Tiket> Tikets { get; set; }
        public DbSet<EntranceGateTiket> EntranceGateTikets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EntranceGateTiket>()
                .HasKey(et => new { et.TicketId, et.EntranceGateId });

            modelBuilder.Entity<EntranceGateTiket>()
                .HasOne(et => et.Tiket)
                .WithMany(t => t.EntranceGateTiket)
                .HasForeignKey(et => et.TicketId);

            modelBuilder.Entity<EntranceGateTiket>()
                .HasOne(et => et.EntranceGate)
                .WithMany(e => e.EntranceGateTiket)
                .HasForeignKey(et => et.EntranceGateId);

            modelBuilder.Entity<Tiket>()
                .HasIndex(c => c.Id)
                .IsUnique();

            modelBuilder.Entity<EntranceGate>()
                .HasIndex(c => c.Id)
                .IsUnique();
        }
    }
}
