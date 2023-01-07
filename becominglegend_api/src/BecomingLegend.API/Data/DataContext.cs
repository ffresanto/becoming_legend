using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BecomingLegend.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BecomingLegend.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Achievement> Achievements {get;set;}
        public DbSet<Team> Teams {get;set;}
    }
}