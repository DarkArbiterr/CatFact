using System.Threading.Tasks;

namespace CatFact.Interfaces
{
    /// <summary>
    /// Interfejs usługi wysyłania HTTP Request
    /// </summary>
    public interface IHttpClientService
    {
        /// <summary>
        /// Pobranie tekstu z endpointu
        /// </summary>
        /// <returns></returns>
        Task<string> GetCatFact();
    }
}
