using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckPlanAnalytics.Core.Models
{
    public class DistancePerCountry
    {
        public Guid ID { get; set; }
        public Guid TruckPlanId { get; set; }
        public TruckPlan TruckPlan { get; set; }
        public int CountryCode { get; set; }
        public double Distance { get; set; }
    }
}
