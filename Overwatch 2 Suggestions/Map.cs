namespace Overwatch_2_Suggestions
{
    public enum MapName
    {
        Antarctic_Peninsula,
        Busan,
        Ilios,
        Lijiang_Tower,
        Nepal,
        Oasis,
        Samoa,
        Circuit_Royal,
        Dorodo,
        Havana,
        Junkertown,
        Rialto,
        Route_66,
        Shambali_Monastery,
        Watchpoint_Gibraltar,
        New_Junk_City,
        Suravasa,
        Blizzard_World,
        Eichenwalde,
        Hollywood,
        Kings_Row,
        Midtown,
        Numbani,
        Paraiso,
        Colosseo,
        Esperanca,
        New_Queen_Street,
        Runasapi,
        Hanaoka,
        Throne_of_Anubis

    }

    public enum MapPlaystyle
    {
       Dive,
       Brawl,
       Poke,
       Hybrid
    }
    
    public class Map
    {
        public MapName Name { get; set; }
        public MapPlaystyle Playstyle { get; set; }
    }
}
