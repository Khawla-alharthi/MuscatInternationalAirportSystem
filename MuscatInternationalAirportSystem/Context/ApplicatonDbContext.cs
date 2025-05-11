using Microsoft.EntityFrameworkCore;
using MuscatInternationalAirportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscatInternationalAirportSystem.Context
{
    internal class ApplicatonDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MIAirportSystem ;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }

        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Baggage> Baggages { get; set; }
        public DbSet<Checkpoint> Checkpoints { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Officer> Officers { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Terminal> Terminals { get; set; }

    }
}
