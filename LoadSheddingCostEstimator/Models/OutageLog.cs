using System;

namespace LoadSheddingCostEstimator.Models
{
    /// <summary>
    /// Records a single load-shedding outage event.
    /// </summary>
    public class OutageLog
    {
        public int      OutageID      { get; set; }
        public int      UserID        { get; set; }
        public DateTime StartTime     { get; set; }
        public DateTime EndTime       { get; set; }
        public double   DurationHours { get; set; }
    }
}
