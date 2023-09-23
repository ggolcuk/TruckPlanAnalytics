using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TruckPlanAnalytics.Core.Models
{
    public class Truck
    {
        public Guid ID { get; set; } 
        public string RegistrationNumber { get; set; }
        public string TruckModel { get; set; }
        public List<TruckPlan> TruckPlans { get; set; }
      
        public LicenseType RequiredLicense { get; set; }
        
    }

}
