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
    }
}
