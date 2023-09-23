using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Models;

namespace TruckPlanAnalytics.Data.Interface;

internal interface ITruckRepository
{
    Task<Truck> GetByIdAsync(Guid truckId);
    Task<IEnumerable<Truck>> GetAllAsync();
    Task CreateAsync(Truck truck);
    Task UpdateAsync(Truck truck);
    Task DeleteAsync(Guid truckId);
    Task<IEnumerable<Truck>> GetTrucksByDriverIdAsync(Guid driverId);


}