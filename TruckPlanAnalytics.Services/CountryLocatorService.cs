using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Interfaces;
using TruckPlanAnalytics.Core.Models;

namespace TruckPlanAnalytics.Services
{
    internal class CountryLocatorService : ICountryLocatorService
    {
        public Task<string> GetCountryFromCoordinateAsync(GpsCoordinate coordinate)
        {
            throw new System.NotImplementedException();
        }
    }
}
