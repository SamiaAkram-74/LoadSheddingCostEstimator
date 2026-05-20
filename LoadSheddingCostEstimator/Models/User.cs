using System;

namespace LoadSheddingCostEstimator.Models
{
    /// <summary>
    /// Represents a registered user of the application.
    /// </summary>
    public class User
    {
        public int    UserID   { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
