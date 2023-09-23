using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Models;

namespace TruckPlanAnalytics.Core.Interfaces
{
    public interface IGpsCoordinateService
    {
        /// <summary>
        /// Record the gathered GPS coordinate to the related truck plan
        /// </summary>
        /// <param name="plan"></param>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        Task RecordCoordinateForTruckPlanAsync(TruckPlan plan, GpsCoordinate coordinate);
        /// <summary>
        /// Returns GPS coordinates of the truck plan
        /// </summary>
        /// <param name="plan"></param>
        /// <returns></returns>
        Task<IEnumerable<GpsCoordinate>> GetCoordinatesForTruckPlanAsync(TruckPlan plan);
    }
}
