using System;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Interfaces;
using TruckPlanAnalytics.Core.Models;
using Geolocation;

namespace TruckPlanAnalytics.Services
{
    public class DistanceWebServiceClient: IDistanceService
    {
        public double CalculateDistanceBetweenCoordinates(GpsCoordinate start, GpsCoordinate end)
        {
            return Geolocation.GeoCalculator.GetDistance(start.Coordinate, end.Coordinate,
                distanceUnit: DistanceUnit.Kilometers);

        }

        public Task<double> FetchRealDistanceBetweenCoordinatesAsync(GpsCoordinate start, GpsCoordinate end)
        {
            throw new System.NotImplementedException();
        }

        public Task<double> FetchMostLikelyPathDistanceAsync(GpsCoordinate start, GpsCoordinate end)
        {
            throw new System.NotImplementedException();
        }
    }
}