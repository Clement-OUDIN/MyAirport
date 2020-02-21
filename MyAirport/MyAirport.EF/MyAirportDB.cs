using System;
using System.Collections.Concurrent;
using LO.MyAirport.EF;
using Microsoft.EntityFrameworkCore;

namespace MyAirport.EF
{
    public class MyAirportDB : DbContext
    {
        public DbSet<Vol> Vols { get; set; }
        public DbSet<Bagage> Bagages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            options.UseSqlite("Data Source=blogging.db");
        public MyAirportDB()
        {
        }
    }
}
