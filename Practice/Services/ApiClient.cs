using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Practice.Services
{
    public class ApiClient
    {
        private readonly HttpClient httpClient;

        public ApiClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<datamodels.DataModel[]> GetData()
        {
            return await httpClient.GetFromJsonAsync<Models.DataModel[]>("https://www.alphavantage.co/query?function=TOP_GAINERS_LOSERS&apikey=8IRABS7SCLY1UNPR");
        }
    }
}

