using ClassLibrary1;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System;
using System.Net;

namespace MetroLibrary
{
    public class Request : IRequest
    {
        public Request()
            {
            }

        public string DoRequest(string url)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            WebRequest request = WebRequest.Create(url);


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
            
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;

        }

    }
}
