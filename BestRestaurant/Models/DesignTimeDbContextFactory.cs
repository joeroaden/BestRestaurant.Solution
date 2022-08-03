using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BestRestaurant.Models
{
  public class BestRestaurantContextFactory : IDesignTimeDbContextFactory<BestRestaurantContext>
  {

    BestRestaurantContext IDesignTimeDbContextFactory<BestRestaurantContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<BestRestaurantContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new BestRestaurantContext(builder.Options);
    }
  }
}