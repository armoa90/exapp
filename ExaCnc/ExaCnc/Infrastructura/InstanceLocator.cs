using System;
using System.Collections.Generic;
using System.Text;

namespace ExaCnc.Infrastructura
{
    using ViewModels;
    class InstanceLocator
    {
        #region Propiedades
            public MainViewModel Main 
            { get; 
              set; 
            }
        #endregion
        #region Constructor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
