
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MetroLibrary;
using Newtonsoft.Json;


namespace ClassLibrary1

{
    public class MetLibrary
    {
        private IRequest _request; 
      

        public MetLibrary ()
        {
            _request = new Request ();
        }

        public MetLibrary(IRequest metLibrary)
        {
            _request = metLibrary;
        }



        public List<LineTransport> GetLine(double x, double y , int r )
        {

            string web = _request.DoRequest($"http://data.mobilites-m.fr/api/linesNear/json?x={x.ToString(System.Globalization.CultureInfo.InvariantCulture)}&y={y.ToString(System.Globalization.CultureInfo.InvariantCulture)}&dist={r.ToString()}&details=true");
            
            Console.WriteLine(web);
            
            List<LineTransport> afficheLines = JsonConvert.DeserializeObject<List<LineTransport>>(web);

            return afficheLines;
        }
    }
}
