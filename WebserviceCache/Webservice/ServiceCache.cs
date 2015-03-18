using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FP.Spartakiade2015.WebserviceCache.Webservice
{
    public static class ServiceCache
    {
        private static readonly List<ServiceCacheItem> Items = new List<ServiceCacheItem>();

        private static readonly object syncRoot = new object();

        private static bool  cleanUpRunning;

        public static object GetItem(string methodHash, string parameterHashCode)
        {
            ServiceCacheItem cachedItem;

            lock (syncRoot)
            {
                cachedItem = Items.FirstOrDefault(x => x.MethodHash == methodHash && x.SerializedParameter == parameterHashCode &&
                     x.UseUntilTimestamp > DateTime.Now);
            }
            
           
            return cachedItem == null ? null : cachedItem.Value;
        }

        public static void AddItem(string methodName, string serializedParameter, object value, TimeSpan cacheTimespan)
        {
            var item = new ServiceCacheItem
            {
                MethodHash = methodName,
                SerializedParameter = serializedParameter,
                UseUntilTimestamp = DateTime.Now.Add(cacheTimespan),
                Value = value
            };
            lock (syncRoot)
            {
                Items.Add(item);
            }
            CleanUp();
        }

        private static void CleanUp()
        {
            if (cleanUpRunning) return;

            cleanUpRunning = true;
            Task.Factory.StartNew(() =>
            {
                while (Items.Any())
                {
                    lock (syncRoot)
                    {
                        Items.RemoveAll(x => x.UseUntilTimestamp < DateTime.Now);
                        System.Threading.Thread.Sleep(1000);
                    }
                }
                cleanUpRunning = false;
            });
        }
    }
}
