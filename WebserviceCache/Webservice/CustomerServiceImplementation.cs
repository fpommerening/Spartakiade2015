using System;
using FP.Spartakiade2015.WebserviceCache.BL;
using FP.Spartakiade2015.WebserviceCache.Contracts;

namespace FP.Spartakiade2015.WebserviceCache.Webservice
{
    public class CustomerServiceImplementation : ICustomerInfo_Binding
    {
        public CustomerInfoResponseType CustomerInfo(CustomerInfoRequestType request)
        {
            var bl = new BusinessLayer();
            var bo = bl.GetCustomerInfo(request.Name, request.FirstName, request.Street, request.ZipCode);

            return new CustomerInfoResponseType
            {
                CustomerId = bo.Id,
                FirstName = bo.FirstName,
                Name = bo.Name,
                ReliabilityIndex = bo.ReliabilityIndex,
                Street = bo.Street,
                Title = bo.Title,
                ZipCode = bo.ZipCode
            };
        }
    }
}