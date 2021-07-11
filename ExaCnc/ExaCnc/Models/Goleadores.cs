namespace ExaCnc.Models
{
    using Newtonsoft.Json;
    class Goleadores
    {
        [JsonProperty(PropertyName = "cod_jugador")]
        public int Cod_jugador { get; set; }
        [JsonProperty(PropertyName = "Jugador")]
        public string Jugador { get; set; }
        [JsonProperty(PropertyName = "Goles")]
        public string Goles { get; set; }
        [JsonProperty(PropertyName = "Equipo")]
        public string Equipo { get; set; }
    }
}
