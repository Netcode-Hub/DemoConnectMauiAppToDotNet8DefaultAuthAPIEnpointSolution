using DemoMauiAppToEnpoint.ViewModels;

namespace DemoMauiAppToEnpoint
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }

    }
}
