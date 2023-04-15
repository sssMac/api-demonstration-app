using api_demonstration_app.Models;
using api_demonstration_app.Models.Json;
using api_demonstration_app.Services;
using Microsoft.AspNetCore.Mvc;

namespace api_demonstration_app.Controllers
{
	public class HomeController : Controller
	{
		private readonly ICertificateService _certificateService;
		public HomeController(ICertificateService certificateService)
		{
			_certificateService = certificateService;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
            await _certificateService.GenerateToken();

            return View();
		}


		[HttpPost]
        public async Task<IActionResult> Index(int id)
        {
            var response = await _certificateService.GetCertificateData(id);

            return View(response);
        }
        
	}
}