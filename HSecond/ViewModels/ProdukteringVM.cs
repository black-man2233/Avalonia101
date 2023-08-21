using System.Reactive;
using Avalonia.Controls;
using HSecond.Models;
using ReactiveUI;

namespace HSecond.ViewModels;

public class ProdukteringVM : ViewModelBase
{
    public ProdukteringVM()
    {
        ItemClickedCommand = ReactiveCommand.Create<object>(ShowItemInfo);
    }

    private void ShowItemInfo(object obj)
    {
        if (obj is not ItemModel)
            return;

        CurrentView = new ProductInfoVM((ItemModel)obj);
    }

    public ReactiveCommand<object, Unit> ItemClickedCommand { get; }

    public object CurrentView
    {
        get { return _currentView; }
        set
        {
            _currentView = value;
            OnPropertyChanged();
        }
    }

    private object _currentView;
}