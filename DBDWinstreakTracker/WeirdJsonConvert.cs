using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Drawing;
using DBDWinstreakTracker;

namespace DBDWinstreakTracker
{
    public static class WeirdJsonConvert //Still bad but less bad than the old solution
    {
        public static List<PerkData> ParsePerks(string weirdJson)
        {
            List<PerkData> perks = new List<PerkData>();

            //dynamic document = JsonConvert.DeserializeObject(weirdJson);

            //foreach(dynamic a in document)
            //{
            //    PerkHelper b = new PerkHelper();
            //    b.Name = a.Value.name;              
            //    b.Description = a.Value.description;
            //    b.Role = a.Value.role;
            //    if(a.Value.character.HasValues)
            //    {
            //        b.Character_ID = (int)a.Value.character;
            //    }
            //    else
            //    {
            //        b.Character_ID = 0;
            //    }
            //    b.Tunables = new List<List<string>>();
            //    dynamic tunables = a.Value.tunables;
            //  //  if(tunables.Type == JTokenType.Array)
            //    {
            //        for (int i = 0; i < tunables.Count; i++)
            //        {
            //            List<string> strings = new List<string>();
            //            for (int j = 0; j < tunables[i].Count; j++)
            //            {
            //                strings.Add(tunables[i][j].Value);
            //            }
            //            b.Tunables.Add(strings);
            //        }
            //    }   
            //    perks.Add(b);
            //}


            //b.Name = a.Value.GetProperty("name").ToString();
            //b.Description = a.Value.GetProperty("description").ToString();
            //b.Role = a.Value.GetProperty("role").ToString();
            //JsonElement id = a.Value.GetProperty("character");
            //if (id.ValueKind == JsonValueKind.Null)
            //{
            //    b.Character_ID = 0;
            //}
            //else
            //{
            //    b.Character_ID = id.GetInt32();
            //}
            //JsonElement tunables = a.Value.GetProperty("tunables");

            //if (tunables.ValueKind == JsonValueKind.Null)
            //{

            //}


            List<string> bruh = weirdJson.Split("categories\":").ToList();
            bruh.Remove(bruh.First());
            foreach (string perk in bruh)
            {

                string perk2 = perk.Replace("\\u2019", "'");
                perk2 = perk2.Replace("\\u2018", "'");
                perk2 = perk2 + ",\"";
                PerkData a = new PerkData();
                a.Name = ExtractString(perk2, "name");
                a.Description = ExtractString(perk2, "description");
                a.Role = ExtractString(perk2, "role");
                a.Character_ID = ExtractInt(perk2, "character");
                a.Tunables = ExtractTunables(perk2, "tunables");
                a.Image = ExtractString(perk2, "image");
                a.Image = a.Image.Substring(a.Image.IndexOf("Icons"));
                a.Image = a.Image.Replace("}", "");
                perks.Add(a);
            }

            return perks;
        }

        public static List<KillerData> ParseKillers(string weirdJson)
        {
            List<KillerData> killers = new List<KillerData>();

            dynamic document = JsonConvert.DeserializeObject(weirdJson);

            foreach (dynamic a in document)
            {
                if(a.Value.role == "killer")
                {
                    KillerData b = new KillerData();
                    b.Character_ID = int.Parse(a.Name);
                    b.Name = a.Value.name;
                    b.Character_Portrait_Path = a.Value.image;
                    b.Killer_Item = a.Value.item;
                    Tag t = new Tag();
                    t.Key = "MovementSpeed";
                    t.Value = "4.6";
                    b.Tags = new List<Tag>();
                    b.Tags.Add(t);
                    killers.Add(b);
                }                                                     
            }
            return killers;
        }
        public static List<KillerAddonData> ParseAddons(string weirdJson)
        {
            List<KillerAddonData> addons = new List<KillerAddonData>();

            dynamic document = JsonConvert.DeserializeObject(weirdJson);

            foreach (dynamic a in document)
            {
                if (a.Value.role == "killer")
                {
                    KillerAddonData b = new KillerAddonData(); 
                    b.Name = a.Value.name;
                    b.Image = a.Value.image;
                    b.PowerItem = a.Value.parents[0];                  
                    addons.Add(b);
                }
            }
            return addons;
        }


        private static string ExtractString(string whole, string value)
        {
            int startIndex = whole.IndexOf(value) + value.Length+2;
            int endIndex = whole.IndexOf(",\"", startIndex);
            if (startIndex == -1 || endIndex == -1)
            {
                return null;
            }
            string stringvalue = whole.Substring(startIndex, endIndex - startIndex);
            stringvalue = stringvalue.Replace("\"","");
            return stringvalue;
        }
        private static int ExtractInt(string whole, string value)
        {
            string intValue = ExtractString(whole, value);
            if(intValue == "null")
            {
                return 0;
            }
            return int.Parse(intValue);
        }
        private static List<List<string>> ExtractTunables(string whole, string value) //This one is pretty jank but since its only for perks I'll allow it
        {
            string splitvalue = "],";
            List<List<string>> tunables = new List<List<string>>();
            int startIndex = whole.IndexOf(value) + value.Length + 2;
            int endIndex = whole.IndexOf("]],", startIndex)+2;
            if(endIndex == 1)
            {
                endIndex = whole.IndexOf("]},", startIndex) + 2;
                splitvalue = ":";
            }

            string tunableswhole = whole.Substring(startIndex, endIndex - startIndex);

            List<string> tunables2 = tunableswhole.Split(splitvalue).ToList();
            if(splitvalue == ":")
            {
                tunables2.Remove(tunables2.First());
            }
            foreach (string t in tunables2)
            {
                string t2 = t.Replace("]", "");
                t2 = t2.Replace("[", "");
                t2 = t2.Replace("}", "");
                t2 = t2.Replace("\"", "");
                List<string> final = t2.Split(",").ToList();
                tunables.Add(final);
            }
            if(splitvalue == ":" && tunables.Count > 1)
            {
                tunables.RemoveAt(0); //I'm done with BHVR's weird tunable structure bruh
            }
            return tunables;
        } 
    }
}
