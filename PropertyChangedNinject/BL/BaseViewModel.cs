using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FP.Spartakiade2015.PropertyChangedNinject.BL
{
    public abstract class BaseViewModel : IAutoNotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
