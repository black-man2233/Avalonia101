using System;
using Avalonia.Controls;
using Microsoft.VisualBasic;

namespace HSecond.Views;
#pragma warning disable
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void CbSectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (sender is ComboBox cb)
        {
            ComboBoxItem item = (ComboBoxItem)cb.SelectedItem;

            switch (item.Content)
            {
                case "EUR":
                    Currency.Text = (100 * 7.43).ToString();
                    break;
                case "USD":
                    Currency.Text = (100 * 6.76).ToString();
                    break;
                case "DKK":
                    Currency.Text = "100";
                    break;
            }
        }
    }

    private void ChangeWindowName(object? sender, SelectionChangedEventArgs e)
    {
        if (sender is ComboBox cb)
        {
            string selectedWord = ((ComboBoxItem)cb.SelectedItem).Content.ToString();

            ThisWindow.Title = selectedWord;
        }
    }

    private void SDateChange(object? sender, SelectionChangedEventArgs e)
    {
        if (sender is Calendar cl)
        {
            DateTime date = (DateTime)cl.SelectedDate;
            if (date.Day is 5)
            {
                cl.IsVisible = false;
            }
        }
    }

    private void SizeUp(object? sender, TextChangedEventArgs e)
    {
        if (sender is TextBox tb)
        {
            try
            {
                tb.FontSize = int.Parse(tb.Text) * 10;
                Ccalender.IsVisible = true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}