namespace overtime_calculator.Models
{
    internal class OvertimeRecord
    {
        public DateTime Date { get; set; } 
        public TimeSpan EntryTime { get; set; }
        public TimeSpan ExitTime { get; set; }
        public string? Description { get; set; }
        public TimeSpan CalculatedOvertime { get; set; } // ExitTime - EntryTime - 1 hour lunch
        public double DaysEquivalent { get; set; } // CalculatedOvertime / 6 hours
    }
}
