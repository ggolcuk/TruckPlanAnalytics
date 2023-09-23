using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Models;
using TruckPlanAnalytics.Data.Interface;

namespace TruckPlanAnalytics.Data.Repositories
{
    internal class DriverRepository : IDriverRepository
    {
        public Task<Driver> GetByIdAsync(Guid driverId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Driver>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Driver driver)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Driver driver)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid driverId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Driver>> GetDriversByAgeAsync(int age)
        {
            throw new NotImplementedException();
        }
    }
}
