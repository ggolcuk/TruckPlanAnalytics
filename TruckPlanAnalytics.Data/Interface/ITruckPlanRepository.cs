using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Models;

namespace TruckPlanAnalytics.Data.Interface;

internal interface ITruckPlanRepository
{
    Task<TruckPlan> GetByIdAsync(Guid planId);
    Task<IEnumerable<TruckPlan>> GetAllAsync();
    Task CreateAsync(TruckPlan plan);
    Task UpdateAsync(TruckPlan plan);
    Task DeleteAsync(Guid planId);
    Task<IEnumerable<TruckPlan>> GetPlansByDriverIdAsync(Guid driverId);
    Task<IEnumerable<TruckPlan>> GetPlansByDateRangeAsync(DateTime startDate, DateTime endDate);
    Task<double> GetTotalDistanceDrivenByDriversByAgeCountryDate(DateTime targetDate, int countryCode, int age,
        int timeSpanYear = 0, int timeSpanMonth = 0, int timeSpanDay = 0);
}