using AdminFrontEnd.Models;
using MassTransit;
using MessagingAPI;
using MessagingAPI.Product;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdminFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private IRequestClient<GetProductRequest> _getProductClient;

        public HomeController(IRequestClient<GetProductRequest> getProductClient)
        {
            _getProductClient = getProductClient;
        }
        public async Task<IActionResult> Index()
        {
            var response = await _getProductClient.GetResponse<GetProductResponse>(new GetProductRequest());
            return View(response.Message);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
