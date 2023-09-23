using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TruckPlanAnalytics.Core.Models
{
    public class Driver
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public List<TruckPlan> TruckPlans { get; set; }
        public List<LicenseType> Licenses { get; set; }
    }

    public enum LicenseType
    {
        ClassA, ClassB , ClassC, ClassD
    }
}
