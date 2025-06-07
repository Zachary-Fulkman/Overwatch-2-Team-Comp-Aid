namespace Overwatch_2_Suggestions
{
   public enum Role
    {
        Tank,
        DPS,
        Support
    }
    public enum PlaystyleTag
    {
        Brawl,
        Poke,
        Dive,
        Hybrid
    }
    
    public class Hero
    { 
        public string Name { get; set; }
        public Role Role { get; set; }
        public PlaystyleTag PlaystyleTag { get; set; }
        public List<string> Counters { get; set; }
        public List<string> Synergies { get; set; }
        public List<string> MapPreference { get; set; }
        public List<string> Tags { get; set; }
        public string Description { get; set; }

    }
}
