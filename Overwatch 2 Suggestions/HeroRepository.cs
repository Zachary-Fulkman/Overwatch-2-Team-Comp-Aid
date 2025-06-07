namespace Overwatch_2_Suggestions
{
    public static class HeroRepository
    {
        public static List<Hero> GetHeroes()
        {
            return new List<Hero>
            {
                //TANKS
                new Hero 
                {
                    Name = "Reinhardt",
                    Role = Role.Tank,
                    Counters = new List<string> { "Orisa", "Winston", "Doomfist", "Ramattra", "Hazard", "Reaper", "Bastion", "Pharah", "Ana", "Mei", "Zenyatta", "Lucio" },
                    Synergies = new List<string> { "Sojourn", "Soldier_76", "Echo", "Bastion", "Ana", "Lifeweaver", "Kiriko", "Lucio", "Juno" },
                    PlaystyleTag = PlaystyleTag.Brawl,
                    MapPreference = new List<string> { "Kings_Row", "Dorado", "Numbani", "New_Queen_Street", "Circuit_Royal", "Havana" }
                },
                new Hero
                {
                    Name = "D.Va",
                    Role = Role.Tank,
                    Counters = new List<string> { "Zarya", "Reinhardt", "Sigma", "Mei", "Symmetra", "Reaper", "Cassidy", "Sojourn", "Sombra", "Echo", "Ana", "Zenyatta", "Kiriko" },
                    Synergies = new List<string> { "Tracer", "Genji", "Sombra", "Echo", "Sojourn", "Ana", "Lifeweaver", "Kiriko", "Zenyatta", "Mercy" },
                    PlaystyleTag = PlaystyleTag.Dive,
                    MapPreference = new List<string> { "New_Queen_Street", "Oasis", "Lijiang_Tower", "Eichenwalde", "Circuit_Royal", "Colosseo", "Kings_Row" }
                },
                new Hero
                {
                    Name = "Doomfist",
                    Role = Role.Tank,
                    Counters = new List<string> { "Roadhog", "Orisa", "Sigma", "Pharah", "Echo", "Mei", "Sombra", "Symmetra", "Reaper", "Ana" },
                    Synergies = new List<string> { "Genji", "Tracer", "Venture", "Echo", "Reaper", "Lifeweaver", "Kiriko" },
                    PlaystyleTag = PlaystyleTag.Dive,
                    MapPreference = new List<string> { "New_Queen_Street", "Lijiang_Tower", "Oasis", "Circuit_Royal", "Eichenwalde" }
                },
                 new Hero
                {
                    Name = "Hazard",
                    Role = Role.Tank,
                    Counters = new List<string> { "Roadhog", "Mauga", "Orisa", "Bastion", "Symmetra", "Sombra", "Reaper", "Sojourn", "Ana", "Kiriko", "Zenyatta" },
                    Synergies = new List<string> { "Tracer", "Sombra", "Venture", "Echo", "Hanzo", "Ashe", "Genji", "Kiriko", "Lifeweaver", "Lucio" },
                    PlaystyleTag = PlaystyleTag.Dive,
                    MapPreference = new List<string> { "New_Queen_Street", "Lijiang_Tower", "Oasis", "Circuit_Royal", "Eichenwalde" }
                },
                 new Hero
                 {
                     Name = "Junker_Queen",
                     Role = Role.Tank,
                     Counters = new List<string> { "Orisa", "Wrecking_Ball", "Zarya", "Cassidy", "Mei", "Reaper", "Sojourn", "Torbjorn", "Freja", "Ana", "Baptiste", "Kiriko" },
                     Synergies = new List<string> { "Sojourn", "Reaper", "Soldier_76", "Junkrat", "Ashe", "Juno", "Lucio", "Kiriko" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "New_Queen_Street", "Circuit_Royal", "Colosseo", "Kings_Row", "Dorado", "Numbani" }
                 },
                 new Hero
                 {
                     Name = "Mauga",
                     Role = Role.Tank,
                     Counters = new List<string> { "Sigma", "Reinhardt", "Zarya", "Bastion", "Reaper", "Echo", "Mei", "Ana", "Brigitte", "Lucio", "Widowmaker" },
                     Synergies = new List<string> { "Sojourn", "Soldier_76", "Mei", "Kiriko", "Illari", "Baptiste", "Ana", "Lifeweaver" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "New_Queen_Street", "Circuit_Royal", "Colosseo", "Kings_Row", "Dorado", "Numbani" }
                 },
                 new Hero
                 {
                     Name = "Orisa",
                     Role = Role.Tank,
                     Counters = new List<string> { "Zarya", "Mauga", "Bastion", "Symmetra", "Echo", "Hanzo", "Mei", "Reaper", "Cassidy", "Ana", "Zenyatta" },
                     Synergies = new List<string> { "Reaper", "Sojourn", "Junkrat", "Ashe", "Ana", "Kiriko", "Lucio", "Moira" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "Junkertown", "Route_66", "Eichenwalde", "Hollywood", "Kings_Row" }
                 },
                 new Hero
                 {
                     Name = "Ramattra",
                     Role = Role.Tank,
                     Counters = new List<string> { "Sigma", "Mauga", "Orisa", "Zarya", "Bastion", "Ashe", "Sombra", "Hanzo", "Ana", "Zenyatta" },
                     Synergies = new List<string> { "Reaper", "Mei", "Ashe", "Freja", "Sojourn", "Juno", "Lucio", "Lifeweaver" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "Circuit_Royal", "Colosseo", "Eichenwalde", "Junkertown", "Kings_Row" }
                 },
                 new Hero
                 {
                     Name = "Roadhog",
                     Role = Role.Tank,
                     Counters = new List<string> { "Orisa", "Reinhardt", "Mauga", "Reaper", "Symmetra", "Bastion", "Hanzo", "Pharah", "Ana", "Zenyatta", "Kiriko"},
                     Synergies = new List<string> { "Mei", "Reaper", "Torbjorn", "Tracer", "Echo", "Kiriko", "Illari", "Baptiste" },
                     PlaystyleTag = PlaystyleTag.Hybrid,
                     MapPreference = new List<string> { "Eichenwalde", "Rialto", "Circuit_Royal", "Lijang_Tower", "Oasis", "Ilios", "Paraiso" }
                 },
                 new Hero
                 {
                     Name = "Sigma",
                     Role = Role.Tank,
                     Counters = new List<string> { "Zarya", "Winston", "JunkerQueen", "Echo", "Symmetra", "Sombra", "Mei", "Kiriko", "Brigette", "Baptiste" },
                     Synergies = new List<string> { "Ashe", "Hanzo", "Widowmaker", "Bastion", "Sojourn", "Soldier_76", "Ana", "Illari", "Moira", "Ana" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Circuit_Royal", "Dorado", "Havana", "Watchpoint_Gibraltar", "Route_66", "Paraiso" }
                 },
                 new Hero
                 {
                     Name = "Winston",
                     Role = Role.Tank,
                     Counters = new List<string> { "Roadhog", "JunkerQueen", "Mauga", "Bastion", "Reaper", "Torbjorn", "Venture", "Ana", "Moira" },
                     Synergies = new List<string> { "Tracer", "Sombra", "Echo", "Genji", "Venture", "Freja", "Kiriko", "Moira", "Lifeweaver" },
                     PlaystyleTag = PlaystyleTag.Dive,
                     MapPreference = new List<string> { "Watchpoint_Gibraltar", "Circuit_Royal", "Kings_Row", "MidTown", "New_Queen_Street", "Ilios" }
                 },
                 new Hero
                 {
                     Name = "Wrecking_Ball",
                     Role = Role.Tank,
                     Counters = new List<string> { "Roadhog", "Sojourn", "JunkerQueen", "Sigma", "Sombra", "Symettra", "Torbjorn", "Reaper", "Phara", "Echo", "Ana", "Kiriko", "Brigette" },
                     Synergies = new List<string> { "Tracer", "Freja", "Venture", "Sojourn", "Widowmaker", "Mei", "Junkrat", "Moira", "Lifeweaver", "Kiriko" },
                     PlaystyleTag = PlaystyleTag.Hybrid,
                     MapPreference = new List<string> { "Havana", "Watchpoint_Gibraltar", "Junkertown", "Colosseo", "Nambani", "New_Queen_Street" }
                 },
                 new Hero
                 {
                     Name = "Zarya",
                     Role = Role.Tank,
                     Counters = new List<string> { "Reinhardt", "Roadhog", "Winston", "Reaper", "Bastion", "Sojourn", "Ashe", "Cassidy", "Mei", "Ana", "Kiriko", "Illari", "Baptiste" },
                     Synergies = new List<string> { "Reaper", "Junkrat", "Tarcer", "Genji", "Venture", "Cassidy", "Ana", "Baptiste", "Kirkiko", "Mercy" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "Kings_Row", "Eichenwalde", "Colosseo", "Nepal", "Midtowne" }
                 },
                 //TANKS END

                 //DPS
                 new Hero
                 {
                     Name = "Freja",
                     Role = Role.DPS,
                     Counters = new List<string> { "D.Va", "Ashe", "Echo", "Hanzo", "Widowmaker", "Sojourn", "Ana", "Moira" },
                     Synergies = new List<string> { "Orisa", "Ramattra", "Sigma", "Ashe", "Echo", "Junkrat", "Pharah", "Tracer", "Kiriko", "Lifeweaver" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Ilios", "Oasis", "Dorado", "Rialto", "Route_66", "Blizzard_World", "Eichenwalde" }
                 },
                 new Hero
                 {
                     Name = "Ashe",
                     Role = Role.DPS,
                     Counters = new List<string> { "Winston", "D.Va", "Genji", "Tracer", "Sombra", "Widowmaker", "Venture", "Ana", "Lucio", "Moira", "Brigitte" },
                     Synergies = new List<string> { "Sigma", "Reinhardt", "Ramattra", "Freja", "Hanzo", "Sojourn", "Baptiste", "Mercy", "Illari" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Nepal", "Circuit_Royal", "Havana", "Watchpoint_Gibralter", "Dorado", "Eichenwalde", "Numbani" }
                 },
                 new Hero
                 {
                     Name = "Bastion",
                     Role = Role.DPS,
                     Counters = new List<string> { "D.Va", "Doomfist", "JunkerQueen", "Ashe", "Reaper", "Hanzo", "Widowmaker", "Genji", "Kiriko", "Ana" },
                     Synergies = new List<string> { "Reinhardt", "Zarya", "Ramattra", "Sigma", "Ashe", "Sojourn", "Soldier_76", "Freja", "Baptiste", "Mercy" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Eichenwalde", "Busan", "Oasis", "Dorado", "Blizzard_World", "Kings_Row", "Midtown" }
                 },
                 new Hero
                 {
                     Name = "Cassidy",
                     Role = Role.DPS,
                     Counters = new List<string> { "D.Va", "Hazard", "Doomfist", "Winston", "Bastion", "Pharah", "Sombra", "Venture", "Ana", "Moira", "Kiriko" },
                     Synergies = new List<string> { "Sigma", "Ramattra", "Roadhog", "Ashe", "Freja", "Soldier_76", "Torbjorn", "Mercy", "Illari", "Baptiste" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Antarctic_Peninsula", "Lijiang_Tower", "Rialto", "Kings_Row", "Numbani", "Colosseo", "New_Queen_Street" }
                 },
                 new Hero
                 {
                     Name = "Echo",
                     Role = Role.DPS,
                     Counters = new List<string> { "Zarya", "JunkerQueen", "Freja", "Ashe", "Widowmaker", "Soldier_76", "Ana", "Lifeweaver", "Kiriko" },
                     Synergies = new List<string> { "D.Va", "Winston", "Wrecking_Ball", "Doomfist", "Tracer", "Sombra", "Venture", "Kiriko", "Mercy", "Illari" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Colosseo", "Esperanca", "New_Queen_Street", "Paraiso", "Eichenwalde", "Hollywood", "Dorado" }
                 },
                 new Hero
                 {
                     Name = "Genji",
                     Role = Role.DPS,
                     Counters = new List<string> { "Zarya", "Winston", "Echo", "Symmetra", "Reaper", "Mei", "Sombra", "Venture", "Moira", "Illari", "Baptiste" },
                     Synergies = new List<string> { "Winston", "D.Va", "Wrecking_ball", "Sombra", "Venture", "Reaper", "Tracer", "Mercy", "Kiriko", "Juno" },
                     PlaystyleTag = PlaystyleTag.Dive,
                     MapPreference = new List<string> { "Route_66", "Shambali_Monastery", "Blizzard_World", "Kings_Row", "Paraiso", "NUmbani", "Colosseo" }
                 },
                 new Hero
                 {
                     Name = "Hanzo",
                     Role = Role.DPS,
                     Counters = new List<string> { "Winston", "D.Va", "Doomfist", "Ashe", "Widowmaker", "Hanzo", "", "Genji", "Reaper", "Sombra", "Venture", "Lucio", "Moira" },
                     Synergies = new List<string> { "Sigma", "Freja", "Ashe", "Sojourn", "Soldier_76", "Torbjorn", "Pharah", "Ana", "Mercy", "Illari" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Nepal", "Oasis", "Circuit_Royal", "Havana", "Junkertown", "Runasapi", "Paraiso" }
                 },
                 new Hero
                 {
                     Name = "Junkrat",
                     Role = Role.DPS,
                     Counters = new List<string> { "Freja", "Ashe", "Echo", "Phara", "Sojourn", "Torbjorn", "Widowmaker", "Bastion", "Mei", "Baptiste", "Kiriko" },
                     Synergies = new List<string> { "Orisa", "Reinhardt", "Roadhog", "JunkerQueen", "Mei", "Reaper", "Venture", "Cassidy", "Mercy", "Juno" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "Kings_Row", "Blizzard_World", "Paraiso", "Dorado", "Lijiang_Tower", "Ilios", "Oasis" }
                 },
                 new Hero
                 {
                     Name = "Mei",
                     Role = Role.DPS,
                     Counters = new List<string> { "Zarya", "Reinhardt", "JunkerQueen", "Ashe", "Bastion", "Reaper", "Soldier_76", "Ana", "Baptiste", "Lifeweaver" },
                     Synergies = new List<string> { "Ramattra", "D.Va", "Roadhog", "Mauga", "Junkrat", "Reaper", "Bastion", "Ana", "Lucio", "Kiriko" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "Antarctic_Peninsula", "Nepal", "Dorado", "Rialto", "Shambali_Monastery", "Eichenwalde", "Hollywood" }
                 },
                 new Hero
                 {
                     Name = "Pharah",
                     Role = Role.DPS,
                     Counters = new List<string> { "D.Va", "Ashe", "Bastion", "Echo", "Sojourn", "Soldier_76", "Widowmaker", "Torbjorn", "Ana", "Juno", "Illari" },
                     Synergies = new List<string> { "Sigma", "JunkerQueen", "Ramattra", "Freja", "Echo", "Junkrat", "Sombra", "Zenyatta", "Lifeweaver", "Mercy" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Ilios", "Oasis", "Circuit_Royal", "Dorado", "Rialto", "Route_66", "Kings_Row" }
                 },
                 new Hero
                 {
                     Name = "Reaper",
                     Role = Role.DPS,
                     Counters = new List<string> { "Zarya", "Orisa", "JunkerQueen", "Reaper", "Cassidy", "Pharah", "Freja", "Sojourn", "Ana", "Kiriko" },
                     Synergies = new List<string> { "Winston", "Ramattra", "Zarya", "Orisa", "Mei", "Bastion", "Venture", "Ana", "Lifeweaver", "Mercy" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "Lijiang_Tower", "Samoa", "Dorado", "Rialto", "eichenwalde", "Paraiso", "Colosseo" }
                 },
                 new Hero
                 {
                     Name = "Sojourn",
                     Role = Role.DPS,
                     Counters = new List<string> { "Winston", "D.Va", "Doomfist", "Wrecking_Ball", "Ashe", "Soldier_76", "Reaper", "Tracer", "Sombra", "Genji", "Ana", "Venture", "Kiriko" },
                     Synergies = new List<string> { "Sigma", "Reinhardt", "Ramattra", "Ashe", "Soldier_76", "Phara", "Torbjorn", "Echo", "Bastion", "Mercy", "Kiriko" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Colosseo", "Esperanca", "New_Queen_Street", "Kings_Row", "Midtown", "Blizzard_World", "Rialto" }
                 },
                 new Hero
                 {
                     Name = "Soldier_76",
                     Role = Role.DPS,
                     Counters = new List<string> { "Winston", "D.Va", "Zarya", "Ashe", "Sojourn", "Mei", "Genji", "Widowmaker", "Tracer", "Sombra", "Ana", "Moira", "Kiriko" },
                     Synergies = new List<string> { "Sigma", "Reinhardt", "Ramattra", "Sojourn", "Freja", "Ashe", "Cassidy", "Ana", "Mercy", "Illari" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Busan", "Nepal", "Oasis", "Circuit_Royal", "Dorado", "Havana", "Eichenwalde" }
                 },
                 new Hero
                 {
                     Name = "Sombra",
                     Role = Role.DPS,
                     Counters = new List<string> { "Winston", "JunkerQueen", "Junkrat", "Phara", "Reaper", "Sombra", "Torbjorn", "Symmetra", "Venture", "Moria", "Brigitte" },
                     Synergies = new List<string> { "Winston", "D.Va", "Wrecking_Ball", "Echo", "Junkrat", "Freja", "Reaper", "Tracer", "Genji", "Kiriko" },
                     PlaystyleTag = PlaystyleTag.Dive,
                     MapPreference = new List<string> { "Blizzard_World", "Hoolywood", "Esperanca", "Suravasa", "Route_66", "Circuit_Royal", "Samoa" }
                 },
                 new Hero
                 {
                     Name = "Symmetra",
                     Role = Role.DPS,
                     Counters = new List<string> { "Winston", "Zarya", "Ramattra", "Ashe", "Reaper", "Sojourn", "Venture", "Phara", "Echo", "Soldier_76", "Mei", "Ana" },
                     Synergies = new List<string> { "Zarya", "Mauga", "Orisa", "Reaper", "Bastion", "Torbjorn", "Mei", "Mercy", "Kiriko", "Moira" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "Rialto", "Junkertown", "Suravasa", "Blizzard_World", "Midtown", "Kings_Row", "Echenwalde" }
                 },
                 new Hero
                 {
                     Name = "Torbjorn",
                     Role = Role.DPS,
                     Counters = new List<string> { "D.Va", "Ramattra", "Zarya", "Orisa", "Ashe", "Bastion", "Reaper", "Genji", "Sombra", "Venture", "Ana", "Kiriko", "Baptiste" },
                     Synergies = new List<string> { "Sigma", "Ramattra", "Reinhardt", "Freja", "Ashe", "Bastion", "Symmetra", "Sojourn", "Echo", "Mercy" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Ilios", "Rialto", "Dorado", "Blizzard_World", "Hollywood", "Kings_Row", "Paraiso" }
                 },
                 new Hero
                 {
                     Name = "Tracer",
                     Role = Role.DPS,
                     Counters = new List<string> { "D.Va", "Winston", "Wrecking_Ball", "Torbjorn", "Symmetra", "Mei", "Reaper", "Venture", "Moira", "Brigitte", "Illari" },
                     Synergies = new List<string> { "Winston", "D.Va", "Wrecking_Ball", "Genji", "Sombra", "Junkrat", "Venture", "Echo", "Lucio", "Moira" },
                     PlaystyleTag = PlaystyleTag.Dive,
                     MapPreference = new List<string> { "Busan", "Oasis", "Havana", "Shambali_Monastery", "Watchpoint_Gibraltar", "Suravasa", "Blizzard_World" }
                 },
                 new Hero
                 {
                     Name = "Venture",
                     Role = Role.DPS,
                     Counters = new List<string> { "Orisa", "Ramattra", "Roadhog", "Bastion", "Torbjorn", "Symmetra", "Echo", "Phara", "Sombra", "Mei", "Reaper", "Ana", "Moira" },
                     Synergies = new List<string> { "Winston", "D.Va", "Wrecking_Ball", "Echo", "Genji", "Tracer", "Sombra", "Ana", "Lucio", "Mercy" },
                     PlaystyleTag = PlaystyleTag.Dive,
                     MapPreference = new List<string> { "Numbani", "Paraiso", "New_Queen_Street", "Blizzard_World", "Hollywood", "New_Junk_City", "Oasis" }
                 },
                 new Hero
                 {
                     Name = "WidowMaker",
                     Role = Role.DPS,
                     Counters = new List<string> { "Winston", "D.Va", "Wrecking_Ball", "Genji", "Sombra", "Tracer", "Venture", "Reaper", "Echo", "Freja", "Moira", "Juno" },
                     Synergies = new List<string> { "Ashe", "Bastion", "Hanzo", "Pharah", "Sojourn", "Soldier_76", "Illari" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Ilios", "Busan", "Circuit_Royal", "Havana", "Blizzard_World", "Kings_Row", "Paraiso" }
                 },
                 //DPS End

                 //Support
                 new Hero
                 {
                     Name = "Ana",
                     Role = Role.Support,
                     Counters = new List<string> { "Winston", "D.Va", "Doomfist", "JunkerQueen", "Freja", "Ashe", "Echo", "Tacer", "Venture", "Genji", "Sombra", "Sojourn", "Kiriko" },
                     Synergies = new List<string> { "Roadhog", "Reinhardt", "Sigma", "Bastion", "Reaper", "Hanzo", "Mei", "Sojourn", "Lifeweaver", "Kiriko" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Nepal", "Havana", "Route_66", "Watchpoint_Gibraltar", "Suravasa", "Blizzard_World", "Hollywood" }
                 },
                 new Hero
                 {
                     Name = "Baptiste",
                     Role = Role.Support,
                     Counters = new List<string> { "Winston", "Zarya", "Orisa", "Freja", "Widowmaker", "Bastion", "Echo", "Mei", "Reaper", "Sombra", "Tracer", "Moira", "Baptiste" },
                     Synergies = new List<string> { "Reinhardt", "Rammatra", "Orisa", "Mauga", "Sojourn", "Soldier_76", "Junkrat", "Lucio", "Kiriko", "Illari" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Numbani", "Kings_Row", "Hollywood", "Dorado", "Havana", "Route_66", "Lijiang_Tower" }
                 },
                 new Hero
                 {
                     Name = "Brigitte",
                     Role = Role.Support,
                     Counters = new List<string> { "Winston", "Ramattra", "Zarya", "Bastion", "Junkrat", "Phara", "Freja", "Echo", "Reaper", "Torbjorn", "Ana", "Moria", "Juno" },
                     Synergies = new List<string> { "Reinhardt", "Rammatra", "Roadhog", "JunkerQueen", "Lucio", "Juno", "Reaper", "Junkrat", "Bastion", "Venture" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "Echenwalde", "Lijiang_Tower", "Nepal", "Oasis", "Dorado", "Shambali_Monastery", "New_Junk_City" }
                 },
                 new Hero
                 {
                     Name = "Illari",
                     Role = Role.Support,
                     Counters = new List<string> { "Winston", "D.Va", "Wrecking_Ball", "Venture", "Tracer", "Sombra", "Genji", "mei", "Bastion", "Ashe", "Freja", "Moira", "Kiriko" },
                     Synergies = new List<string> { "Sigma", "Roadhog", "Ramattra", "Ashe", "Freja", "Bastion", "Widowmaker", "Hanzo", "Sojourn", "Baptiste" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Lijiang_Tower", "Nepal", "Oasis", "Dorado", "Junkertown", "Route_66", "Havana" }
                 },
                 new Hero
                 {
                     Name = "Juno",
                     Role = Role.Support,
                     Counters = new List<string> { "D.Va", "Winston", "Doomfist", "Echo", "Torbjorn", "Symmetra", "Sojourn", "Soldier_76", "Widowmaker", "Sombra", "Venture", "Moira", "Kiriko" },
                     Synergies = new List<string> { "Ramattra", "Reinhardt", "Zarya", "Roadhog", "Reaper", "Junkrat", "Mei", "Cassidy", "Lucio", "Brigitte" },
                     PlaystyleTag = PlaystyleTag.Brawl,
                     MapPreference = new List<string> { "Rialto", "Kings_Row", "Blizzard_World", "EchenWalde", "Dorado", "Lijiang_Tower", "Numbani" }
                 },
                 new Hero
                 {
                     Name = "Kiriko",
                     Role = Role.Support,
                     Counters = new List<string> { "Winston", "D.Va", "Doomfist", "Hazard", "Tracer", "Sombra", "Genji", "Reaper", "Sojourn", "Widowmaker", "Soldier_76", "Kiriko", "Moira" },
                     Synergies = new List<string> { "D.Va", "Winston", "Roadhog", "Orisa", "Mauga", "Reaper", "Ashe", "Bastion", "Ana", "Moria" },
                     PlaystyleTag = PlaystyleTag.Hybrid,
                     MapPreference = new List<string> { "Kings_Row", "Hollywood", "Paraiso", "Midtown", "Dorado", "Havana", "Rialto" }
                 },
                 new Hero
                 {
                     Name = "Lifeweaver",
                     Role = Role.Support,
                     Counters = new List<string> { "Winston", "Doomfist", "D.Va", "Wrecking_Ball", "Freja", "Ashe", "Sombra", "Phara", "Echo", "Widowmaker", "Venture", "Ana", "Moira" },
                     Synergies = new List<string> { "Winston", "D.Va", "Doomfist", "Roadhog", "Ramattra", "Mauga", "Reaper", "Junkrat", "Kiriko", "Moira" },
                     PlaystyleTag = PlaystyleTag.Hybrid,
                     MapPreference = new List<string> { "Rialto", "Havana", "Blizzard_World", "Kings_Row", "Paraiso", "Midtown", "Numbani" }
                 },
                 new Hero
                 {
                     Name = "Lucio",
                     Role = Role.Support,
                     Counters = new List<string> { "D.Va", "Winston", "Wrecking_Ball", "JunkerQueen", "Orisa", "Torbjorn", "Symmetra", "Phara", "Mei", "Reaper", "Ana", "Brigitte", "Moira" },
                     Synergies = new List<string> { "Ramattra", "Reinhardt", "JunkerQueen", "Orisa", "Echo", "Genji", "Tracer", "Reaper", "Brigitte", "Venture" },
                     PlaystyleTag = PlaystyleTag.Dive,
                     MapPreference = new List<string> { "Kings_Row", "Colosseo", "Suravasa", "Rialto", "Ilios", "Lijiang_Tower", "Midtown" }
                 },
                 new Hero
                 {
                     Name = "Mercy",
                     Role = Role.Support,
                     Counters = new List<string> { "D.Va", "Winston", "Freja", "Ashe", "Soldier_76", "Sojourn", "Torbjorn", "Symmetra", "Echo", "Widowmaker", "Sombra", "Moira", "Ana" },
                     Synergies = new List<string> { "Sigma", "Ramattra", "Roadhog", "Ashe", "Feja", "Sojourn", "Echo", "Phara", "Reaper", "Kiriko" },
                     PlaystyleTag = PlaystyleTag.Poke,
                     MapPreference = new List<string> { "Blizzard_World", "Eichenwalde", "Kings_Row", "New_Junk_City", "Route_66", "Rialto", "Dorado" }
                 },
                 new Hero
                 {
                     Name = "Moira",
                     Role = Role.Support,
                     Counters = new List<string> { "Zarya", "Roadhog", "D.Va", "Ashe", "Freja", "Bastion", "Mei", "Reaper", "Sojourn", "Soldier_76", "Ana", "Kiriko", "Zenyatta" },
                     Synergies = new List<string> { "Winston", "D.Va", "Doomfist", "Hazard", "Tracer", "Sombra", "Genji", "Venture", "Lucio", "Lifeweaver" },
                     PlaystyleTag = PlaystyleTag.Dive,
                     MapPreference = new List<string> { "Kings_Row", "Suravasa", "Ilios", "Rialto", "Numbani", "Shambali_Monastery", "Route_66" }
                 },
                 new Hero
                 {
                     Name = "Zenyatta",
                     Role = Role.Support,
                     Counters = new List<string> { "Winston", "D.Va", "Hazard", "Doomfist", "Zarya", "Tracer", "Sombra", "Ashe", "Echo", "Bastion", "Moira", "Ana", "Kiriko" },
                     Synergies = new List<string> { "Reinhardt", "Roadhog", "Orisa", "D.Va", "Winston", "Reaper", "Ashe", "Mei", "Moria", "Kiriko" },
                     PlaystyleTag = PlaystyleTag.Hybrid,
                     MapPreference = new List<string> { "Shambali_Monastery", "Blizzard_World", "Kings_Row", "Midtown", "Esperanca", "Runasapi", "Colosseo" }
                 }
                 //Support End
            };
        }
    }
}
