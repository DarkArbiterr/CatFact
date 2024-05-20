using System.Net.Http;
using System.Threading.Tasks;
using CatFact.Interfaces;

namespace CatFact.Services
{
    public class HttpClientService : IHttpClientService
    {
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Konstruktor wstrzykujący `HttpClient`
        /// </summary>
        /// <param name="httpClient">Instancja HttpClient</param>
        public HttpClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Pobranie faktu o kotach z endpointu
        /// </summary>
        /// <returns>Treść odpowiedzi z endpointu</returns>
        public async Task<string> GetCatFact()
        {
            var response = await _httpClient.GetStringAsync("https://catfact.ninja/fact");
            return response;
        }
    }
}
