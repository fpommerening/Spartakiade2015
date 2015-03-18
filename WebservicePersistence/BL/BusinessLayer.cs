using System;
using FP.Spartakiade2015.WebservicePersistence.Contracts;

namespace FP.Spartakiade2015.WebservicePersistence.BL
{
    public class BusinessLayer
    {
        public decimal CheckAvailableCapacity(string customer, DateTime validFrom, DateTime validTo, decimal quantity,
            CapacityUnit unit)
        {
            return quantity/2;
        }

    }
}
