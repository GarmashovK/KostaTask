using EmployeServiceLib.Models;
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
            var service = EmlopyeClientService.GetChannel();

            try {
                service.SetEmploye(new Employe() {
                    FirstName = model.FirstName,
                });
            }catch(Exception e){

            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Find(FindEmployeViewModel model) {

            return null;
        }
    }
}