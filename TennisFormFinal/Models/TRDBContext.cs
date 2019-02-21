using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace TennisFormFinal.Models
{
    public class TRDBContext : DbContext
    {
        public TRDBContext(DbContextOptions<TRDBContext> options) : base(options){}

        public DbSet<TennisReservation> TReservations { get; set; }
        public DbSet<Court> TCourts { get; set; }

    }


    public class TRDBContextFactory
           : IDesignTimeDbContextFactory<TRDBContext>
    {

        public TRDBContext CreateDbContext(string[] args) =>
            Program.BuildWebHost(args).Services
                .GetRequiredService<TRDBContext>();
    }
}

