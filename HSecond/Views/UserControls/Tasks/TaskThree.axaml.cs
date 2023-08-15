using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace HSecond.Views.UserControls.Tasks;

public partial class TaskThree : UserControl
{
    public TaskThree()
    {
        InitializeComponent();
    }
    
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        NotePadWindow notepad = new();
        notepad.Show();
    }
}