using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Models;

namespace TruckPlanAnalytics.Core.Interfaces
{
    public interface ICountryLocatorService
    {
        /// <summary>
        /// External service (third party or internal) to get country code from the the gps coordinates
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        Task<string> GetCountryFromCoordinateAsync(GpsCoordinate coordinate);
    }
}
