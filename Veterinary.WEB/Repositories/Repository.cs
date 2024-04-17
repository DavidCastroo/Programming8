
using System.Text.Json;

namespace Veterinary.WEB.Repositories
{
    public class Repository : IRepository
    {

        private readonly HttpClient _httpClient;
        private JsonSerializerOptions _jsonSerializerOptions => new JsonSerializerOptions{

             PropertyNameCaseInsensitive = true

            };

        public Task<HttpResponseWrapper<T>> GetAsync<T>(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<object>> Post<T>(string url, T model)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T model)
        {
            throw new NotImplementedException();
        }
    }
}
