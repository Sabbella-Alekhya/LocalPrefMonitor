namespace PerfDashboard.Models
{
    public class Metric
    {
        public DateTime Timestamp { get; set; }
        public int CpuUsage { get; set; }
        public int MemoryUsage { get; set; }
    }
}
