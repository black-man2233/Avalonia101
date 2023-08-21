using System;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using HSecond.Models;
using ReactiveUI;

namespace HSecond.ViewModels;

public class MenuVM : ViewModelBase
{
    public MenuVM()
    {
        _menuList = new();
        ItemClickedCommand = ReactiveCommand.Create<object>(ShowItemInfo);
    }

    #region Properties

    public ReactiveCommand<object, Unit> ItemClickedCommand { get; }

    public ObservableCollection<ItemModel> MenuList
    {
        get => _menuList;
        set
        {
            _menuList = value;
            OnPropertyChanged(nameof(MenuList));
        }
    }

    #endregion

    #region Methods

    private void ShowItemInfo(object parameter)
    {
        try
        {
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    #endregion

    #region private fields

    private ObservableCollection<ItemModel> _menuList { get; set; }

    #endregion
}