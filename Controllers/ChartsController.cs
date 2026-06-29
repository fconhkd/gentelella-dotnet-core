using Microsoft.AspNetCore.Mvc;

namespace Gentelella2.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult ChartJs2()
        {
            return Redirect("~/gentelella/production/chartjs.html");
        }

        public IActionResult ECharts()
        {
            return Redirect("~/gentelella/production/echarts.html");
        }

        public IActionResult Index()
        {
            return Redirect("~/gentelella/production/chartjs.html");
        }

        public IActionResult MorisJs()
        {
            return Redirect("~/gentelella/production/other_charts.html");
        }

        public IActionResult Other()
        {
            return Redirect("~/gentelella/production/other_charts.html");
        }
    }
}
