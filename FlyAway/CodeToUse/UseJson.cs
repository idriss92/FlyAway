using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Web.Mvc;
using FlyAway.Models;

namespace FlyAway.CodeToUse
{

    public class UseJson
    {
        Dictionary<string, string> rendu;
        //FlyAwayDbEntities entities = new FlyAwayDbEntities();
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

            foreach (var item in parseDat["aeroports"])
            {

                string a = item["pays"].ToString();
                string b = item["aeroport"].ToString();
                string c = item["ville"].ToString();
               // using (FlyAwayDbEntities entities = new FlyAwayDbEntities())
                //{
                    //AeroportOfficiel aero = new AeroportOfficiel(a,b,c);//new AeroportOfficiel(a, b, c);
                    //entities.AeroportOfficiel.Add(aero);
                    //entities.SaveChanges();
                //}
                

                try
                {
                    rendu.Add(a,b+"("+c+")");
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
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