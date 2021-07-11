namespace ExaCnc.Models
{
    using Newtonsoft.Json;
    public class Root
    {
        [JsonProperty(PropertyName = "codigo")]
        public int Codigo { get; set; }
        [JsonProperty(PropertyName = "Desripcion")]
        public string Desripcion { get; set; }
    }
}
