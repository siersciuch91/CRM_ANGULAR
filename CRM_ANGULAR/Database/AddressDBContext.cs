using CRM_ANGULAR.Models.Address;
using Microsoft.EntityFrameworkCore;

namespace CRM_ANGULAR.Database
{
  public class AddressDBContext : DbContext
  {
    public AddressDBContext(DbContextOptions<AddressDBContext> options) 
      :base(options){ }

    public DbSet<City> Cities { get; set; }
  }
}
