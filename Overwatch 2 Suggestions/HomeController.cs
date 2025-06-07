using Microsoft.AspNetCore.Mvc;

namespace Overwatch_2_Suggestions
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var allHeroes = HeroRepository.GetHeroes();
            var allMaps = MapRepository.GetMaps();

            var currentMap = allMaps.First(m => m.Name == MapName.Kings_Row);

            var enemyTeam = new List<string> { "Widowmaker", "Sigma", "Pharah" };
            var currentTeam = new List<Hero> { allHeroes.First(h => h.Name == "Ana") };

            var scoredHeroes = SuggestionEngine.ScoreHeroes(allHeroes, enemyTeam, currentMap, currentTeam);

            return Json(scoredHeroes.Select(hs => new
            {
                hs.Hero.Name,
                hs.Hero.Role,
                hs.Score
            }));
        }
    }
}
