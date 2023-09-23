using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Models;

namespace TruckPlanAnalytics.Core.Interfaces
{
    internal interface ITruckService
    {
        Task<TruckPlan> GetActiveTruckPlan(Truck truck);
        Task StartTruckPlan(TruckPlan tp);
        Task CompleteTruckPlan(TruckPlan tp);
        Task AddTruckPlanCoordinates(TruckPlan tp, GpsCoordinate gps);

    }
}
