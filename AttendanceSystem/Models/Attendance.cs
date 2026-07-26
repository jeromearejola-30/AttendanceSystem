namespace AttendanceSystem.Models
{
    public class Attendance
    {
        public string StudentId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}