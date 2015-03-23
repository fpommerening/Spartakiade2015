using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;
using PostSharp.Aspects;

namespace FP.Spartakiade2015.DurationPostSharp.DAL
{
    [Serializable]
    public class DurationLoggingAspect : OnMethodBoundaryAspect
    {
        private static ILog logger = LogManager.GetLogger(typeof(DurationLoggingAspect));

        private static readonly Stopwatch Stopwatch = new Stopwatch();

        private string _fullMethodName = string.Empty;

        static DurationLoggingAspect()
        {
            Stopwatch.Start();
        }

        public override void CompileTimeInitialize(MethodBase method, AspectInfo aspectInfo)
        {
            base.CompileTimeInitialize(method, aspectInfo);
            _fullMethodName = string.Format("{0}.{1}", method.DeclaringType.FullName, method.Name);
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            args.MethodExecutionTag = Stopwatch.ElapsedMilliseconds;
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            var durationInMilliSeconds = Stopwatch.ElapsedMilliseconds - (long) args.MethodExecutionTag;
            logger.DebugFormat("Die Ausführung der Methode {0} dauerte {1} ms", _fullMethodName,
                TimeSpan.FromMilliseconds(durationInMilliSeconds).TotalMilliseconds);

        }
    }
}
