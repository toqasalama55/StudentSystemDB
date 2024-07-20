using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.P01__StudentSystem.Models;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<Homework> Homework { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystemDB;Integrated Security=True;TrustServerCertificate=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(true);
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.PhoneNo)
                .HasColumnType("varchar(10)")
                .IsUnicode(false)
                .IsRequired(false);
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.RegisteredOn)
                .IsRequired(false);
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(true);

            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.Property(e => e.Description)
                .IsRequired(false)
                .IsUnicode(true);

            });

            modelBuilder.Entity<Resources>(entity =>
            {
                entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            });

            modelBuilder.Entity<Homework>(entity =>
            {
                entity.Property(e => e.Contect)
                .IsUnicode(true);
            });


            

        }
    }
}
