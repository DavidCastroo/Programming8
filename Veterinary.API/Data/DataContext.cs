﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Eventing.Reader;
using Veterinary.Shared.Entities;

namespace Veterinary.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Agenda> Agendas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
