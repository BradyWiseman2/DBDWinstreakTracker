using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDWinstreakTracker
{
    public class Tag
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    public class CharacterData
    {
        public int Character_ID { get; set; }
        public string Name { get; set; }
        public List<Tag> Tags { get; set; }
        public string Character_Portrait_Path { get; set; } //The Filepath that will be loaded
    }
    public class KillerData : CharacterData
    {
        public string Killer_Item {  get; set; }
    }
    public interface ICharacter
    {
        int Character_ID { get; set; }
        string Name { get; set; }
        Bitmap Character_Portrait { get; set; }
        public List<Perk> Character_Perks { get; set; }
    }
}
