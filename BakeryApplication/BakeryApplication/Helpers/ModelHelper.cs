using System;
using BakeryApplication.Common;
using BakeryApplication.Models;

namespace BakeryApplication.Helpers
{
    public class ModelHelper
    { 
        public static Attempts generateAttemptItem()
        {
            Attempts attemptItem = new Attempts();
            attemptItem.RecordCreation = DateTime.Now;
            return attemptItem;
        }
    }
}
