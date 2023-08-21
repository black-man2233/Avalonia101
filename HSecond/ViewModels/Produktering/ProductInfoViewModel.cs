using HSecond.Models;

namespace HSecond.ViewModels.Produktering;

public class ProductInfoViewModel : ViewModelBase
{
    public ProductInfoViewModel(ItemModel selectedItem)
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