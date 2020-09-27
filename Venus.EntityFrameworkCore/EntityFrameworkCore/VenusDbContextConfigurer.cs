using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Venus.EntityFrameworkCore
{
    public static class VenusDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<VenusDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<VenusDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
