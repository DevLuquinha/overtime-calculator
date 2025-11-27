using overtime_calculator.DbContexts;
using overtime_calculator.Models;
using overtime_calculator.Models.DTOs;

namespace overtime_calculator.Services.OvertimeRecordCreators
{
    public class DatabaseOvertimeRecordCreation : IOvertimeRecordCreator
    {
        private readonly OvertimeCalculatorDbContextFactory _dbContextFactory;
        public DatabaseOvertimeRecordCreation(OvertimeCalculatorDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateOvertimeRecord(OvertimeRecord overtimeRecord)
        {
            using (OvertimeCalculatorDbContext context = _dbContextFactory.CreateDbContext())
            {
                OvertimeRecordDTO overtimeRecordDTO = ToOvertimeRecordDTO(overtimeRecord);

                context.OvertimeRecords.Add(overtimeRecordDTO);
                await context.SaveChangesAsync();
            }
        }

        private OvertimeRecordDTO ToOvertimeRecordDTO(OvertimeRecord overtimeRecord)
        {
            return new OvertimeRecordDTO
            {
                Id = Guid.NewGuid(),
                Date = overtimeRecord.Date,
                EntryTime = overtimeRecord.EntryTime,
                ExitTime = overtimeRecord.ExitTime,
                Description = overtimeRecord.Description,
                CalculatedOvertime = overtimeRecord.CalculatedOvertime
            };
        }
    }
}
