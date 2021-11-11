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
        private static int playerStatistics;
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
            var userFabId = JsonConvert.DeserializeObject<List<GetUserId>>(responseBody);
            var gameName = userFabId[0].displayName;
            var playerCode = userFabId[0].playFabId;
            Console.WriteLine(gameName);
            //Console.WriteLine(playerCode);
            //Console.WriteLine(responseBody);
            return playerCode; 
        }

        public static async Task PullStats(string playerCode)
        {
            Console.WriteLine(playerCode);
            var baseUrl = "https://nykloo.com/api/PlayerStats/Stats/";
            var client = new HttpClient();
            var responseId = await client.GetAsync($"{baseUrl}{playerCode}");
            var responseBody = await responseId.Content.ReadAsStringAsync();
            var userStats = JsonConvert.DeserializeObject<PlayerStatsResponse>(responseBody);
            var winstat = userStats.PlayerStatistics
                .FirstOrDefault(x => x.StatisticName == "WeeklyWinsTotal");

           Console.WriteLine(winstat.Value);
            
        }

        internal static Task PullStats(object playerCode)
        {
            throw new NotImplementedException();
        }
    }
}
