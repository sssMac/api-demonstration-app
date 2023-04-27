using api_demonstration_app.Models;
using api_demonstration_app.Models.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text.Json;

namespace api_demonstration_app.Services
{
    public class CertificateService : ICertificateService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;
        public CertificateService(HttpClient httpClient, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }

        // GET: generate JWT token
        public async Task<string> GenerateToken()
        {
            var token = RetrieveCachedToken();

            if (string.IsNullOrWhiteSpace(token))
            {
                var httpRequestMessage = new HttpRequestMessage(
                HttpMethod.Get,
                _configuration.GetValue<string>("Itcom:Authorization"))
                {
                    Headers =
                    {
                        { HeaderNames.Authorization, _configuration.GetValue<string>("Itcom:AuthToken") },
                    },
                };

                var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage);

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    token = await httpResponseMessage.Content.ReadAsStringAsync();
                    SetCacheToken(token);
                }
            }

            return token;

        }

        // GET: retrieving certificate
        public async Task<BaseResponse<Certificate>> GetCertificateData(int id)
        {
            var httpRequestMessage = new HttpRequestMessage(
            HttpMethod.Get,
            _configuration.GetValue<string>("Itcom:Resource") + $"/{id}")
            {
                Headers =
                {
                    { HeaderNames.Authorization, RetrieveCachedToken() },
                },
            };

            var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
                var certificate = JsonConvert.DeserializeObject<Certificate>(responseBody);

                if (certificate.Data != null)
                    return BaseResponse<Certificate>.Succeed(certificate);
            }

            return BaseResponse<Certificate>.Failed("Fetching failed!"); ;
        }

        private void SetCacheToken(string token)
        {
            Environment.SetEnvironmentVariable("token", "Bearer " + token);
        }

        private string RetrieveCachedToken()
        {
            return Environment.GetEnvironmentVariable("token");
        }
    }
}
