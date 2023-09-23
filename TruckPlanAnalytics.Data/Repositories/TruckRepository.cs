using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Models;
using TruckPlanAnalytics.Data.Interface;

namespace TruckPlanAnalytics.Data.Repositories
{
    internal class TruckRepository : ITruckRepository
    {
        public async Task<Truck> GetByIdAsync(Guid truckId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Truck>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(Truck truck)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Truck truck)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid truckId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Truck>> GetTrucksByDriverIdAsync(Guid driverId)
        {
            throw new NotImplementedException();
        }
    }
}
