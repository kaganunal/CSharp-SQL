using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMarathon.Models
{
    public class MyDBContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=KAGANUNAL;Database=AlbumDB;Trusted_Connection=True;Trust Server Certificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(a => a.Password)
                .HasConversion(
                    p => sha256_hash(p),
                    p => p
                );
        }


        public string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
    }
}
