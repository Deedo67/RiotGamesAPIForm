using Newtonsoft.Json;

namespace RiotApiForm
{
    public class Summoner
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("accountId")]
        public string AccountID { get; set; }

        [JsonProperty("puuid")]
        public string PuuID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        [JsonProperty("revisionDate")]
        //Signed 64-bit integer is long
        public long RevisionDate { get; set; }

        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }


    }
}
