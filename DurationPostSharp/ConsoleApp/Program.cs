using System;
using FP.Spartakiade2015.DurationPostSharp.DAL;
using log4net;
using Ninject;

namespace FP.Spartakiade2015.DurationPostSharp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(typeof (Program));

            try
            {
                IKernel kernel = new StandardKernel();
                kernel.Bind<IUserRepository>().To<UserRepository>();

                IUserRepository userRepo = kernel.Get<IUserRepository>();

                foreach (var user in userRepo.GetAllUsers())
                {
                    Console.WriteLine("{0}:\t {1} {2}", user.Id, user.FirstName, user.Name);
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
