using System;
using FP.Spartakiade2015.ExceptionHandlingNinject.BL;
using FP.Spartakiade2015.ExceptionHandlingNinject.DAL;
using Ninject;

namespace FP.Spartakiade2015.ExceptionHandlingNinject.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            try
            {
                UserMappings mappings = new UserMappings();
                mappings.CreateMapping();

                IKernel kernel = new StandardKernel();
                kernel.Bind<IUserRepository>().To<UserRepository>();

                BusinessLayer businessLayer = kernel.Get<BusinessLayer>();
                

                for (int i = 1; i < 4; i++)
                {
                    var user = businessLayer.GetUserById(i);
                    if (user == null)
                    {
                        Console.WriteLine("Benutzer mit ID {0} wurde nicht gefunden", i);
                    }
                    else
                    {
                        Console.WriteLine("Benutzer mit ID {0} gefunden ({1} {2})", i, user.FirstName, user.Name);
                    }
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
