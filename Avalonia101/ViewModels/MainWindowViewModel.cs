namespace Avalonia101.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    // Add our SimpleViewModel.
// Note: We need at least a get-accessor for our Properties.
    public SimpleViewModel SimpleViewModel { get; } = new SimpleViewModel();
    public CommandsViewModel Commands { get; set; } = new();
}