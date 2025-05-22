using Microsoft.AspNetCore.Mvc;
using PerfDashboard.Services;

namespace PerfDashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MetricsController : ControllerBase
    {
        private readonly MetricsStorage _storage;

        public MetricsController(MetricsStorage storage)
        {
            _storage = storage;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _storage.GetAll();  // ✅ Uses the new method
            return Ok(data);
        }
    }
}
