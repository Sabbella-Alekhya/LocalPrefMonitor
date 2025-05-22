using System.Collections.Generic;
using System.Linq;

namespace PerfDashboard.Services
{
    public class MetricsStorage
    {
        private readonly List<string> _data = new List<string>();

        public void Store(string metric)
        {
            _data.Add(metric);
        }

        public List<string> GetData()
        {
            return _data.ToList();
        }

        // ✅ NEW: Add this method if your controller uses GetAll
        public IEnumerable<string> GetAll()
        {
            return _data.ToList();
        }
    }
}
