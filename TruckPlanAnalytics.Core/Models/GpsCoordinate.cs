using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Geolocation;

namespace TruckPlanAnalytics.Core.Models
{
    public class GpsCoordinate
    {
        public Guid ID { get; set; }
        public Coordinate Coordinate { get; set; }
        public Guid TruckPlanId { get; set; }
        public TruckPlan TruckPlan { get; set; }
        public int CountryCode { get; set; }
        public Guid TruckId { get; set; }
        public Truck Truck{ get; set; }
        public DateTime Timestamp { get; set; }

    }
}
