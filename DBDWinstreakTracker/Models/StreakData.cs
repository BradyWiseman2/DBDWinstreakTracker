using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DBDWinstreakTracker
{
    [XmlInclude(typeof(Random2v8StreakData))]
    public class StreakData
    {      
        public virtual string StreakType { get { return "Basic Streak"; } }
        public int StreakID { get; set; }
        public int CharacterID { get; set; }
        public int Wins { get; set; }
        public int TargetWins { get; set; }
        public bool IsStreakEnded { get; set; }
        public DateTime LastEdited { get; set; }
        public ICharacter Character { get { return Killer.Killers.Where(x => x.Character_ID == CharacterID).First(); } }
    }
    public class StreakSaveFile
    {
        public List<StreakData> Streaks { get; set; }
    }
    public class Random2v8StreakData : StreakData
    {
        public override string StreakType { get { return "2v8 Random Streak"; } }
    }
}
