using System;
using static System.Console;
using BakeryApplication.Services;

namespace BakeryApplication.ViewModels
{
    //Business Logic Component that contains the API used for calculating each of the produce, then persisting it into the database
    public sealed class ProduceInputOutputViewModel : BaseViewModel
    {
        private readonly SqliteDataService _dataService;
        public ProduceInputOutputViewModel(SqliteDataService dataService)
        {
            _dataService = dataService;
        }

        public void TestMethod()
        {
            WriteLine("Test Method Success");
        }
    }
}
