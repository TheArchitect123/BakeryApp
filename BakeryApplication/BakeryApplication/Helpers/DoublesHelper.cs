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
        public static void GetCombinationAlgorithm(int sum, ref List<double> items)
        {
             DetermineCombinations(sum, ref items);
        }

        static void DetermineCombinationUtils(int[] arr, int index,
                                 int num, int reducedNum, ref List<double> items)
        {
            if (reducedNum < 0)
                return;
            if (reducedNum == 0)
            {
                for (int i = 0; i < index; i++)
                    items.AddRange(arr.ToList().ConvertAll(w => Convert.ToDouble(w)));
            }

            int prev = (index == 0) ? 1 : arr[index - 1];
            try
            {
                for (int k = prev; k <= num; k++)
                {
                    arr[index] = k;
                    DetermineCombinationUtils(arr, index + 1, num,
                                             reducedNum - k, ref items);
                }
            }
            catch
            {
                DetermineCombinationUtils(arr, index + 1, num,
                                             reducedNum - prev, ref items);
            }
        }

        static void DetermineCombinations(int n, ref List<double> items)
        {
            int[] arr = new int[n];
            DetermineCombinationUtils(arr, 0, n, n, ref items);
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

        //Components for each Produce
        public static double[] Vs5Components() => new double[] { 3, 5 };
        public static double[] CFComponents() => new double[] { 3, 5, 9 };
        public static double[] MB11Components() => new double[] { 2, 5, 8 };
    }
}
