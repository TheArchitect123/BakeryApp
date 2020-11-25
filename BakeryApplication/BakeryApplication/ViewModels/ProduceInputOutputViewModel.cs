using System;
using static System.Console;
using BakeryApplication.Services;
using BakeryApplication.Common;

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

        public void ProcessRequest(ProduceType produceType)
        {
            switch (produceType)
            {
                case ProduceType.BlueberryMuffin:
                    break;
                case ProduceType.VegemiteScroll:
                    break;
                case ProduceType.Croissant:
                    break;
            }

        }
    }
}
