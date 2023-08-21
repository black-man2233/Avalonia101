using System;
using System.Collections.ObjectModel;
using System.Reactive;
using HSecond.Models;
using ReactiveUI;

namespace HSecond.ViewModels.Produktering;

public class MenuViewModel : ViewModelBase
{
    public MenuViewModel()
    {
        _menuList = new();
        ItemClickedCommand = ReactiveCommand.Create<object>(ShowItemInfo);
        tmpData();
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

    private void tmpData()
    {
        for (int i = 0; i < 10; i++)
            _menuList.Add(new ItemModel($"{i}", $"navn{i}", $"produktbeskrivelse {i}", (decimal)100 * i,
                (decimal)100 * 2, (float)3 * i, ProduktEnhed.cm, false, null));
    }
}