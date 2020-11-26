using System;
using System.Collections.Generic;
using System.Linq;
using BakeryApplication.Common;

namespace BakeryApplication.Helpers
{
    public static class DoublesHelper
    {
        /// <summary>
        /// Using the Coin Changing Algorithm, we can calculate which numbers will make the resulting target
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <param name="partial"></param>
        public static IEnumerable<double> GetCombinationAlgorithm(double[] set, int sum)
        {
            for (int i = 0; i < set.Length; i++)
            {
                int left = sum - (int)set[i];
                int valueItems = (int)set[i];
                if (left == 0)
                    yield return valueItems;
                else
                {
                    double[] possible = set.Take(i).Where(n => n <= sum).ToArray();
                    if (possible.Length > 0)
                    {
                        foreach (int s in GetCombinationAlgorithm(possible, left))
                        {
                            yield return s;
                        }
                    }
                }
            }
        }

        public static double GetCostOfProduceType(this double itemValue, ProduceType produce)
        {
            if (produce == ProduceType.BlueberryMuffin)
            {
                if (itemValue == 2)
                    return ProduceHelper.Get_ProduceMB11_2Pack();
                else if (itemValue == 5)
                    return ProduceHelper.Get_ProduceMB11_5Pack();
                else if (itemValue == 8)
                    return ProduceHelper.Get_ProduceMB11_5Pack();
            }
            else if (produce == ProduceType.Croissant)
            {
                if (itemValue == 3)
                    return ProduceHelper.Get_ProduceCF_3Pack();
                else if (itemValue == 5)
                    return ProduceHelper.Get_ProduceCF_5Pack();
                else if (itemValue == 9)
                    return ProduceHelper.Get_ProduceCF_9Pack();
            }
            else if (produce == ProduceType.VegemiteScroll)
            {
                if (itemValue == 3)
                    return ProduceHelper.Get_ProduceVS5_3Pack();
                else if (itemValue == 5)
                    return ProduceHelper.Get_ProduceVS5_5Pack();
            }

            throw new ArgumentNullException($"Could not find specified value for {produce.GetType()} type");
        }

        public static double GetBestCombinationOfMaxValues(this IEnumerable<double> itemValues, int targetValue)
        {

            //Get the best combination of values that will reach the maximum target value

            throw new ArgumentNullException($"Could not find specified value for {produce.GetType()} type");
        }

        //Components for each Produce
        public static double[] Vs5Components() => new double[] { 3, 5 };
        public static double[] CFComponents() => new double[] { 3, 5, 9 };
        public static double[] MB11Components() => new double[] { 2, 5, 8 };
    }
}
