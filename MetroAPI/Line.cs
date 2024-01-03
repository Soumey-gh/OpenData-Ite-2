using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataAPI

{
    public class LineTransport
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("lon")]
        public double lon { get; set; }

        [JsonProperty("lat")]
        public double lat { get; set; }

        [JsonProperty("zone")]
        public string zone { get; set; }

        [JsonProperty("lines")]
        public List<string> lines { get; set; }
    }
}
