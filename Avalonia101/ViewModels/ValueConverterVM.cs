using ReactiveUI;

namespace Avalonia101.ViewModels;

public class ValueConverterVM : ViewModelBase
{
    // The initial value is 2.
    private double? _Number1 = 2;

    /// <summary>
    /// This is our Number 1
    /// </summary>
    public double? Number1
    {
        get { return _Number1; }
        set { this.RaiseAndSetIfChanged(ref _Number1, value); }
    }
}