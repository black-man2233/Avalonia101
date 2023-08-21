using System.Reactive;
using Avalonia.Controls;
using HSecond.Models;
using HSecond.Views.UserControls.Produktering;
using ReactiveUI;

namespace HSecond.ViewModels.Produktering;

public class ProdukteringVM : ViewModelBase
{
    #pragma warning disable
    public ProdukteringVM()
    {
        _selectedItemInfoView = new ProductInfoView();
        _menuView = new MenuView();
    }

    
    public object MenuView
    {
        get { return _menuView; }
        set
        {
            _menuView = value;
            OnPropertyChanged();
        }
    }
    public object SelectedItemInfoView
    {
        get { return _selectedItemInfoView; }
        set
        {
            _selectedItemInfoView = value;
            OnPropertyChanged();
        }
    }
    
    private object _menuView;
    private object _selectedItemInfoView;
}