using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Models;

namespace TruckPlanAnalytics.Core.Interfaces
{
    public interface IDistanceService
    {
        /// <summary>
        /// Calculate distance between 2 gps coordinates on premise
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        double CalculateDistanceBetweenCoordinates(GpsCoordinate start, GpsCoordinate end);
        /// <summary>
        /// External service to calculate distance between 2 gps coordinates on premise
        /// Reverse geocoding service
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        Task<double> FetchRealDistanceBetweenCoordinatesAsync(GpsCoordinate start, GpsCoordinate end);
        /// <summary>
        /// External service to calculate distance between 2 gps coordinates based on the most likely route on map
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        Task<double> FetchMostLikelyPathDistanceAsync(GpsCoordinate start, GpsCoordinate end);
    }
}
