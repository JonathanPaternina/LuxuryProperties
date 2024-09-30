using LuxuryProperties.Shared;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LuxuryProperties.Data
{
    public class LuxuryPropertyContext : IdentityDbContext
    {
        public LuxuryPropertyContext(DbContextOptions options) : base(options) { }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<PropertyImage> PropertyImage { get; set; }
        public DbSet<PropertyTrace> PropertyTrace { get; set; }
        
    }
}
