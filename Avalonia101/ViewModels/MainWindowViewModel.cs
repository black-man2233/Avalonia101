namespace Avalonia101.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    // Add our SimpleViewModel.
// Note: We need at least a get-accessor for our Properties.
    public BasicMvvmVm BasicMvvmVm { get; } = new();
    public CommandSample Commands { get; set; } = new();
    public ValidationUsingDataAnnotationViewModel ValidationUsingDataAnnotationViewModel { get; set; } = new();
    
    /// <summary>
    /// Gets a ViewModel showing how to use INotifyDataErrorInfo for validation
    /// </summary>
    public ValidationUsingINotifyDataErrorInfoViewModel ValidationUsingINotifyDataErrorInfoViewModel { get; }
        = new();
    
}