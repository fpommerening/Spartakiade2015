using System;
using System.Linq;
using log4net;
using PostSharp.Aspects;

namespace FP.Spartakiade2015.ExceptionHandlingPostSharp.DAL
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Assembly| AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, Inherited = true)]
    public class WrapDALExceptionAspect : OnExceptionAspect
    {
        [NonSerializedAttribute]
        private static ILog Logger = LogManager.GetLogger(typeof(WrapDALExceptionAspect));

        public override void OnException(MethodExecutionArgs args)
        {
            Logger.Error(string.Format("DAL error in method {0} Arguments {1}", args.Method.Name,
            string.Join(";", args.Arguments.Select(x => x.ToString()).ToArray())), args.Exception);
            throw new DALException(args.Method.Name, args.Exception,args.Arguments.ToArray());
        }
    }
}
