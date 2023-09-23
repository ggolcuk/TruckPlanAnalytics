using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Models;
using TruckPlanAnalytics.Data.Context;
using TruckPlanAnalytics.Data.Interface;

namespace TruckPlanAnalytics.Data.Repositories
{
    internal class TruckPlanRepository : ITruckPlanRepository
    {

        private readonly TruckPlanDbContext _dbContext;

        public TruckPlanRepository(TruckPlanDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }


        public async Task<TruckPlan> GetByIdAsync(Guid planId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TruckPlan>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(TruckPlan plan)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(TruckPlan plan)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid planId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TruckPlan>> GetPlansByDriverIdAsync(Guid driverId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TruckPlan>> GetPlansByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public async Task<double> GetTotalDistanceDrivenByDriversByAgeCountryDate(DateTime targetDate, int countryCode,
            int age,
            int timeSpanYear, int timeSpanMonth, int timeSpanDay)
        {
            // target span 1 month
            // Startdate 2018 february
            var endDate = targetDate.AddMonths(timeSpanMonth);
             endDate = targetDate.AddYears(timeSpanYear);
             endDate = targetDate.AddDays(timeSpanDay);

            var distances =  await _dbContext.TruckPlans
                .Include(tp => tp.Driver)
                .Include(tp => tp.GpsCoordinates)
                .Include(tp =>
                    tp.DistancesPerCountry) // Including this based on the final summing you've done on DistancesPerCountry
                .Where(tp => tp.Driver.Birthdate <= targetDate.AddYears(-age)) // Drivers over the age of 50
                .Where(tp => tp.Status == Status.Completed) //Consider completed truckplans
                .Where(tp => tp.EndDateTime >= targetDate && tp.EndDateTime < endDate) // Truck plans for February 2018 
                .SelectMany(tp => tp.DistancesPerCountry
                    .Where(dpc => dpc.CountryCode == countryCode)
                    .Select(dpc => dpc.Distance))
                .ToListAsync(); // Total kilometers in Germany

            return distances.DefaultIfEmpty(0).Sum(); 
        }
    }




}
