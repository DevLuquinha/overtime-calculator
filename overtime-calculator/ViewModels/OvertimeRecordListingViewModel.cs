using overtime_calculator.Models;
using overtime_calculator.Utils;
using System.Collections.ObjectModel;

namespace overtime_calculator.ViewModels
{
    public class OvertimeRecordListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<OvertimeRecordViewModel> _overtimeRecords;
        public IEnumerable<OvertimeRecordViewModel> OvertimeRecords => _overtimeRecords;    

        public OvertimeRecordListingViewModel()
        {
            _overtimeRecords = new ObservableCollection<OvertimeRecordViewModel>();

            // For demonstration purposes, adding some dummy data
            _overtimeRecords.Add(new OvertimeRecordViewModel(new OvertimeRecord
            {
                Date = DateTime.Now.AddDays(-1),
                EntryTime = DateTime.Now.AddDays(-1).AddHours(17),
                ExitTime = DateTime.Now.AddDays(-1).AddHours(20)
            }));

            _overtimeRecords.Add(new OvertimeRecordViewModel(new OvertimeRecord
            {
                Date = DateTime.Now.AddDays(-2),
                EntryTime = DateTime.Now.AddDays(-2).AddHours(18),
                ExitTime = DateTime.Now.AddDays(-2).AddHours(21)
            }));
        }
    }
}
