using Exercicio.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace Exercicio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProgressBar _progressBar;

        public HomeController(ProgressBar progressBar)
        {
            _progressBar = progressBar;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> MinhaAcao()
        {
            _progressBar.Progresso = 0;

            for (int i = 0; i < 100; i++)
            {
                _progressBar.Progresso = i + 1;
                await Task.Delay(100);

                if(i == 99)
                {
                    return Json(new { progress = "Ok" });
                }
            }
            return new EmptyResult();
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