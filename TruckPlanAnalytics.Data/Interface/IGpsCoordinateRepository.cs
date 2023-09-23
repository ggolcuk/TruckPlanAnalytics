using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Models;

namespace TruckPlanAnalytics.Data.Interface;

internal interface IGpsCoordinateRepository
{
    Task<GpsCoordinate> GetByIdAsync(Guid coordinateId);
    Task<IEnumerable<GpsCoordinate>> GetAllAsync();
    Task CreateAsync(GpsCoordinate coordinate);
    Task UpdateAsync(GpsCoordinate coordinate);
    Task DeleteAsync(Guid coordinateId);
    Task<IEnumerable<GpsCoordinate>> GetCoordinatesByTruckPlanIdAsync(Guid planId);
    Task<IEnumerable<GpsCoordinate>> GetCoordinatesByDateRangeAsync(DateTime startDate, DateTime endDate);

}