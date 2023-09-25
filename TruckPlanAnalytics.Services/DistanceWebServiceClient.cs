using System;
using System.Collections.Generic;
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

        public double CalculateDistanceWithCoordinates(TruckPlan truckPlan)
        {
            double distance = 0;

            for (int i = 0; i < truckPlan.GpsCoordinates.Count - 1; i++)
            {
                distance += CalculateDistanceBetweenCoordinates(truckPlan.GpsCoordinates[i], truckPlan.GpsCoordinates[i+1])
            }

            return distance;
        }

        public Task<double> FetchRealDistanceBetweenCoordinatesAsync(GpsCoordinate start, GpsCoordinate end)
        {
            throw new System.NotImplementedException();
        }

        public Task<double> FetchMostLikelyPathDistanceAsync(TruckPlan truckPlan)
        {
            throw new System.NotImplementedException();
        }
    }
}