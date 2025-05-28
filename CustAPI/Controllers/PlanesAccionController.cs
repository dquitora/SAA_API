using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAA_API.Controllers
{
    public class PlanesAccionController : Controller
    {
        // GET: PlanesAccionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PlanesAccionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlanesAccionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlanesAccionController/Create
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

        // GET: PlanesAccionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlanesAccionController/Edit/5
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

        // GET: PlanesAccionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlanesAccionController/Delete/5
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
