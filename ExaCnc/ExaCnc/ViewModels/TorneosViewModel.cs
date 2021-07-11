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
        private ObservableCollection<Root> root;
        #endregion
        #region Propiedades
        public ObservableCollection<Root> Root
        {
            get { return this.root; }
            set { SetValue(ref this.root, value); }
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
            var response = await this.apiService.GetList<Root>(
                "http://exacnc.com",
                "/rest",
                "/torneo");
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                return;
            }
            var list = (List<Root>)response.Result;
            this.Root = new ObservableCollection<Root>(list);
        }
        #endregion

    }
}