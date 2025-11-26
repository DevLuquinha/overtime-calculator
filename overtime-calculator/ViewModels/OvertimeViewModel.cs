using System.Windows;
using System.Windows.Input;
using overtime_calculator.Utils;
using overtime_calculator.Models;

namespace overtime_calculator.ViewModels
{
    public class OvertimeViewModel : ViewModelBase
    {
        public event EventHandler<OvertimeRecord>? OvertimeRecordSaved;

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
                SaveRecord();
            });
        }

        private bool CanSaveRecord()
        { 
            return ExitTime > EntryTime;
        }

        private void SaveRecord()
        {
            if (!CanSaveRecord())
            {
                MessageBox.Show(
                    "O horário de saída deve ser posterior ao horário de entrada.",
                    "Erro",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                return;
            }

            OvertimeRecord record = new OvertimeRecord
            {
                Date = RecordDate,
                EntryTime = EntryTime,
                ExitTime = ExitTime,
                Description = Description ?? string.Empty
            };

            OvertimeRecordSaved?.Invoke(this, record);

            MessageBox.Show(
                "Registro de horas extras salvo com sucesso!",
                "Sucesso",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            
            SetDefaultValues();
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
