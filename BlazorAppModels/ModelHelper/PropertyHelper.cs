using BlazorAppModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppModels.ModelHelper
{
    public class PropertyHelper
    {
        public decimal CalculationCurrentValue(Property property)
        {
            int periodLength = GetPeriodLengthInDays(property.DepreciationPeriod);
            int ownershipDays = (int)(DateTime.Now - property.PurchaseDateTime).TotalDays;
            int periodCount = ownershipDays / periodLength;

            return property.InitialValue - (property.DepreciationValue * periodCount);
        }
        private int GetPeriodLengthInDays(string period)
        {
            switch (period.ToLower())
            {
                case "день":
                    return 1;
                case "тиждень":
                    return 7;
                case "місяць":
                    return 30;
                case "рік":
                    return 365;
                default:
                    throw new ArgumentException("Невідомий період.");
            }
        }
    }
}
