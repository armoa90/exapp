namespace ExaCnc.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    class Torneos
    {
        [JsonProperty(PropertyName = "codigo")]
        public int Codigo { get; set; }
        [JsonProperty(PropertyName = "desripcion")]
        public string Desripcion { get; set; }
    }
}
