using Microsoft.AspNetCore.Mvc;
using Overwatch_2_Suggestions;
using System.Collections.Generic;
using System.Linq;

namespace Overwatch_2_Suggestions.Controllers
{
    public class TeamBuilderController : Controller
    {

        public IActionResult Index()
        {
            var allHeroes = HeroRepository.GetHeroes();

            var enemyTeam = HttpContext.Session.GetObject<List<string>>("EnemyTeam") ?? new List<string>();
            var selectedMap = HttpContext.Session.GetString("SelectedMap") ?? "Kings_Row";

            var map = MapRepository.GetMaps().FirstOrDefault(m => m.Name.ToString() == selectedMap);
            var scored = SuggestionEngine.ScoreHeroes(
                allHeroes,
                enemyTeam,
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
            ViewBag.SelectedMap = selectedMap;
            ViewBag.EnemyTeam = enemyTeam;
            ViewBag.SuggestedTeam = suggested;

            return View();
        }

        [HttpPost]
        [HttpPost]
        public IActionResult AddEnemy([FromBody] HeroInput input)
        {
            var enemyTeam = HttpContext.Session.GetObject<List<string>>("EnemyTeam") ?? new List<string>();

            if (enemyTeam.Count < 5 && !enemyTeam.Contains(input.HeroName))
            {
                enemyTeam.Add(input.HeroName);
                HttpContext.Session.SetObject("EnemyTeam", enemyTeam); // save updated list
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult UpdateEnemyTeamSlot(int slotIndex, string heroName)
        {
            var enemyTeam = HttpContext.Session.GetObject<List<string>>("EnemyTeam") ?? new List<string>();

            while (enemyTeam.Count <= slotIndex)
                enemyTeam.Add(null);

            enemyTeam[slotIndex] = heroName;
            HttpContext.Session.SetObject("EnemyTeam", enemyTeam); // save back

            return Ok();
        }

        [HttpPost]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear(); // Clears all session data (enemy team, map, etc.)
            return RedirectToAction("Index");
        }

        public class HeroInput
        {
            public string HeroName { get; set; }
        }

        [HttpPost]
        public IActionResult SetMap(string mapName)
        {
            HttpContext.Session.SetString("SelectedMap", mapName);
            return RedirectToAction("Index");
        }
    }
}
