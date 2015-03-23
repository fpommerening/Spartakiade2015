using System;
using System.Diagnostics;
using FP.Spartakiade2015.DurationNinject.DAL;
using log4net;
using Ninject;
using Ninject.Extensions.Interception;
using Ninject.Extensions.Interception.Infrastructure.Language;

namespace FP.Spartakiade2015.DurationNinject.ConsoleApp
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
                

                var interceptor = new ActionInterceptor(invocation =>
                {
                    var sw = new Stopwatch();
                    sw.Start();
                    try
                    {
                        invocation.Proceed();
                    }
                    finally
                    {
                        sw.Stop();
                        logger.DebugFormat("Die Ausführung der Methode {0} dauerte {1} ms",
                            invocation.Request.Method,
                            sw.ElapsedMilliseconds);
                    }
                });
                kernel.Bind<IUserRepository>().To<UserRepository>().Intercept()
                    .With(interceptor);

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
