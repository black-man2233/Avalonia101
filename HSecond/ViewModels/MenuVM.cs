using System;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using HSecond.Models;
using ReactiveUI;

namespace HSecond.ViewModels;

public class MenuVM
{
    public MenuVM()
    {
        ItemClickedCommand = ReactiveCommand.Create<object>(ShowItemInfo);
    }


    public ReactiveCommand<object, Unit> ItemClickedCommand { get; }

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