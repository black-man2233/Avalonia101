using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Layout;
using HSecond.Views.UserControls;
using Microsoft.VisualBasic;

namespace HSecond.Views
{
    #pragma warning disable
    // Partial class for the MainWindow, which is derived from the Window class.
    public partial class MainWindow : Window
    {
        // Constructor for the MainWindow.
        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler for ComboBox selection change related to currency.
        private void CbSectionChanged(object? sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox cb)
            {
                ComboBoxItem item = (ComboBoxItem)cb.SelectedItem;

                // Calculate and display currency based on selected item.
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

        // Event handler for ComboBox selection change related to window title.
        private void ChangeWindowName(object? sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox cb)
            {
                // Update window title with the selected word.
                string selectedWord = ((ComboBoxItem)cb.SelectedItem).Content.ToString();
                this.Title = selectedWord;
            }
        }

        // Event handler for Calendar selection change.
        private void SDateChange(object? sender, SelectionChangedEventArgs e)
        {
            if (sender is Calendar cl)
            {
                // Check if the selected date's day is 5 and hide the calendar if true.
                DateTime date = (DateTime)cl.SelectedDate;
                if (date.Day is 5)
                {
                    cl.IsVisible = false;
                }
            }
        }

        // Event handler for TextBox text change related to font size.
        private void SizeUp(object? sender, TextChangedEventArgs e)
        {
            if (sender is TextBox tb)
            {
                try
                {
                    // Update font size based on entered text and show a specific element.
                    tb.FontSize = int.Parse(tb.Text) * 10;
                    Ccalender.IsVisible = true;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        // Event handler for a button click.
        private void ButtonKlikkede(object? sender, object e)
        {
            // Looping logic to change text and orientation in the user control.
            for (int i = 3; i > 0; i++)
            {
                HomeName.txtman.Text = "Klikkede";

                if (HomeName.Panel.Orientation == Orientation.Horizontal)
                {
                    HomeName.Panel.Orientation = Orientation.Vertical;
                }
                else
                {
                    HomeName.Panel.Orientation = Orientation.Horizontal;
                }
            }
        }

        // Event handler for the MouseClick event of the user control.
        private void HomeName_OnMouseClick(object sender, MouseClickEventArgs e)
        {
            // Update the window title with a specific message.
            this.Title = @"Simon is the Winner """"Maybe""";
        }
    }
}