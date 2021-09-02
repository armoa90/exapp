﻿using System;
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
        public TorneosViewModel Torneos 
        { 
            get; 
            set;
        }
        public TorneoDetalleViewModel TorneoDetalle
        {
            get;
            set;
        }

        #endregion
        #region Constructor
        public MainViewModel()
        {
            instance = this;
            this.Inicio = new InicioViewModel();
        }
        #endregion
        #region Singleton
            // region para llamar solo una vez al mainViewMOdel desde cualquier clase sin instanciar otro MainViewModel 
            private static MainViewModel instance;
            public static MainViewModel GetInstance() 
            {
                if (instance == null) 
                {
                    return new MainViewModel();
                }
                return instance;

            }
        #endregion
    }
}
