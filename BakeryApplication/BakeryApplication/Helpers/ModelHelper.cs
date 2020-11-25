using System;
using BakeryApplication.Common;
using BakeryApplication.Models;

namespace BakeryApplication.Helpers
{
    public class ModelHelper
    {
        
        public static Attempts generateAttemptItem(int largestAttempt)
        {
            Attempts attemptItem = new Attempts();
            attemptItem.AttemptNumber = largestAttempt++;

            attemptItem.RecordCreation = DateTime.Now;
            return attemptItem;
        }

        public static Produce generateProduceItem(ProduceType produce)
        {
            Produce produceItem = new Produce();
            produceItem.RecordCreation = DateTime.Now;
            if(produce == ProduceType.BlueberryMuffin)
            {
                produceItem.CostOfEach = "";
                produceItem.NameOfProduct = "";
            }
            else if (produce == ProduceType.VegemiteScroll)
            {

            }
            else if (produce == ProduceType.Croissant)
            {

            }
            return produceItem;
        }
    }
}
