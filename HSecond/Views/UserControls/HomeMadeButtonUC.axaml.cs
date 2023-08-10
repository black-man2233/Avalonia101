using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media.Imaging;

namespace HSecond.Views.UserControls;

// Defining a custom UserControl class named HomeMadeButtonUC.
public partial class HomeMadeButtonUC : UserControl
{
    // Defining an event delegate for MouseClick events.
    public event MouseClickEventHandler? MouseClick;

    // Constructor for the HomeMadeButtonUC class.
    public HomeMadeButtonUC()
    {
        // Initialize the user control components.
        InitializeComponent();

        // Attach the OnPointerReleased method to the PointerReleased event.
        PointerReleased += OnPointerReleased;
    }

    // Event handler for the PointerReleased event.
    void OnPointerReleased(object? sender, PointerReleasedEventArgs args)
    {
        // Create an instance of the MouseClickEventArgs class.
        MouseClickEventArgs mouseClickArgs = new();

        // Determine the mouse button that was pressed.
        switch (args.InitialPressMouseButton)
        {
            case MouseButton.Left:
                mouseClickArgs.MouseButton = 1; // Left mouse button.
                break;
            case MouseButton.Right:
                mouseClickArgs.MouseButton = 2; // Right mouse button.
                break;
            case MouseButton.Middle:
                mouseClickArgs.MouseButton = 3; // Middle mouse button.
                break;
        }

        // Check if there are any subscribers to the MouseClick event.
        if (MouseClick != null)
        {
            // Invoke the MouseClick event and pass the sender and event arguments.
            MouseClick.Invoke(this, mouseClickArgs);
        }
    }
}

// Delegate declaration for the MouseClick event.
public delegate void MouseClickEventHandler(object sender, MouseClickEventArgs e);

// Custom event arguments class for MouseClick events.
public class MouseClickEventArgs : EventArgs
{
    // Property to store the mouse button that was clicked.
    public int MouseButton { get; set; }
}