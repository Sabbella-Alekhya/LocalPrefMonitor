using Microsoft.AspNetCore.Mvc;
using PerfDashboard.Services;

namespace PerfDashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly MetricsStorage _metricsStorage;

        public HomeController(MetricsStorage metricsStorage)
        {
            _metricsStorage = metricsStorage;
        }

        public IActionResult Index()
        {
            var data = _metricsStorage.GetData();
            return View(data);
        }
    }
}
