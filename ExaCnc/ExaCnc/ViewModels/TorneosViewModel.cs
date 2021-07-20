namespace ExaCnc.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Servicios;
    using Models;
    using Xamarin.Forms;

    class TorneosViewModel : BaseViewModel
    {
        #region Servicios
        private ApiService apiService;
        #endregion
        #region  Atributos
        private ObservableCollection<Torneos> torneos;
        #endregion
        #region Propiedades
        public ObservableCollection<Torneos> Torneos
        {
            get { return this.torneos;}
            set { SetValue(ref this.torneos, value); }
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
            var response = await this.apiService.GetList<Torneos>(
                "http://exacnc.com",
                "/rest",
                "/torneo",
                "ApiUserAdmin",
                "ApiUserAdmin");
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                return;
            }
            var list = (List<Torneos>)response.Result;
            this.Torneos = new ObservableCollection<Torneos>(list);
        }
        #endregion

    }
}