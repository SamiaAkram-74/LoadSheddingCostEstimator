using System;

namespace LoadSheddingCostEstimator.Models
{
    /// <summary>
    /// Stores the calculated financial loss for a given outage event.
    /// </summary>
    public class LossRecord
    {
        public int      LossID     { get; set; }
        public int      OutageID   { get; set; }
        public double   TotalLoss  { get; set; }   // PKR
        public DateTime RecordDate { get; set; }
    }
}
