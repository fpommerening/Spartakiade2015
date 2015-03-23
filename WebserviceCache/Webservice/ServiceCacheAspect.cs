using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Web.Script.Serialization;
using PostSharp.Aspects;

namespace FP.Spartakiade2015.WebserviceCache.Webservice
{
    [Serializable]
    public class ServiceCacheAspect : MethodInterceptionAspect
    {
        private string _methodHash = string.Empty;
        private TimeSpan _cacheTimeSpan;

        public ServiceCacheAspect(int cacheTimeSpanInSecond)
        {
            _cacheTimeSpan = TimeSpan.FromSeconds(cacheTimeSpanInSecond);
        }

        public override void CompileTimeInitialize(MethodBase method, AspectInfo aspectInfo)
        {
            var sb = new StringBuilder();
            if (method.DeclaringType != null)
            {
                sb.AppendFormat("{0}_", method.DeclaringType.FullName);
            }
            sb.Append(method.Name);
            foreach (var param in method.GetParameters())
            {
                if (param != null)
                {
                    sb.AppendFormat("_{0}", param.Name);
                }
            }
            _methodHash = CalculateMd5Hash(sb.ToString());

            base.CompileTimeInitialize(method, aspectInfo);
        }

        public override void OnInvoke(MethodInterceptionArgs args)
        {
            var serializedParameter = GetSerializedArguments(args.Arguments);
            var cachedValue = ServiceCache.GetItem(_methodHash, serializedParameter);
            if (cachedValue != null)
            {
                args.ReturnValue = cachedValue;
            }
            else
            {
                base.OnInvoke(args);
                ServiceCache.AddItem(_methodHash, serializedParameter, args.ReturnValue, _cacheTimeSpan);
            }
        }

        private string GetSerializedArguments(IEnumerable<object> arguments)
        {
            var json = new JavaScriptSerializer();
            return string.Join("_", arguments.Select(json.Serialize).ToArray());

        }

        private static string CalculateMd5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);


            var sb = new StringBuilder();
            foreach (byte t in hash)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
