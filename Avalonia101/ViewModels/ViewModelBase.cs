using System.ComponentModel;
using ReactiveUI;

namespace Avalonia101.ViewModels;
#pragma warning disable
public class ViewModelBase : ReactiveObject
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public event PropertyChangingEventHandler? PropertyChanging;

    public void RaisePropertyChanging(PropertyChangingEventArgs args)
    {
        throw new System.NotImplementedException();
    }

    public void RaisePropertyChanged(PropertyChangedEventArgs args)
    {
        throw new System.NotImplementedException();
    }
}