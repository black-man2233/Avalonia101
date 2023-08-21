using HSecond.Models;

namespace HSecond.ViewModels;

public class ProductInfoVM : ViewModelBase
{
    public ProductInfoVM(ItemModel selectedItem)
    {
        _selectedItem = selectedItem;
    }

    public ItemModel SelectedItem
    {
        get => _selectedItem;
        set
        {
            _selectedItem = value;
            OnPropertyChanged();
        }
    }
    private ItemModel _selectedItem { get; set; }
}