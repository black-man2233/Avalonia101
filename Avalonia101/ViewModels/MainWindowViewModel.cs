namespace Avalonia101.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    // Add our SimpleViewModel.
// Note: We need at least a get-accessor for our Properties.
    public BassicMvvmVM BassicMvvmVm { get; } = new BassicMvvmVM();
    public CommandsVM Commands { get; set; } = new();
}