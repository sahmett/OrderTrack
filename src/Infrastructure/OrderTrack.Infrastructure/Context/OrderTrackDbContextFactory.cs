﻿using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace OrderTrack.Persistence.Context
{
    public class OrderTrackDbContextFactory : IDesignTimeDbContextFactory<OrderTrackContext>
    {
        public OrderTrackContext CreateDbContext(string[] args)
        {
            // Projenizin kök dizinine göre doğru yolu ayarlayın
            var basePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "OrderTrack.API"));
            var configuration = new ConfigurationBuilder().SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<OrderTrackContext>();
            var connectionString = configuration.GetConnectionString("PostgreSQLDB");
            optionsBuilder.UseNpgsql(connectionString);

            return new OrderTrackContext(optionsBuilder.Options);
        }


    }
}
