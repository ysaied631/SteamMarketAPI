using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace SteamMarketAPI.Models
{
    public class SteamMarketApiContext : DbContext
    {
        public SteamMarketApiContext() : base()
        {
        }

        public SteamMarketApiContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
