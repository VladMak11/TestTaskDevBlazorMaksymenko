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
                case "day":
                    return 1;
                case "week":
                    return 7;
                case "mounth":
                    return 30;
                case "year":
                    return 365;
                default:
                    throw new ArgumentException("Невідомий період.");
            }
        }
    }
}
