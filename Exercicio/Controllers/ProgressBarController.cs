using Exercicio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Exercicio.Controllers
{
    public class ProgressBarController : Controller
    {
        private readonly ProgressBar _progressBar;

        public ProgressBarController(ProgressBar progressBar)
        {
            _progressBar = progressBar;
        }
        public IActionResult Index()
        {
            return PartialView(_progressBar);
        }
    }
}
