using System.Net.Http;
using System.Net.Http.Headers;

namespace RiotApiForm
{
    public class RiotApi
    {
        public readonly string ApiKey;

        public static readonly string ApiBaseAddressSansRegion = "https://{region}.api.riotgames.com";

        public SummonerV4 SummonerV4 { get; }

        public HttpClient Client { get; }

        public Regions Region { get; set; }

        public RiotApi(string apiKey)
        {
            ApiKey = apiKey;

            Client = new HttpClient
            {
                MaxResponseContentBufferSize = 256000
            };
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            SummonerV4 = new SummonerV4(this);
        }
    }
}
