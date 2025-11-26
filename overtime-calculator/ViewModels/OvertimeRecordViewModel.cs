using overtime_calculator.Utils;
using overtime_calculator.Models;

namespace overtime_calculator.ViewModels
{
    public class OvertimeRecordViewModel : ViewModelBase
    {
        private readonly OvertimeRecord _overtimeRecord;

        public DateTime RecordDate => _overtimeRecord.Date;
        public DateTime EntryTime => _overtimeRecord.EntryTime;
        public DateTime ExitTime => _overtimeRecord.ExitTime;

        public OvertimeRecordViewModel(OvertimeRecord overtimeRecord)
        {
            _overtimeRecord = overtimeRecord;
        }
    }
}
