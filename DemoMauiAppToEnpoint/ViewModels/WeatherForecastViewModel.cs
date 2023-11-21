using CommunityToolkit.Mvvm.ComponentModel;
using DemoMauiAppToEnpoint.Models;
using DemoMauiAppToEnpoint.Services;
using System.Collections.ObjectModel;
namespace DemoMauiAppToEnpoint.ViewModels
{
    public partial class WeatherForecastViewModel : ObservableObject
    {
        private readonly ClientService clientService;
        public ObservableCollection<WeatherForecast> WeatherForecasts { get; set; } = [];
        public WeatherForecastViewModel(ClientService clientService)
        {
            this.clientService = clientService;
            LoadWeatherForecastData();
        }

        private async void LoadWeatherForecastData()
        {
            var response = await clientService.GetWeatherForeCastData();
            WeatherForecasts?.Clear();
            if (response.Any())
            {
                foreach (var weatherForecast in response)
                    WeatherForecasts!.Add(weatherForecast);
            }
        }
    }
}
