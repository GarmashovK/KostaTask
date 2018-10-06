using KostaWebTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KostaWebTask.Controllers
{
    public class EmployeController : Controller
    {
        // GET: Employe
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add() {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AddEmployeViewModel model) {
            
            return RedirectToAction("Index", "Home");
        }

        public ActionResult GetAll() {

        }
    }
}