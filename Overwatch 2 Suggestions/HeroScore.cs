namespace Overwatch_2_Suggestions
{
    public class HeroScore
    {
        public Hero Hero { get; set; }
        public int Score { get; set; } = 0;
    }

    public static class SuggestionEngine
    {
        //Weights

        private const int CounterWeight = 10;
        private const int MapPreferenceWeight = 5;
        private const int PlaystyleMatchWeight = 3;
        private const int SynergyWeight = 4;
        private const int CounteredPenalty = 7;

        //Scores heroes based on enemy comp, map, and current team composition.
        
        public static List<HeroScore> ScoreHeroes(
            List<Hero> allHeroes,
            List<string> enemyHeroNames,
            Map currentMap,
            List<Hero> currentTeamHeroes)
        {
            var scoredHeroes = new List<HeroScore>();

            foreach (var hero in allHeroes)
            {
                int score = 0;

                //Subtract score if this hero is countered by anyone on the enemy team

                int counteredByCount = hero.Counters.Count(enemy => enemyHeroNames.Contains(enemy));
                score -= counteredByCount * CounteredPenalty;

                //Add score if this hero counters any enemy heroes

                int countersEnemyCount = enemyHeroNames.Count(enemyName =>
                {
                    var enemyHero = allHeroes.FirstOrDefault(h => h.Name == enemyName);
                    return enemyHero != null && enemyHero.Counters.Contains(hero.Name);
                });
                score += countersEnemyCount * CounterWeight;

                //Map preference

                if (hero.MapPreference.Contains(currentMap.Name.ToString()))
                    score += MapPreferenceWeight;

                //Playstyle match

                if (hero.PlaystyleTag.ToString() == currentMap.Playstyle.ToString())
                    score += PlaystyleMatchWeight;

                //Synergy with current team

                int synergyCount = hero.Synergies.Count(s => currentTeamHeroes.Any(t => t.Name == s));
                score += synergyCount * SynergyWeight;

                scoredHeroes.Add(new HeroScore
                {
                    Hero = hero,
                    Score = score
                });
            }
            return scoredHeroes.OrderByDescending(hs => hs.Score).ToList();
        }
    }
}

