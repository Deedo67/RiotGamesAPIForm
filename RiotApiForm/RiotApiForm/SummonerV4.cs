using System;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace RiotApiForm
{
    public class SummonerV4
    {
        private static readonly Uri ApiBaseAddress = new Uri(".api.riotgames.com/lol/summoner/v4/summoners");

        private RiotApi Api { get; }

        public SummonerV4(RiotApi api)
        {
            Api = api;
        }

        public Summoner GetSummonerByName(string regionSearch, string summonerName)
        {
            /*On Riot: https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/Derektg is string for looking up
              my summoner by name, UriBuilder will fill in a similar string but allow the user to use their own Api
              code and fill in their own summoner name*/

            var uriBuilder = new UriBuilder($"https://{regionSearch}{ApiBaseAddress}/by-name/{summonerName}");
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["api_key"] = Api.ApiKey;
            uriBuilder.Query = query.ToString();
            string requestUri = uriBuilder.ToString();

            var response = Api.Client.GetAsync(requestUri).Result;
            //throw an error message out of status code success is false!
            if (response.IsSuccessStatusCode == false)
            {
                throw new Exception($"Request failed. Response: {response.StatusCode}");
            }

            string jsonResponse = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Summoner>(jsonResponse);
        }

        public async Task<Summoner> GetSummonerByNameAsync(string summonerName)
        {
            var uriBuilder = new UriBuilder($"{ApiBaseAddress}/by-name/{summonerName}");
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["api_key"] = Api.ApiKey;
            uriBuilder.Query = query.ToString();
            string requestUri = uriBuilder.ToString();

            var response = await Api.Client.GetAsync(requestUri);
            //throw an error message out of status code success is false!
            if (response.IsSuccessStatusCode == false)
            {
                throw new Exception($"Request failed. Response: {response.StatusCode}");
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();
            return await Task.Run<Summoner>(() => JsonConvert.DeserializeObject<Summoner>(jsonResponse));
        }
    }
}
