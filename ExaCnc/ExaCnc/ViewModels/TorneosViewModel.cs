namespace ExaCnc.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Servicios;
    using Models;
    using Xamarin.Forms;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;

    class TorneosViewModel : BaseViewModel
    {
        #region Servicios
        private ApiService apiService;
        #endregion
        #region  Atributos
        private ObservableCollection<TorneosList> torneos; 
        private bool isRefreshing;
        #endregion
        #region Propiedades
        public ObservableCollection<TorneosList> Torneos
        {
            get { return this.torneos; }
            set { SetValue(ref this.torneos, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion
        #region constructor
        public TorneosViewModel()
        {
            this.apiService = new ApiService();
            this.LoadTorneos();
        }
        #endregion
        #region metodos
        private async void LoadTorneos()
        {
            this.IsRefreshing = true;
            var coneccion = await this.apiService.CheckConnection();

            if (!coneccion.IsSuccess) {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    coneccion.Message,
                    "Accept");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }
                var response = await this.apiService.GetList<Torneos>(
                "http://exacnc.com",
                "/rest",
                "/torneo",
                "ApiUserAdmin",
                "ApiUserAdmin");
            if (!response.IsSuccess)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }
            var objTorneos = (Torneos)response.Result;
           var listTor = (List<TorneosList>)objTorneos.TorneosList;
           // var list =(List<TorneosList>)response.Result;

            this.Torneos = new ObservableCollection<TorneosList>(listTor);
            
            this.IsRefreshing = false;
        }
        #endregion
        #region Commands
        public ICommand RefreshCommand
        {
            get 
            {
                return new RelayCommand(LoadTorneos);
                    
            }
            
        }

        #endregion

    }
}