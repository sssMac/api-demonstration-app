using System.Net.Http;

namespace api_demonstration_app.Services
{
    public class SignatureSerivce
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;
        public SignatureSerivce(HttpClient httpClient, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }

        public async Task CreateStatement()
        {

        }

        public async Task UploadArhcive()
        {

        }

        public async Task DownloadFile()
        {

        }
        public async Task GetDetails()
        {

        }

        public async Task GetStatementStatus()
        {

        }
    }
}
