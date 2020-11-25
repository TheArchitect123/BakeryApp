using System;
using BakeryApplication.Models;

namespace BakeryApplication.Services
{
    //For Seeding Test Data
    public class SeedDataService
    {
        private readonly SqliteDataService _dataService;
        public SeedDataService(SqliteDataService dataService)
        {
            _dataService = dataService;
        }

        private void SeedAttemptsData()
        {

        }

        private void SeedProduceData()
        {

        }
    }
}
