using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckPlanAnalytics.Core.Models;

namespace TruckPlanAnalytics.Core.Interfaces
{
    internal interface IDriverService
    {
        Task<Driver> CreateDriverAsync(string name, DateTime birthDate);
        Task<Driver> GetDriverByIdAsync(int id);
        Task UpdateDriverAsync(Driver driver);
        Task DeleteDriverAsync(int id);
        Task<IEnumerable<Driver>> GetAllDriversOverAge(int age);
        Task<IEnumerable<Driver>> GetAllDriversOverLicense(LicenseType license);
    }
}
