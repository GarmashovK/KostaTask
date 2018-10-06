using AutoMapper;
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
            if (ModelState.IsValid) {
                var service = EmployeClientService.GetChannel();

                try {
                    service.SetEmploye(Mapper.Map<Employe>(model));
                } catch (Exception e) {
                    ModelState.AddModelError("", e.Message);
                    return View();
                }
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Find(
            FindEmployeViewModel model,
            IEnumerable<Employe> match) {
            if (match != null) {
                ViewBag.Employees = Mapper.Map<IEnumerable<Employe>, IEnumerable<GetEmployeViewModel>>(match);
            }
            if (model != null) {
                return View(model);
            } else {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Find(FindEmployeViewModel model) {
            var service = EmployeClientService.GetChannel();

            var employees = service.GetEmployees(model.FirstName, model.LastName, model.Patronymic);

            return Find(model,employees);
        }
    }
}