using System;
using FP.Spartakiade2015.WebserviceCache.Contracts;

namespace FP.Spartakiade2015.WebserviceCache.BL
{
    public class BusinessLayer
    {
        public BOCustomer GetCustomerInfo(string name, string firstName, string street, string zipCode)
        {
            System.Threading.Thread.Sleep(1500);
            return new BOCustomer
            {
                Id = 42,
                City = "Musterhausen",
                FirstName = firstName,
                Name = name,
                Street = street,
                Title = Title.Herr,
                ZipCode = zipCode,
                ReliabilityIndex = CalculateReliabilityIndex(42)
            };
            
        }

        private decimal CalculateReliabilityIndex(int customerId)
        {
            System.Threading.Thread.Sleep(1500);
            return 97.2m;
        }
    }
}
