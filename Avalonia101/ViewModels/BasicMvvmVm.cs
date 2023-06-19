using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ReactiveUI;

namespace Avalonia101.ViewModels;
#pragma warning disable
public class BasicMvvmVm : INotifyPropertyChanged
{
    #region Properties

    private string? _Name; // This is our backing field for Name

    public string? Name
    {
        get { return _Name; }
        set
        {
            // We only want to update the UI if the Name actually changed, so we check if the value is actually new
            if (_Name != value)
            {
                // 1. update our backing field
                _Name = value;

                // 2. We call RaisePropertyChanged() to notify the UI about changes.
                // We can omit the property name here because [CallerMemberName] will provide it for us.
                RaisePropertyChanged();

                // 3. Greeting also changed. So let's notify the UI about it.
                RaisePropertyChanged(nameof(Greeting));
            }
        }
    }

// Greeting will change based on a Name.
    public string Greeting
    {
        get
        {
            if (string.IsNullOrEmpty(Name))
            {
                // If no Name is provided, use a default Greeting
                return "Hello World from Avalonia.Samples";
            }
            else
            {
                // else greet the User.
                return $"Hello {Name}";
            }
        }
    }

    void dik()
    {
        Console.WriteLine("dik");
    }

    private ICommand command { get; }

    public BasicMvvmVm()
    {
        // We can use the command to update the Name.
    }

    #endregion


    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    private void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion


    #region ReasctiveUI

    public event PropertyChangingEventHandler? PropertyChanging;

    public void RaisePropertyChanging(PropertyChangingEventArgs args)
    {
        throw new NotImplementedException();
    }

    public void RaisePropertyChanged(PropertyChangedEventArgs args)
    {
        throw new NotImplementedException();
    }

    #endregion
}