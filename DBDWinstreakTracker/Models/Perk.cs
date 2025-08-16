using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDWinstreakTracker
{
    public class Perk
    {
        public static List<Perk> Perks { get; set; }
        public string Name {  get; set; }
        public string Description { get; set; }
        public Bitmap Perk_Icon { get; set; }
        public ICharacter Perk_Owner { get; set; }
        static Perk()
        {
            Perks = new List<Perk>();
        }

        public Perk(PerkData data)
        {
            Name = data.Name;
            Description = data.Description;
            Perk_Icon = new Bitmap("Resources/"+data.Image+".png");
            Perks.Add(this);

        }
    }  
    public class PerkData
    {      
        public string Name { get; set; }
        public string Description { get; set; }
        public string Role { get; set; }
        public int Character_ID { get; set; }
        public List<List<string>> Tunables { get; set; }
        public string Image { get; set; }
    }   
}
