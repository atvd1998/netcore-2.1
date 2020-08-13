using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .HasData(
                new Room { RoomId = 1, RoomName = "Room1", Number = 1 },
                new Room { RoomId = 2, RoomName = "Room2", Number = 2 }
                );
            modelBuilder.Entity<Student>()
                .HasData(
                new Student { StudentId = 1, StudentName = "Student1", BirthOfDate = DateTime.Now, RoomId = 1 },
                new Student { StudentId = 2, StudentName = "Student2", BirthOfDate = new DateTime(1998, 4, 4), RoomId = 2 },
                new Student { StudentId = 3, StudentName = "Student3", BirthOfDate = new DateTime(1998, 10, 11), RoomId = 2 }
                );
        }
    }
}