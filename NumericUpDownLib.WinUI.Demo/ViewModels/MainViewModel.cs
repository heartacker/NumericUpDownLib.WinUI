using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Controls;

namespace NumericUpDownLib.WinUI.Demo.ViewModels;

public partial class MainViewModel : ObservableRecipient
{
    public MainViewModel()
    {
    }

    [ObservableProperty]
    public byte lens = 5;

    [ObservableProperty]
    public byte displayLength = 4;

    [ObservableProperty]
    public bool isDisplayLengthFixed = false;

    public ObservableCollection<Orientation> OrientationS;
}
