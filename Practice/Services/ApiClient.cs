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

        public async Task<Models.DataModel[]> GetData()
        {
            return await httpClient.GetFromJsonAsync<Models.DataModel[]>("api/data");
        }
    }
}

