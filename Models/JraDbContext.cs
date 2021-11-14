﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrascraping.Models
{
    public class JraDbContext : DbContext
    {
        public JraDbContext(DbContextOptions options)
       : base(options) { }
        public DbSet<RaceResult> RaceResults { get; set; }
        public DbSet<CnameTable> CnameTable { get; set; }
        public DbSet<HorseInfo> HorseInfo { get; set; }
        public DbSet<PayBack> PayBack { get; set; }
        public DbSet<RaceInfo> RaceInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite("Data Source=Jra.db");

        //復号キーの作成
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RaceResult>()
                .HasKey(c => new { c.Date, c.RaceName, c.Num, c.Place});
            modelBuilder.Entity<HorseInfo>()
                .HasKey(c => new { c.HorseName, c.Birthday });
            modelBuilder.Entity<RaceInfo>()
                .HasKey(c => new { c.Date });
        }
    }
}
