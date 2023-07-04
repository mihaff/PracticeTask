using System.Net.Http;
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

        public async Task<Models.DataModel[]> GetData()
        {
            return await httpClient.GetJsonAsync<Models.DataModel[]>("api/data");
        }
    }
}

