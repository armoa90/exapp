namespace ExaCnc.ViewModels
{
    using Models;
    using System.Collections.Generic;

    public class TorneoDetalleViewModel
    {

        #region propiedades 
       
         public TorneoList Torneolist
         {
             get;
             set;
         }

        #endregion
        #region Constructor
         public TorneoDetalleViewModel(TorneoList torneolist)
         {
             this.Torneolist = torneolist;
         }
        #endregion

    }
}
