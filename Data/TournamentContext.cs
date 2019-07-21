using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bracketdocious.Models;
using Microsoft.EntityFrameworkCore;

namespace bracketdocious.Data
{
    public class TournamentContext : DbContext
    {
        public TournamentContext(DbContextOptions<TournamentContext> options) : base(options)
        {
        }
        public DbSet<Bracket> Brackets { get; set; }
        public DbSet<Match> Match { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>().ToTable("Match");
            modelBuilder.Entity<Bracket>().ToTable("Brackets");
        }
        public DbSet<bracketdocious.Models.Teams> Teams { get; set; }
    }
}
