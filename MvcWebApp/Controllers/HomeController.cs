using Microsoft.AspNetCore.Mvc;
using MvcMongoApp.Models;
using MvcMongoApp.Services;


namespace MvcMongoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserLogService _userLogService;

        public HomeController(UserLogService userLogService)
        {
            _userLogService = userLogService;
        }

        public IActionResult Index()
        {
            // Log the visit with the user's IP address
            var ipAddress = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "Unknown";
            _userLogService.AddUserLog(ipAddress);
            return View();
        }

        public IActionResult Privacy()
        {
            // Retrieve the latest 5 logs and send them to the view
            List<UserLog> latestLogs = _userLogService.GetLatestLogs();
            return View(latestLogs);
        }
    }
}
