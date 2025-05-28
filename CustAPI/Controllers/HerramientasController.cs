using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAA_API.Controllers
{
    public class HerramientasController : Controller
    {
        // GET: HerramientasController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HerramientasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HerramientasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HerramientasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HerramientasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HerramientasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HerramientasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HerramientasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
