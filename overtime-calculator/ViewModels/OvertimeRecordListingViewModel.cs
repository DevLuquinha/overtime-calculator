using System.Collections.ObjectModel;
using overtime_calculator.Utils;
using overtime_calculator.Models;

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
                ExitTime = DateTime.Now.AddDays(-1).AddHours(20),
                Description = "Worked on project X"
            }));

            _overtimeRecords.Add(new OvertimeRecordViewModel(new OvertimeRecord
            {
                Date = DateTime.Now.AddDays(-2),
                EntryTime = DateTime.Now.AddDays(-2).AddHours(18),
                ExitTime = DateTime.Now.AddDays(-2).AddHours(21),
                Description = "Client meeting"
            }));
        }

        /// <summary>
        /// Adds a new overtime record to the collection.
        /// </summary>
        /// <param name="record">The overtime record to add. Cannot be null.</param>
        public void AddRecord(OvertimeRecord record)
        {
            OvertimeRecordViewModel viewModel = new OvertimeRecordViewModel(record);
            _overtimeRecords.Insert(0, viewModel);
        }
    }
}
