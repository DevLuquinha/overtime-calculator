using overtime_calculator.Models;

namespace overtime_calculator.Services.OvertimeRecordCreators
{
    public interface IOvertimeRecordCreator
    {
        Task CreateOvertimeRecord(OvertimeRecord overtimeRecord);
    }
}
