namespace ExaCnc.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;
    class InicioViewModel
    {
        #region Propiedades
            public bool IsRunning 
            {
                get;
                set;
            }
        #endregion
        #region Constructor
        public InicioViewModel()
        {

        }
        #endregion
        #region Commands
        public ICommand TorneoCommand
        { 
            get;
            set;
        }
        #endregion
    }
}
