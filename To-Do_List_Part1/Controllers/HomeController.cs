using Microsoft.AspNetCore.Mvc;
using Microsoft.Exchange.WebServices.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using To_Do_List_Part1.Models;

namespace To_Do_List_Part1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly AppSettings _appSettings;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var response = new ServiceResponse();
            //response = 
            //return PartialView("~/Areas/setup/Views/section/_RowList.cshtml", response.Data);
            string query = "Select * from items";
            List<to_do_task> lsttasks = new List<to_do_task>();
            //lsttasks = 'ksjdfn';
            return View(lsttasks);
        }
        //public async Task<IActionResult> Index()
        //{
        //    //DbSet<to_do_task> tasklist = WebAppDbContext.Tasks
        //    //    .Include(path: c => c.Title)
        //    //    .AsNoTracking();
        //    return View(await tasklist.ToListAsync());
        //}
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
