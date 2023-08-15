using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace HSecond.Views;

public partial class NotePadWindow : Window
{
    public NotePadWindow()
    {
        InitializeComponent();
        WindowName();
    }

    private void WindowName()
    {
        this.Title = "Unavngivet - Notesblok";
    }
}