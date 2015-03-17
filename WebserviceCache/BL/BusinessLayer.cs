using System;
using FP.Spartakiade2015.WebserviceCache.Contracts;

namespace FP.Spartakiade2015.WebserviceCache.BL
{
    public class BusinessLayer
    {
        public decimal CheckAvailableCapacity(string customer, DateTime validFrom, DateTime validTo, decimal quantity,
            CapacityUnit unit)
        {
            System.Threading.Thread.Sleep(1500);
            return quantity/2;
        }

    }
}
