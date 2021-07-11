using System;
using System.Collections.Generic;
using System.Text;

namespace ExaCnc.ViewModels
{
    class MainViewModel
    {
        #region ViewModels
        public InicioViewModel Inicio 
        { 
            get;
            set;
        }
        #endregion
        #region Constructor
        public MainViewModel()
        {
            this.Inicio = new InicioViewModel();
        }
        #endregion
    }
}
