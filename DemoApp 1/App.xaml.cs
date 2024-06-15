using DemoApp_1.Views;

namespace DemoApp_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
