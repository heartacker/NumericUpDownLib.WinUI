using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using NumericUpDownLib.WinUI.Demo.ViewModels;

namespace NumericUpDownLib.WinUI.Demo.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
        byteUpDown.ValueChanged += ByteUpDown_ValueChanged;
    }

    private void ByteUpDown_ValueChanged(object? sender, ValueChangedEventArgs<byte> e)
    {
        Trace.WriteLine("aaaa");
    }

    private void myButton_Click(object sender, RoutedEventArgs e)
    {
        myButton.Content = "Clicked";
        bbb.MaxValue = (byte)10;
        bbb.MinValue = (byte)1;
        bbb.Value = bbb.Value > 100 ? (byte)0 : (byte)(bbb.Value + 1);
    }

    private void NumberBox_ValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args)
    {

    }

    private void myButton_SizeChanged(object sender, SizeChangedEventArgs e)
    {

    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        ViewModel.DisplayLength += 1;
    }

    private void ByteUpDownValueChanged(object sender, ValueChangedEventArgs<byte> e)
    {
        Trace.WriteLine($"old:{e.OldValue}\tnew:{e.NewValue}");
    }
}
