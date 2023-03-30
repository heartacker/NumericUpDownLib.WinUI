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
    public int displayLength = 4;

    [ObservableProperty]
    public bool isDisplayLengthFixed = false;

    [ObservableProperty]
    public Array orientationS = Enum.GetValues(typeof(Orientation));

    [ObservableProperty]
    public Orientation bOorientation;

    [ObservableProperty]
    public Array spinButtonPlacementModeS = Enum.GetValues(typeof(NumberBoxSpinButtonPlacementMode));

    [ObservableProperty]
    public NumberBoxSpinButtonPlacementMode bSpinButtonPlacementMode = NumberBoxSpinButtonPlacementMode.Compact;
}
