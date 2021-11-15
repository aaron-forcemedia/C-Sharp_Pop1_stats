using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.IO;

namespace Pop1_Stats_Collector.UserInterfaces
{
        public partial class TitleInfo
        {
            [JsonProperty("avatarUrl")]
            public string AvatarUrl { get; set; }

            [JsonProperty("created")]
            public DateTimeOffset Created { get; set; }

            [JsonProperty("displayName")]
            public string DisplayName { get; set; }

            [JsonProperty("firstLogin")]
            public DateTimeOffset FirstLogin { get; set; }

            [JsonProperty("isBanned")]
            public bool IsBanned { get; set; }

            [JsonProperty("lastLogin")]
            public DateTimeOffset LastLogin { get; set; }

            [JsonProperty("origination")]
            public long Origination { get; set; }

        }
    
}
