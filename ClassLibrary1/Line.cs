using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1

{
    public class LineTransport
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Lon")]
        public double Lon { get; set; }

        [JsonProperty("Lat")]
        public double Lat { get; set; }

        [JsonProperty("Zone")]
        public string Zone { get; set; }

       [JsonProperty("Lines")]
        public List<string> Lines { get; set; }
    }
}
