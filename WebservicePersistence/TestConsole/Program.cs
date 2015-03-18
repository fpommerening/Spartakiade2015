using System;


namespace FP.Spartakiade2015.WebservicePersistence.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (BookCapacityService client = new BookCapacityService { Url = "http://localhost:49874/EnergyService.asmx" })
                {
                    
                    var request = new BookCapacityRequestType
                    {
                        Customer = "Frank Pommerening",
                        MessageIdentifier = Guid.NewGuid().ToString("D"),
                        Quantity = 5000,
                        Unit = CapacityUnit.KWh,
                        ValidFrom = DateTime.Now.AddDays(1),
                        ValidTo = DateTime.Now.AddMonths(1).AddDays(1)
                    };
                    Console.WriteLine("Starte Kapazitätsanfrage");
                    var result = client.BookCapacity(request);
                    Console.WriteLine("{0}: {1} {2}", result.MessageIdentifier, result.Quantity, result.Unit);
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
