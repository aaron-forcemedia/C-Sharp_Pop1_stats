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
        private static object gameId;

        public static async Task PullFabId() 
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
            var gameId = userFabId[0].playFabId;
            Console.WriteLine(gameName);
            Console.WriteLine(gameId);
            //Console.WriteLine(responseBody);
            return gameId; 
        }

        public static async Task PullStats()
        {
            var baseUrl = "https://nykloo.com/api/PlayerStats/Stats/";
            var client = new HttpClient();
            var responseId = client.GetAsync($"{baseUrl}/{gameId}").Result;
            var responseBody = await responseId.Content.ReadAsStringAsync();
            var userStats = JsonConvert.DeserializeObject<List<GetStats>>(responseBody);
            Console.WriteLine(userStats);
            
        }

    }
}
