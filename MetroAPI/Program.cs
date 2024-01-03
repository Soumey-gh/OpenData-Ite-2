using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace OpenDataAPI
{
    public class Program
    {
        static void Main(string[] args)
        {
            MetroAPI result = new MetroAPI();
            List<LineTransport> afficherLine = result.GetLine(); 
       
            // Réalisation d'un Foreach pour pouvoir afficher toutes les informations pour chaque lignes de la liste: 
            foreach (LineTransport line in afficherLine)
            {
                Console.WriteLine($"{line.id}: {line.name}:{line.zone}:{line.lon}{line.lat}:{line.lines}");
                //Console.WriteLine(line.id + ": " + line.name + ":" + line.zone + ":" + line.lon +line.lat + ":" + line.lines);
            }
           
        }

    }
 }

