using overtime_calculator.Models;

namespace overtime_calculator.Services.OvertimeRecordProviders
{
    public class DatabaseOvertimeRecordProvider : IOvertimeRecordProvider
    {
        public Task<IEnumerable<OvertimeRecord>> GetAllOvertimeRecords()
        {
            throw new NotImplementedException();
        }
    }
}
