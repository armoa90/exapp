﻿namespace ExaCnc.Models
{
    using Newtonsoft.Json;
    class Posiciones
    {
        [JsonProperty(PropertyName = "Equipo")]
        public string Equipo { get; set; }
        [JsonProperty(PropertyName = "Puntos")]
        public int Puntos { get; set; }
        [JsonProperty(PropertyName = "PG")]
        public int PG { get; set; }
        [JsonProperty(PropertyName = "PE")]
        public int PE { get; set; }
        [JsonProperty(PropertyName = "PP")]
        public int PP { get; set; }
        [JsonProperty(PropertyName = "GF")]
        public int GF { get; set; }
        [JsonProperty(PropertyName = "GC")]
        public int GC { get; set; }
        [JsonProperty(PropertyName = "DIF")]
        public int DIF { get; set; }
    }
}
