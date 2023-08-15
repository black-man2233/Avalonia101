using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using HSecond.Views.UserControls;
using Microsoft.VisualBasic;

namespace HSecond.Views;
#pragma warning disable
// Partial class for the MainWindow, which is derived from the Window class.
public partial class MainWindow : Window
{
    // Constructor for the MainWindow.
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        NotePadWindow notepad = new();
        notepad.Show();
    }
}