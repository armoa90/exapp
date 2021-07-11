using ExaCnc.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExaCnc
{
    public partial class App : Application
    {
        #region constructor
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InicioPage());
        }
        #endregion
        #region Metodos
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        #endregion Metodos
    }
}
