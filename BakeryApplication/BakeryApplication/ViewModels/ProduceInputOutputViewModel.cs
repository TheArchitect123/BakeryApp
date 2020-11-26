using System;
using System.Linq;
using BakeryApplication.Common;
using BakeryApplication.Helpers;
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

        public void ProcessRequest(ProduceType produceType, int targetPackages)
        {
            switch (produceType)
            {
                case ProduceType.BlueberryMuffin:
                    Console.WriteLine($"{targetPackages} MB11 ${GetCostOfPackages(produceType, targetPackages, DoublesHelper.MB11Components())}");
                    Console.WriteLine($"{targetPackages}");

                    break;
                case ProduceType.VegemiteScroll:
                    Console.WriteLine($"{targetPackages} VS5 ${GetCostOfPackages(produceType, targetPackages, DoublesHelper.Vs5Components())}");
                    Console.WriteLine($"{targetPackages}");
                    break;
                case ProduceType.Croissant:
                    Console.WriteLine($"{targetPackages} CF ${GetCostOfPackages(produceType, targetPackages, DoublesHelper.CFComponents())}");
                    Console.WriteLine($"{targetPackages}");

                    break;
            }
        }

        private string GetCostOfPackages(ProduceType produceType, int targetPackages, double[] components)
        {
            var foodCombos = DoublesHelper.GetCombinationAlgorithm(components, targetPackages).Intersect(components);
            if (foodCombos.Count() != 0)
            {
                //Get Total cost of Blueberry Muffin
                if (produceType == ProduceType.BlueberryMuffin)
                {
                    double costOfValues = 0;
                    foreach (var cost in foodCombos)
                        costOfValues += cost.getCostOfProduceType(produceType);

                    return $"${costOfValues}";
                }

                //Get Total Cost of Croissant
                else if (produceType == ProduceType.Croissant)
                {
                    double costOfValues = 0;
                    foreach (var cost in foodCombos)
                        costOfValues += cost.getCostOfProduceType(produceType);

                    return $"${costOfValues}";
                }

                //Get Total Cost of Vegimite Scroll
                else if (produceType == ProduceType.VegemiteScroll)
                {
                    //Vegmite Scroll 
                    double costOfValues = 0;
                    foreach (var cost in foodCombos)
                        costOfValues += cost.getCostOfProduceType(produceType);

                    return $"${costOfValues}";
                }
            }

            return "";
        }

        
    }
}
