using System;
using System.ComponentModel;
using FP.Spartakiade2015.PropertyChangedNinject.BL;

namespace FP.Spartakiade2015.PropertyChangedNinject.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var viewModel = new TestViewModel();
                viewModel.PropertyChanged += ViewModelOnPropertyChanged;
                viewModel.Name = "Mustermann";
                viewModel.FirstName = "Max";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            Console.WriteLine("Programmende");
            Console.ReadLine();
        }

        private static void ViewModelOnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            Console.WriteLine("PropertyChanged für {0} ausgelöst", args.PropertyName);
        }
    }
}
