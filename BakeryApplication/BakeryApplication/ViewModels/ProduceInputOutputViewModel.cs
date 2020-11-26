﻿using System;
using static System.Console;
using System.Linq;
using BakeryApplication.Common;
using BakeryApplication.Helpers;
using BakeryApplication.Services;
using System.Collections.Generic;

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
                    WriteLine($"{targetPackages} MB11 {GetCostOfPackages(produceType, targetPackages, DoublesHelper.MB11Components())}");
                    WriteLine($"{targetPackages}");

                    break;
                case ProduceType.VegemiteScroll:
                    WriteLine($"{targetPackages} VS5 {GetCostOfPackages(produceType, targetPackages, DoublesHelper.Vs5Components())}");
                    WriteLine($"{targetPackages}");
                    break;
                case ProduceType.Croissant:
                    WriteLine($"{targetPackages} CF {GetCostOfPackages(produceType, targetPackages, DoublesHelper.CFComponents())}");
                    WriteLine($"{targetPackages}");

                    break;
            }
        }

        private string GetCostOfPackages(ProduceType produceType, int targetPackages, double[] components)
        {
            List<double> foodCombos = new List<double>();
            DoublesHelper.GetCombinationAlgorithm(targetPackages, ref foodCombos);
            if ((foodCombos = foodCombos.Intersect(components).ToList()).Count() != 0)
            {
                //Get Total cost of Blueberry Muffin
                if (produceType == ProduceType.BlueberryMuffin)
                {
                    double costOfValues = 0;
                    foreach (var cost in foodCombos)
                        costOfValues += cost.GetCostOfProduceType(produceType);

                    return $"${costOfValues}";
                }

                //Get Total Cost of Croissant
                else if (produceType == ProduceType.Croissant)
                {
                    double costOfValues = 0;
                    foreach (var cost in foodCombos)
                        costOfValues += cost.GetCostOfProduceType(produceType);

                    return $"${costOfValues}";
                }

                //Get Total Cost of Vegimite Scroll
                else if (produceType == ProduceType.VegemiteScroll)
                {
                    //Vegmite Scroll 
                    double costOfValues = 0;
                    foreach (var cost in foodCombos)
                        costOfValues += cost.GetCostOfProduceType(produceType);

                    return $"${costOfValues}";
                }
            }

            return "";
        }

        //private string GetItemsIntersectedByTarget()
        //{

        //}
        
    }
}
