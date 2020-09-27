using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Venus.Authorization.Roles;
using Venus.Authorization.Users;
using Venus.MultiTenancy;

namespace Venus.EntityFrameworkCore
{
    public class VenusDbContext : AbpZeroDbContext<Tenant, Role, User, VenusDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public VenusDbContext(DbContextOptions<VenusDbContext> options)
            : base(options)
        {
        }
    }
}
