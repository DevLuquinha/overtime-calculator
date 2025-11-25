using overtime_calculator.Utils;

namespace overtime_calculator.ViewModels
{
    public class OvertimeViewModel : ViewModelBase
    {
        private DateTime _recordDate;
        public DateTime RecordDate
        {
            get => _recordDate;
            set 
            { 
                _recordDate = value; 
                OnPropertyChanged();
            }
        }

        private DateTime _entryTime;
        public DateTime EntryTime
        {
            get => _entryTime;
            set 
            { 
                _entryTime = value; 
                OnPropertyChanged(); 
            }
        }

        private DateTime _exitTime;
        public DateTime ExitTime
        {
            get => _exitTime;
            set 
            { 
                _exitTime = value; 
                OnPropertyChanged(); 
            }
        }

        private string? _description;
        public string? Description
        {
            get => _description;
            set 
            { 
                _description = value; 
                OnPropertyChanged(); 
            }
        }
    }
}
