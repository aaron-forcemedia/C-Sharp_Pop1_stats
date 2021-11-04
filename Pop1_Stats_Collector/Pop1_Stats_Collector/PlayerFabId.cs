using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.linq;
using System.Net.Http;

namespace Pop1_Stats_Collector
{
    public class PlayerFabId
    {
  
        public static async Task PullFabId() 
        {
            var baseUrl = "https://nykloo.com/api/PlayerInfos/Search?usernameQuery=Zoloto&page=0&pageSize=25";
            var client = new HttpClient();
            var responseId = client.GetAsync($"{baseUrl}").Result;
            var responseBody = await responseId.Content.ReadAsStringAsync();
            var userFabId = JsonConvert.DeserializeObject<GetUserId>(responseBody);
            Console.WriteLine(userFabId.playFabId);
        }

    }
}
