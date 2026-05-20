namespace LoadSheddingCostEstimator.Models
{
    /// <summary>
    /// Records how many hours a specific appliance was used during an outage.
    /// </summary>
    public class UsageLog
    {
        public int    UsageID     { get; set; }
        public int    OutageID    { get; set; }
        public int    ApplianceID { get; set; }
        public double HoursUsed   { get; set; }
    }
}
