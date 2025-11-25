using overtime_calculator.Utils;
using System.Windows;
using System.Windows.Input;

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

        public ICommand SaveCommand { get; }

        public OvertimeViewModel()
        {
            SetDefaultValues();

            SaveCommand = new RelayCommand(p => 
            { 
                Description = $"O seu registro de horas extras em {RecordDate:dd/MM/yyyy} das {EntryTime:HH:mm} às {ExitTime:HH:mm} foi salvo com sucesso.";
            });
        }

        private void SetDefaultValues()
        {
            RecordDate = DateTime.Now;
            EntryTime = DateTime.Now.Date.AddHours(8.5);
            ExitTime = DateTime.Now.Date.AddHours(15.5);
            Description = string.Empty;
        }
    }
}
