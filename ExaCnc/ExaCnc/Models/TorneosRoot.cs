

namespace ExaCnc.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    class TorneosRoot
    {
        [JsonProperty(PropertyName = "torneos")]
        public List<Torneos> Torneos { get; set; }
    }
}

