using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TruckPlanAnalytics.Core.Models
{
    public class TruckPlan
    {
        public Guid ID { get; set; }
        public Guid TruckId { get; set; }
        public Truck Truck { get; set; }
        public Guid DriverId { get; set; }
        public Driver Driver { get; set; }
        public Status Status { get; set; }
        public List<GpsCoordinate> GpsCoordinates { get; set; }
        public List<DistancePerCountry> DistancesPerCountry { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public string SourceLocation { get; set; }
        public string DestinationLocation { get; set; }
    }


    public enum Status
    {
        Created,
        InProgress,
        Completed,
        Distrupted,

    }
}
