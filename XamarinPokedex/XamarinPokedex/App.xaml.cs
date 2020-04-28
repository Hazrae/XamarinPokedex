using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPokedex.Services;
using XamarinPokedex.Utils;
using XamarinPokedex.Utils.Interfaces;

namespace XamarinPokedex
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<PokemonService>();
            DependencyService.Register<IHttpController, HttpController>();
            MainPage = new NavigationPage(new MainPage());
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
