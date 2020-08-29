using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace TCShop.Data.EF
{
    public class TCShopDbContextFactory : IDesignTimeDbContextFactory<TCShopDbContext>
    {
        public TCShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("TCShopDb");

            var optionsBuilder = new DbContextOptionsBuilder<TCShopDbContext>();
            optionsBuilder.UseMySql(connectionString);

            return new TCShopDbContext(optionsBuilder.Options);

        }

    }
}
