using DemoMauiAppToEnpoint.ViewModels;

namespace DemoMauiAppToEnpoint.Views;

public partial class WeatherForecastPage : ContentPage
{
    public WeatherForecastPage(WeatherForecastViewModel weatherForecastViewModel)
    {
        InitializeComponent();
        BindingContext = weatherForecastViewModel;
    }
}