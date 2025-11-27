using overtime_calculator.Models;

namespace overtime_calculator.Services.OvertimeRecordProviders
{
    public interface IOvertimeRecordProvider
    {
        Task<IEnumerable<OvertimeRecord>> GetAllOvertimeRecords();
    }
}
