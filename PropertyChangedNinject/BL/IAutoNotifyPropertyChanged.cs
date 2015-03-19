using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FP.Spartakiade2015.PropertyChangedNinject.BL
{
    public interface IAutoNotifyPropertyChanged : INotifyPropertyChanged
    {
        void OnPropertyChanged([CallerMemberName] string propertyName = null);
    }
}
