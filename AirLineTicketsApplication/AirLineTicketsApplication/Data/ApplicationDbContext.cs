using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AirLineTicketsApplication.Entities;

namespace AirLineTicketsApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<AirLineTicketsApplication.Entities.Client> Clients { get; set; }
        public DbSet<AirLineTicketsApplication.Entities.Flight> Flights { get; set; }
        public DbSet<AirLineTicketsApplication.Entities.Plane> Planes { get; set; }
        public DbSet<AirLineTicketsApplication.Entities.Reservation> Reservations { get; set; }
    }
}
