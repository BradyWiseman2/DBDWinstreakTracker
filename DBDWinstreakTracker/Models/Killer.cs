using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDWinstreakTracker
{
    public class Killer : ICharacter
    {
        public static List<Killer> Killers { get; set; }
        public int Character_ID { get; set; }
        public string Name { get; set; }
        public Bitmap Character_Portrait { get; set; }
        public Dictionary<string,string> Tags { get; set; }
        public List<Perk> Character_Perks { get; set; }
        
        static Killer()
        {
            Killers = new List<Killer>();
        }
        public Killer(CharacterData data)
        {
            Character_ID = data.Character_ID;
            Name = data.Name;
            Character_Portrait = new Bitmap("Resources/"+data.Character_Portrait_Path);
            Tags = new Dictionary<string, string>();
            foreach(Tag tag in data.Tags)
            {
                Tags.Add(tag.Key, tag.Value);
            }
            Character_Perks = new List<Perk>();
            Killers.Add(this);
        }
    }
}
