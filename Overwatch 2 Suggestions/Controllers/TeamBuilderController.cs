using Microsoft.AspNetCore.Mvc;
using Overwatch_2_Suggestions;

namespace Overwatch_2_Suggestions.Controllers
{
    public class TeamBuilderController : Controller
    {
        public static List<string> EnemyTeam = new();
        public static string SelectedMap = "Kings_Row";

        public IActionResult Index()
        {
            var allHeroes = HeroRepository.GetHeroes();
            var map = MapRepository.GetMaps().FirstOrDefault(m => m.Name.ToString() == SelectedMap);
            var scored = SuggestionEngine.ScoreHeroes(
                allHeroes,
                EnemyTeam,
                map,

    new List<Hero>());

            // Get best 1 Tank
            var bestTank = scored
                .Where(h => h.Hero.Role == Role.Tank)
                .Take(1)
                .ToList();

            // Get top 2 DPS
            var bestDPS = scored
                .Where(h => h.Hero.Role == Role.DPS)
                .Take(2)
                .ToList();

            // Get top 2 Supports
            var bestSupports = scored
                .Where(h => h.Hero.Role == Role.Support)
                .Take(2)
                .ToList();

            // Combine results
            var suggested = bestTank
                .Concat(bestDPS)
                .Concat(bestSupports)
                .Select(hs => hs.Hero)
                .ToList();

            ViewBag.AllHeroes = allHeroes;
            ViewBag.Maps = MapRepository.GetMaps();
            ViewBag.SelectedMap = SelectedMap;
            ViewBag.EnemyTeam = EnemyTeam;
            ViewBag.SuggestedTeam = suggested;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEnemy([FromBody] HeroInput input)
        {
            if (EnemyTeam.Count < 5 && !EnemyTeam.Contains(input.HeroName))
            {
                EnemyTeam.Add(input.HeroName);
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult UpdateEnemyTeamSlot(int slotIndex, string heroName)
        {
            while (EnemyTeam.Count <= slotIndex)
                EnemyTeam.Add(null);

            EnemyTeam[slotIndex] = heroName;
            return Ok();
        }

        public class HeroInput
        {
            public string HeroName { get; set; }
        }

        [HttpPost]
        public IActionResult SetMap(string mapName)
        {
            SelectedMap = mapName;
            return RedirectToAction("Index");
        }
    }
}
