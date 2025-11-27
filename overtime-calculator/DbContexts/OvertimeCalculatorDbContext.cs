using Microsoft.EntityFrameworkCore;
using overtime_calculator.Models.DTOs;

namespace overtime_calculator.DbContexts
{
    public class OvertimeCalculatorDbContext : DbContext
    {
        public OvertimeCalculatorDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<OvertimeRecordDTO> OvertimeRecords { get; set; }
    }
}
