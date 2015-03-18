using System;

namespace FP.Spartakiade2015.WebserviceCache.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (CustomerInfoService client = new CustomerInfoService { Url = "http://localhost:49145/CustomerService.asmx" })
                {

                    var request = new CustomerInfoRequestType
                    {
                        FirstName = "Max",
                        Name = "Mustermann",
                        Street = "Teststraße",
                        ZipCode = "12345"
                    };
                    Console.WriteLine("Starte Kundenabfrage");
                    var result = client.CustomerInfo(request);
                    Console.WriteLine("{0}: {1} {2} {3}", result.CustomerId, result.FirstName, result.Name, result.ReliabilityIndex);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            Console.ReadLine();
        }
    }
}
