using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TallaghtTimetable.Models
{
    public class RoomDBContext : DbContext
    {
        // manually specify name of connection string in config
        public RoomDBContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<RoomDBContext>(new DropCreateDatabaseIfModelChanges<RoomDBContext>());
            // or CreateDatabaseIfNotExists (default)
            // or DropCreateDatabaseAlways
        }

        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Icon> Icons { get; set; }

        public DbSet<Study> Studys { get; set; }

    }
}