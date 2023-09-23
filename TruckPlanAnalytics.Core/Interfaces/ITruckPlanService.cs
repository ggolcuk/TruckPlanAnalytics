using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Models;

namespace TruckPlanAnalytics.Core.Interfaces
{
    public interface ITruckPlanService
    {
        Task<TruckPlan> CreateTruckPlanAsync();
        Task AssignDriverToTruckPlan(Driver driver);
        Task AssignTruckToTruckPlan(Truck truck);
        Task<IEnumerable<TruckPlan>> GetAllTruckPlansAsync();
        Task<IEnumerable<TruckPlan>> GetAllTruckPlansByDriver(Driver driver);
        Task<IEnumerable<TruckPlan>> GetAllTruckPlansByTruck(Truck truck);
        Task<IEnumerable<TruckPlan>> GetAllTruckPlansByStatus(Status status);
        Task<TruckPlan> GetTruckPlanByIdAsync(int id);
        Task UpdateTruckPlanAsync(TruckPlan plan);
        Task DeleteTruckPlanAsync(int id);
    }
}
