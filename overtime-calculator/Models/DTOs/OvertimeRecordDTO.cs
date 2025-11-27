using System.ComponentModel.DataAnnotations;

namespace overtime_calculator.Models.DTOs
{
    public class OvertimeRecordDTO
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public string? Description { get; set; }
        public TimeSpan CalculatedOvertime { get; set; }
    }
}
