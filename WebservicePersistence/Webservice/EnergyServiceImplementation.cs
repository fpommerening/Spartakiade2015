using System;
using FP.Spartakiade2015.WebservicePersistence.BL;
using FP.Spartakiade2015.WebservicePersistence.Contracts;

namespace FP.Spartakiade2015.WebserviceCache.Webservice
{
    public class EnergyServiceImplementation : IBookCapacity_Binding
    {
        public BookCapacityResponseType BookCapacity(BookCapacityRequestType request)
        {
            var BL = new BusinessLayer();
            var freeCapacity = BL.CheckAvailableCapacity(request.Customer, request.ValidFrom, request.ValidTo,
                request.Quantity, request.Unit);
            return new BookCapacityResponseType
            {
                MessageIdentifier = request.MessageIdentifier,
                Quantity = freeCapacity,
                Unit = request.Unit
            };
        }
    }
}