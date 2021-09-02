using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExaCnc.Models
{
    public class TorneoList
    {
          [JsonProperty(PropertyName = "codigo")]
        public int Codigo { get; set; }
        [JsonProperty(PropertyName = "descripcion")]
        public string Descripcion { get; set; }
    }
}
