using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.IO;
using Pop1_Stats_Collector.UserInterfaces;

namespace Pop1_Stats_Collector
{
    public class PlayerStats
    {
        public static object gameId;
        public string name;
        public string playerCode { get; set; }

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
            if (user.Any() == false) { Console.WriteLine("Input Not Valid"); await StartingUserInterface.MenuLoop(); };
            var gameName = user[0].displayName;
            var playerCode = user[0].playFabId;
            
            Console.WriteLine($"Statistics for {gameName}");
            Console.WriteLine("-----------------------------");

            return playerCode;                 
        }

        public static async Task PullStats(object playerA, string playerCode, string path)
        {
            var baseUrl = "https://nykloo.com/api/PlayerStats/Stats/";
            var client = new HttpClient();
            var responseId = await client.GetAsync($"{baseUrl}{playerCode}");
            var responseBody = await responseId.Content.ReadAsStringAsync();
            var userStats = JsonConvert.DeserializeObject<PlayerStatsResponse>(responseBody);
            string name2 = userStats.AccountInfo.TitleInfo.DisplayName;
        
            
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
  
            long? winStatVal;
            if (winStat != null) winStatVal = winStat.Value; else winStatVal = 0;
            long? playerSkillVal;
            if (playerSkill != null) playerSkillVal = playerSkill.Value; else playerSkillVal = 0;
            long? careerGamesPlayedVal;
            if (careerGamesPlayed != null) careerGamesPlayedVal = careerGamesPlayed.Value; else careerGamesPlayedVal = 0;
            long? careerWinsVal;
            if (careerWins != null) careerWinsVal = careerWins.Value; else careerWinsVal = 0;
            long? seasonWinsVal;
            if (seasonWins != null) seasonWinsVal = seasonWins.Value; else seasonWinsVal = 0;
            long? weeklyKillsVal;
            if (weeklyKills != null) { weeklyKillsVal = weeklyKills.Value; } else weeklyKillsVal = 0;
            long? careerKillsVal;
            if (careerKills != null) careerKillsVal = careerKills.Value; else careerKillsVal = 0;
            long? MMR1Val;
            if (MMR1 != null) MMR1Val = MMR1.Value; else MMR1Val = 0;
                       

            Console.WriteLine($"Weekly Wins : {winStatVal}");
            Console.WriteLine($"Player Skill: {playerSkillVal}");
            Console.WriteLine($"Career Games: {careerGamesPlayedVal}");
            Console.WriteLine($"Career Wins : {careerWinsVal}");
            Console.WriteLine($"Season Wins : {seasonWinsVal}");
            Console.WriteLine($"Weekly Kills: {weeklyKillsVal}");
            Console.WriteLine($"Career Kills: {careerKillsVal}");
            Console.WriteLine($"MMR1        : {MMR1Val}");
            Console.WriteLine("");
            
            string winStatString = winStatVal.ToString();
            string playerSKillString = playerSkillVal.ToString();
            string weeklyKillString =  weeklyKillsVal.ToString();                       
            
            string textString = ($"{name2} - Weekly Wins: {winStatString} Player Skill: {playerSKillString} Weekly Kills: {weeklyKillString}");

            Console.WriteLine(textString);
            File.WriteAllText(path, textString);
            
        }

        internal static Task PullStats(object playerCode)
        {
            throw new NotImplementedException();
        }
    }
}
