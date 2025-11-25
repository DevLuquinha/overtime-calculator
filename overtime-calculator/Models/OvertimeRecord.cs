namespace overtime_calculator.Models
{
    public class OvertimeRecord
    {
        public DateTime Date { get; } 
        public TimeSpan EntryTime { get; }
        public TimeSpan ExitTime { get; }
        public string? Description { get; }
        public TimeSpan CalculatedOvertime => ExitTime - EntryTime - TimeSpan.FromHours(1);
        public double DaysEquivalent => CalculatedOvertime.TotalHours / 6.0;

        public OvertimeRecord(
            DateTime date,
            TimeSpan entryTime,
            TimeSpan exitTime,
            string? description)
        {
            Date = date;
            EntryTime = entryTime;
            ExitTime = exitTime;
            Description = description;
        }
    }
}
