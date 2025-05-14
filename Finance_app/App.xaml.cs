using Finance_app.Views;

namespace Finance_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            RegisterRoutes();
            MainPage = new AppShell();
        }

        public void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        }
    }
}
