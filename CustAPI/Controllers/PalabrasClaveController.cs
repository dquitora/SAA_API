using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAA_API.Controllers
{
    public class PalabrasClaveController : Controller
    {
        // GET: PalabrasClaveController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PalabrasClaveController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PalabrasClaveController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PalabrasClaveController/Create
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

        // GET: PalabrasClaveController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PalabrasClaveController/Edit/5
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

        // GET: PalabrasClaveController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PalabrasClaveController/Delete/5
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
