using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Models;

namespace TruckPlanAnalytics.Data.Interface;

internal interface IDriverRepository
{
    Task<Driver> GetByIdAsync(Guid driverId);
    Task<IEnumerable<Driver>> GetAllAsync();
    Task CreateAsync(Driver driver);
    Task UpdateAsync(Driver driver);
    Task DeleteAsync(Guid driverId);
    Task<IEnumerable<Driver>> GetDriversByAgeAsync(int age);
}