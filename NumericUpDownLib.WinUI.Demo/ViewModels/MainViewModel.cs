using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace NumericUpDownLib.WinUI.Demo.ViewModels;

public partial class MainViewModel : ObservableRecipient
{
    public MainViewModel()
    {
    }

    public enum MyEnum
    {
        ENUM0,
        ENUM1,
        ENUM2,
        ENUM3
    }

    public MyEnum Types
    {
        get; set;
    } = MyEnum.ENUM1;


    public Array MyEnumS { get; set; } = Enum.GetValues(typeof(MyEnum));


    [ObservableProperty]
    public byte lens = 5;

    [ObservableProperty]
    public int displayLength = 4;

    [ObservableProperty]
    public bool isDisplayLengthFixed = false;

    [ObservableProperty]
    public Array orientationS = Enum.GetValues(typeof(Orientation));

    [ObservableProperty]
    public Orientation bOorientation = Orientation.Horizontal;

    [ObservableProperty]
    public Array verticalAlignments = Enum.GetValues(typeof(VerticalAlignment));

    [ObservableProperty]
    public VerticalAlignment vVerticalAlignment = VerticalAlignment.Center;

    [ObservableProperty]
    public Array horizontalAlignments = Enum.GetValues(typeof(HorizontalAlignment));

    [ObservableProperty]
    public HorizontalAlignment hHorizontalAlignment = HorizontalAlignment.Center;

    [ObservableProperty]
    public NumberBoxSpinButtonPlacementMode bSpinButtonPlacementMode = NumberBoxSpinButtonPlacementMode.Compact;

    [ObservableProperty]
    public Array spinButtonPlacementModeS = Enum.GetValues(typeof(NumberBoxSpinButtonPlacementMode));

    [ObservableProperty]
    public string b = NumberBoxSpinButtonPlacementMode.Compact.ToString();

    [ObservableProperty]
    public string a = Orientation.Horizontal.ToString();
}
