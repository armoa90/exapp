

namespace ExaCnc.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    class Torneos
    {
        [JsonProperty(PropertyName = "Torneos")]
        public List<TorneosList> TorneosList { get; set; }
    }

    public class TorneosList
    {
        [JsonProperty(PropertyName = "codigo")]
        public int Codigo { get; set; }
        [JsonProperty(PropertyName = "descripcion")]
        public string Descripcion { get; set; }
    }
}

