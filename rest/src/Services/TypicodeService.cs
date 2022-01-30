using System.Net.Http.Headers;
using System.Collections;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using Microsoft.Net.Http.Headers;
using rest.src.Models;

namespace rest.src.Services
{
    public class TypicodeService
    {
        private readonly HttpClient _httpClient;
        private string _clientId;
        private string _clientSecret;

        public TypicodeService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            _httpClient.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/json");
            _httpClient.DefaultRequestHeaders.Add(HeaderNames.UserAgent, "HttpRequestsSample");

            _clientId = configuration.GetValue<string>("ClientId");
            _clientSecret = configuration.GetValue<string>("ClientSecret");
        }

        public async Task<User?> GetUsersAsync()
        {
            return await _httpClient.GetFromJsonAsync<User>("users");
        }

    }
}