using AntEMR.Views;
using Xamarin.Forms;

namespace AntEMR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            Routing.RegisterRoute(route: "login", typeof(LoginPage));
            Routing.RegisterRoute(route: "registration", typeof(RegistrationPage));
            Routing.RegisterRoute(route: "registrationdetails", typeof(RegistrationDetailsPage));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
