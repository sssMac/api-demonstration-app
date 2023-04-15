using api_demonstration_app.Models;
using api_demonstration_app.Models.Json;

namespace api_demonstration_app.Services
{
    public interface ICertificateService
    {
        Task<string> GenerateToken();
        Task<BaseResponse<Certificate>> GetCertificateData(int id);
    }
}