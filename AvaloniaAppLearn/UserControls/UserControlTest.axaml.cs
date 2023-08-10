using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;

namespace AvaloniaAppLearn.UserControls;

public partial class UserControlTest : UserControl
{
    public UserControlTest()
    {
        InitializeComponent();
        DispatcherTimer timer = new DispatcherTimer();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += timer_Tick;
        timer.Start();
    }
    void timer_Tick(object sender, EventArgs e)
    {
        lblTime.Content = DateTime.Now.ToLongTimeString();
    }
}