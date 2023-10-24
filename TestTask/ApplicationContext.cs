using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    internal class ApplicationContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarsTable> CarsTables { get; set; }
        public DbSet<Detail> Details { get; set; }

        public DbSet<ElectricsTable> ElectricsTables { get; set; }
        public DbSet<EngineTable> EngineTables { get; set; }
        public DbSet<TransmissionTable> TransmissionTables { get; set; }
        public DbSet<BodyTable> BodyTables { get; set; }



        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-ENUJO8U\\MSSQLSERVER01;Database=TestDB;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True");
        }
    }
}


