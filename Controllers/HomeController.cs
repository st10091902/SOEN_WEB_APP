using Microsoft.AspNetCore.Mvc;
using SOEN_WEB_APP.Models;
using System.Diagnostics;

namespace SOEN_WEB_APP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Login()
        {
            return View("Login");
        }

        public IActionResult DashboardVolunteer()
        {
            return View("dashboard-volunteer");
        }

        public IActionResult DashboardDonor()
        {
            return View("dashboard-donor");
        }

        public IActionResult ProjectManagement()
        {
            return View("project-management");
        }

        public IActionResult ImpactReport()
        {
            return View("impact-report");
        }
    }

}