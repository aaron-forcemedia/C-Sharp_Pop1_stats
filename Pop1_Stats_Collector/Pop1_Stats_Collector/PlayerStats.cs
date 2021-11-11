using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace Pop1_Stats_Collector
{
    public class PlayerStats
    {
        public static object gameId;
        public string playerCode;

        public static async Task<string> PullFabId() 
        {
            Console.WriteLine("Enter a name:");
            string name;
            name = Console.ReadLine();
            
            var baseUrl = "https://nykloo.com/api/PlayerInfos/Search?usernameQuery=";
            var client = new HttpClient();
            var responseId = client.GetAsync($"{baseUrl}{name}").Result;
            var responseBody = await responseId.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<List<GetUserId>>(responseBody);
            var gameName = user[0].displayName;
            var playerCode = user[0].playFabId;
            Console.WriteLine($"Statistics for {gameName}");
            return playerCode; 
        }

        public static async Task PullStats(string playerCode)
        {
            var baseUrl = "https://nykloo.com/api/PlayerStats/Stats/";
            var client = new HttpClient();
            var responseId = await client.GetAsync($"{baseUrl}{playerCode}");
            var responseBody = await responseId.Content.ReadAsStringAsync();
            var userStats = JsonConvert.DeserializeObject<PlayerStatsResponse>(responseBody);
            
            var winStat = userStats.PlayerStatistics
                .FirstOrDefault(x => x.StatisticName == "WeeklyWinsTotal");
            var playerSkill = userStats.PlayerStatistics
                .FirstOrDefault(x => x.StatisticName == "PlayerSkill");
            var careerGamesPlayed = userStats.PlayerStatistics
                .FirstOrDefault(x => x.StatisticName == "CareerGamesPlayed");
            var careerWins = userStats.PlayerStatistics
                .FirstOrDefault(x => x.StatisticName == "CareerWins");
            var seasonWins = userStats.PlayerStatistics
                .FirstOrDefault(x => x.StatisticName == "SeasonWins");
            var weeklyKills = userStats.PlayerStatistics
                .FirstOrDefault(x => x.StatisticName == "WeeklyKillsTotal");
            var careerKills = userStats.PlayerStatistics
                .FirstOrDefault(x => x.StatisticName == "CareerKills");
            var MMR1 = userStats.PlayerStatistics
                .FirstOrDefault(x => x.StatisticName == "MMR1");

            var winStatVal = winStat.Value;
            var playerSkillVal = playerSkill.Value;
            var careerGamesPlayedVal = careerGamesPlayed.Value;
            var careerWinsVal = careerWins.Value;
            var seasonWinsVal = seasonWins.Value;
            var weeklyKillsVal = weeklyKills.Value;
            var careerKillsVal = careerKills.Value;
            var MMR1Val = MMR1.Value;


            Console.WriteLine($"Weekly Wins : {winStatVal}");
            Console.WriteLine($"Player Skill: {playerSkillVal}");
            Console.WriteLine($"Career Games: {careerGamesPlayedVal}");
            Console.WriteLine($"Career Wins : {careerWinsVal}");
            Console.WriteLine($"Season Wins : {seasonWinsVal}");
            Console.WriteLine($"Weekly Kills: {weeklyKillsVal}");
            Console.WriteLine($"Career Kills: {careerKillsVal}");
            Console.WriteLine($"MMR1        : {MMR1Val}");


        }

        internal static Task PullStats(object playerCode)
        {
            throw new NotImplementedException();
        }
    }
}
