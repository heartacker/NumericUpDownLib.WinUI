﻿using System.Collections.ObjectModel;
using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;

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
    public string header = "Byte Header";

    [ObservableProperty]
    public int displayLength = 4;

    [ObservableProperty]
    public bool isDisplayLengthFixed = false;
    
    [ObservableProperty]
    public bool isUpdateValueWhenLostFocus = false;    

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
    public HorizontalAlignment hHorizontalContentAlignment = HorizontalAlignment.Right;

    [ObservableProperty]
    public NumberBoxSpinButtonPlacementMode bSpinButtonPlacementMode = NumberBoxSpinButtonPlacementMode.Compact;

    [ObservableProperty]
    public Array spinButtonPlacementModeS = Enum.GetValues(typeof(NumberBoxSpinButtonPlacementMode));


    [ObservableProperty]
    public Array numberStyless = Enum.GetValues(typeof(NumberStyles));

    [ObservableProperty]
    public NumberStyles nNumberStyles = NumberStyles.HexNumber | NumberStyles.AllowHexSpecifier;

    [ObservableProperty]
    public string formatString = "X2";


    [ObservableProperty]
    public string b = NumberBoxSpinButtonPlacementMode.Compact.ToString();


    [ObservableProperty]
    public string a = default(BindingMode).ToString();

}
