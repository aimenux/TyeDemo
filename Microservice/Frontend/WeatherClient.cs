using Backend.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Frontend
{
    public class WeatherClient
    {
        private readonly string _requestUrl;
        private readonly HttpClient _client;

        private readonly JsonSerializerOptions _options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        public WeatherClient(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _requestUrl = configuration.GetValue<string>("BackendService:RequestUrl");
        }

        public async Task<WeatherForecast[]> GetWeatherAsync()
        {
            var responseMessage = await _client.GetAsync(_requestUrl);
            var stream = await responseMessage.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<WeatherForecast[]>(stream, _options);
        }
    }
}
