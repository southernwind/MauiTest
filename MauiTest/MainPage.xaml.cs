using MauiTest.ViewModels;

namespace MauiTest;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel mainViewModel )
    {
        this.InitializeComponent();
		this.BindingContext = mainViewModel;
    }
}
