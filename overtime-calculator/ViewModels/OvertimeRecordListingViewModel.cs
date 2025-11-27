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
