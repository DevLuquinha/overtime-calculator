using overtime_calculator.Utils;
using overtime_calculator.Models;

namespace overtime_calculator.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public OvertimeViewModel OvertimeViewModel { get; }
        public OvertimeRecordListingViewModel OvertimeRecordListingViewModel { get; }
        public MainViewModel()
        {
            // Initialize ViewModels
            OvertimeRecordListingViewModel = new OvertimeRecordListingViewModel();
            OvertimeViewModel = new OvertimeViewModel();

            // Subscribe to the event when a new overtime record is saved
            OvertimeViewModel.OvertimeRecordSaved += OnOvertimeRecordSaved;
        }

        /// <summary>
        /// Handles the event that occurs when a new overtime record is saved.
        /// </summary>
        /// <param name="sender">The source of the event. This parameter can be null.</param>
        /// <param name="record">The overtime record that was saved. Cannot be null.</param>
        private void OnOvertimeRecordSaved(object? sender, OvertimeRecord record)
        {
            // Add the new record to the listing ViewModel
            OvertimeRecordListingViewModel.AddRecord(record);
        }
    }
}
