namespace Pop1_Stats_Collector
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class PlayerStatsResponse
    {
        [JsonProperty("playerStatistics")]
        public PlayerStatistic[] PlayerStatistics { get; set; }
    }

    public partial class PlayerStatistic
    {
        [JsonProperty("statisticName")]
        public string StatisticName { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }
    }
    public partial class PlayerProfile
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
                
    }
}