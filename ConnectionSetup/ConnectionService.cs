using EmployeesDBApp;
using Microsoft.EntityFrameworkCore;

namespace EmployeesDbApp.ConnectionSetup
{
    internal class ConnectionService
    {
        public static async Task<ApplicationDbContext?> TestDatabaseConnectionAsync()
        {
            var config = DbConfigManager.LoadConfig();

            try
            {
                var dbContext = await CreateContextAsync(config);
                await dbContext.Database.ExecuteSqlRawAsync("SELECT 1");
                return dbContext;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection error: {ex.Message}");
                return null;
            }
        }

        public static async Task<bool> TestDefaultConnectionAsync()
        {
            var config = DbConfig.Default;

            try
            {
                using (var dbContext = await CreateContextAsync(config))
                {
                    await dbContext.Database.ExecuteSqlRawAsync("SELECT 1");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection error: {ex.Message}");
                return false;
            }
        }

        public static async Task<ApplicationDbContext> CreateContextAsync(DbConfig config)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionStr = config.GetConnectionString();
            optionsBuilder.UseNpgsql(connectionStr);

            var context = new ApplicationDbContext(optionsBuilder.Options);
            bool dbWasCreated = await context.Database.EnsureCreatedAsync();
            if (dbWasCreated)
            {
                context.WriteDummyRecords();
            }

            return context;
        }
    }
}
