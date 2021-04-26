using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using To_Do_List_Part1.Models;

namespace To_Do_List_Part1.Controllers
{
    public class todolistcontroller : Controller
    {
        public IActionResult list()
        {
            List<to_do_task> lsttasks = new List<to_do_task>();
            return View(lsttasks);
        }
        public IActionResult add()
        {
            return View();
        }
    }
}
