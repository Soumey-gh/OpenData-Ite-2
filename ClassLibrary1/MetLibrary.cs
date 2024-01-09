
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ClassLibrary1

{
    public class MetLibrary
    {
        public List<LineTransport> GetLine(double Longitude, double Latitude, int Radius)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            // Create a request for the URL. 
            WebRequest request = WebRequest.Create("http://data.mobilites-m.fr/api/linesNear/json?x=5.7311970517846&y=45.184446886268645&dist=500&details=true");

            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Display the status.
            Console.WriteLine(response.StatusDescription);

            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);

            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            List<LineTransport> afficheLines = JsonConvert.DeserializeObject<List<LineTransport>>(responseFromServer);

            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();
            return afficheLines;

        }
    }
}
