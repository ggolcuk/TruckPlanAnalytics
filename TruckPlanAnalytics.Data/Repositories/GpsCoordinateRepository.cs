using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Models;
using TruckPlanAnalytics.Data.Interface;

namespace TruckPlanAnalytics.Data.Repositories
{
    internal class GpsCoordinateRepository : IGpsCoordinateRepository
    {
        public Task<GpsCoordinate> GetByIdAsync(Guid coordinateId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GpsCoordinate>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(GpsCoordinate coordinate)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(GpsCoordinate coordinate)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid coordinateId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GpsCoordinate>> GetCoordinatesByTruckPlanIdAsync(Guid planId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GpsCoordinate>> GetCoordinatesByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
