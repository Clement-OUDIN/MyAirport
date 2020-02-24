using System;
using System.Collections.Concurrent;
using LO.MyAirport.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MyAirport.EF
{
    public class MyAirportDB : DbContext
    {
        public DbSet<Vol> Vols { get; set; }
        public DbSet<Bagage> Bagages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseMySql(@"User Id=root;Host=localhost;Database=Test;");
        }
    }
}
