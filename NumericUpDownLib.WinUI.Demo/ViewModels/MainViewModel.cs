using CommunityToolkit.Mvvm.ComponentModel;

namespace NumericUpDownLib.WinUI.Demo.ViewModels;

public partial class MainViewModel : ObservableRecipient
{
    public MainViewModel()
    {
    }

    [ObservableProperty]
    public byte lens = 5;
}
