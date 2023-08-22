using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Empathia.Vistas;
using Empathia.Vistas.diario;

namespace Empathia
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Home());
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
