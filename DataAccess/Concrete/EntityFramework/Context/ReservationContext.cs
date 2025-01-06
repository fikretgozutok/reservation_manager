using Core.Utilities.Helpers;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class ReservationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configurationManager = ConfigurationHelper.GetConfiguration();
            var connectionString = configurationManager.GetConnectionString("DefaultConnection") ?? throw new Exception("Connection string is not valid!");
            optionsBuilder.UseSqlServer(connectionString);
        }

        DbSet<Address> Addresses { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Provider> Providers { get; set; }
        DbSet<Reservation> Reservations { get; set; }
        DbSet<Service> Services { get; set; }
    }
}
