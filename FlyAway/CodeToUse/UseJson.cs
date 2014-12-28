using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Web.Mvc;


namespace FlyAway.CodeToUse
{
    public class UseJson
    {
        Dictionary<string, string> rendu;

        public UseJson()
        {
            rendu = new Dictionary<string, string>();
        }
        public Dictionary<string,string> ReadJsonFile(string file)
        {
            //JObject parseData = 
            
            StreamReader re = new StreamReader(file);
            JsonTextReader reder = new JsonTextReader(re);
            JsonSerializer se = new JsonSerializer();
            JObject parseDat = (JObject)se.Deserialize(reder);

            foreach (var item in parseDat["liste"])
            {
                string a = item["code"].ToString();
                string b = item["pays"].ToString();

                try
                {
                    rendu.Add(item["code"].ToString(), item["pays"].ToString());
                }
                catch (Exception e) { }
            }
            return rendu;
        }

        public IHtmlString ReadDictionnary(string file)
        {
            rendu = ReadJsonFile(file);
//            Dictionary<string, string> rendu
            foreach (var gt in rendu)
            {
                Console.WriteLine(gt.Key +":"+gt.Value);
            }
            return MvcHtmlString.Create("");
        }
    }
}