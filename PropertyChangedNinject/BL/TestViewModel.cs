using System;

namespace FP.Spartakiade2015.PropertyChangedNinject.BL
{
    public class TestViewModel : BaseViewModel
    {
        public String Name { get; set; }

        public String FirstName { get; set; }

        public String Street { get; set; }

        public String ZipCode { get; set; }
        
        public string City { get; set; }
    }
}
