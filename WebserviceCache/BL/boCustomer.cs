using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP.Spartakiade2015.WebserviceCache.Contracts;

namespace FP.Spartakiade2015.WebserviceCache.BL
{
    public class BOCustomer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Name { get; set; }

        public Title Title { get; set; }

        public string Street { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public decimal ReliabilityIndex { get; set; }
    }
}
