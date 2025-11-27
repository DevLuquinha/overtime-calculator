using Microsoft.EntityFrameworkCore;

namespace overtime_calculator.DbContexts
{
    public class OvertimeCalculatorDbContextFactory
    {
        private readonly string _connectionString;

        public OvertimeCalculatorDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public OvertimeCalculatorDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder()
                .UseSqlite(_connectionString)
                .Options;

            return new OvertimeCalculatorDbContext(options);
        }
    }
}
