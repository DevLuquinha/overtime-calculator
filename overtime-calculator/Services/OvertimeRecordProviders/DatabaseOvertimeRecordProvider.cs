using Microsoft.EntityFrameworkCore;
using overtime_calculator.DbContexts;
using overtime_calculator.Models;
using overtime_calculator.Models.DTOs;

namespace overtime_calculator.Services.OvertimeRecordProviders
{
    public class DatabaseOvertimeRecordProvider : IOvertimeRecordProvider
    {
        private readonly OvertimeCalculatorDbContextFactory _dbContextFactory;
        public DatabaseOvertimeRecordProvider(OvertimeCalculatorDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<OvertimeRecord>> GetAllOvertimeRecords()
        {
            using (OvertimeCalculatorDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<OvertimeRecordDTO> overtimeRecordsDtos = await context
                    .OvertimeRecords
                    .ToListAsync();

                return overtimeRecordsDtos.Select(dto => ToOvertimeRecord(dto));
            }
        }

        private static OvertimeRecord ToOvertimeRecord(OvertimeRecordDTO dto)
        {
            return new OvertimeRecord
            {
                Date = dto.Date,
                EntryTime = dto.EntryTime,
                ExitTime = dto.ExitTime,
                Description = dto.Description
            };
        }
    }
}
