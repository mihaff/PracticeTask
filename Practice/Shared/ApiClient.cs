using System.Net.Http;
using System.Threading.Tasks;

namespace Practice.Shared
{
    public class ApiClient
    {
        private readonly HttpClient httpClient;

        public ApiClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<DataModel[]> GetData()
        {
            return await httpClient.GetJsonAsync<DataModel[]>("api/data");
        }
    }
}
