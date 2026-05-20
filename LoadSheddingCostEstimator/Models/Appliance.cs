namespace LoadSheddingCostEstimator.Models
{
    /// <summary>
    /// Represents an electrical appliance with its power consumption details.
    /// </summary>
    public class Appliance
    {
        public int    ApplianceID   { get; set; }
        public string ApplianceName { get; set; }
        public double Wattage       { get; set; }
        public double Rate          { get; set; }   // PKR per kWh
    }
}
