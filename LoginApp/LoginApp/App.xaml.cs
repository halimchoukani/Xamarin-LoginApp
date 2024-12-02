using LoginApp.Services;
using LoginApp.Views;
using LoginApp;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            // Définit la page de connexion comme page d'accueil
            MainPage = new NavigationPage(new LoginPage());

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
