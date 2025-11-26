namespace overtime_calculator.Models
{
    public class OvertimeRecord
    {
        public DateTime Date { get; set; } 
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public string? Description { get; set; }
        public TimeSpan CalculatedOvertime => ExitTime - EntryTime - TimeSpan.FromHours(1);
        public double DaysEquivalent => CalculatedOvertime.TotalHours / 6.0;
    }
}
