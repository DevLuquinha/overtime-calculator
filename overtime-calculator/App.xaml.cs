using System.Windows;
using Microsoft.EntityFrameworkCore;
using overtime_calculator.DbContexts;

namespace overtime_calculator
{
    public partial class App : Application
    {   
        private const string CONNECTION_STRING = "Data Source=overtimecalculator.db";

        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextOptions options = new DbContextOptionsBuilder()
                .UseSqlite(CONNECTION_STRING)
                .Options;

            using (OvertimeCalculatorDbContext dbContext = new OvertimeCalculatorDbContext(options))
            {
                dbContext.Database.Migrate();
            }
        }
    }
}