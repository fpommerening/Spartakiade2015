using System;
using System.Linq;
using log4net;
using log4net.Core;
using Ninject.Extensions.Interception;

namespace FP.Spartakiade2015.ExceptionHandlingNinject.DAL
{
    public class WrapDALExceptionInterception : IInterceptor
    {
        private static ILog Logger = LogManager.GetLogger(typeof (WrapDALExceptionInterception));

        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
            }
            catch (Exception exception)
            {
                Logger.Error(string.Format("DAL error in method {0} Arguments {1}", invocation.Request.Method.Name,
                    string.Join(";", invocation.Request.Arguments.Select(x => x.ToString()).ToArray())), exception);
                throw new DALException(invocation.Request.Method.Name, exception, invocation.Request.Arguments);
            }
        }
    }
}
